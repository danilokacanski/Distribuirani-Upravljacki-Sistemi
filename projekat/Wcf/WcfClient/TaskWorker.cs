using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace ClientApp
{
    internal class TaskWorker : ICallback
    {
        private readonly IService _proxy;
        private readonly int _id;
        private readonly ConsoleLogger _logger = new ConsoleLogger();
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly Timer _heartbeatTimer;

        // za praćenje kad je lista aktivnih promenjena
        private readonly List<int> _lastPrintedList = new List<int>();
        private int[] _currentActive = Array.Empty<int>();

        private bool _workingStarted = false;
        private bool _controlScheduled = false;
        private readonly Random _rnd = new Random(Guid.NewGuid().GetHashCode());

        private WorkerState _state = WorkerState.Standby;
        public WorkerState CurrentState => _state;
        public int Id => _id;

        private const int HeartbeatInterval = 5000;
        private const int WorkInterval = 5000;

        public TaskWorker(int id)
        {
            _id = id;
            _proxy = ServiceProxyFactory.CreateProxy(this);

            // svaki interval šaljemo heartbeat servisu
            _heartbeatTimer = new Timer(HeartbeatInterval) { AutoReset = true };
            _heartbeatTimer.Elapsed += (_, __) => _proxy.SendHeartbeat(_id);
        }

        public Message Register() => _proxy.Register(_id);

        public void StartHeartbeat() => _heartbeatTimer.Start();
        public void StopHeartbeat() => _heartbeatTimer.Stop();

        public void DoWork()
        {
            var token = _cts.Token;
            try
            {
                while (!token.IsCancellationRequested)
                {
                    // radimo samo ako smo zaista aktivni
                    if (_state == WorkerState.Active && _currentActive.Contains(_id))
                    {
                        // čekamo da heartbeat timer stvarno krene
                        while (!_heartbeatTimer.Enabled && !token.IsCancellationRequested)
                            Thread.Sleep(100);

                        _logger.Log($"[Worker {_id}] WORKING... {DateTime.UtcNow:HH:mm:ss}");
                        Thread.Sleep(WorkInterval);
                        token.ThrowIfCancellationRequested();
                    }
                    else
                    {
                        // inače samo kratko spavamo
                        Thread.Sleep(500);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // zaustavljanje bez buke
            }
            finally
            {
                StopHeartbeat();
                _heartbeatTimer.Dispose();
                _cts.Dispose();
            }
        }

        public void StopWork()
        {
            StopHeartbeat();
            _cts.Cancel();
        }

        public void ChangeWorkerState(WorkerState newState)
        {
            _state = newState;

            if (newState == WorkerState.Active)
            {
                StartHeartbeat();
                if (!_workingStarted)
                {
                    _workingStarted = true;
                    Task.Run(DoWork);
                }
                if (!_controlScheduled)
                {
                    _controlScheduled = true;
                    // zakazujemo svoj crash ili pauzu heartbeat‑a
                    int delayMs = _rnd.Next(10_000, 30_000);
                    bool willDie = _rnd.Next(5) == 3;
                    Task.Run(async () =>
                    {
                        await Task.Delay(delayMs);
                        if (willDie)
                            StopWork();
                        else
                        {
                            StopHeartbeat();
                            await Task.Delay(20_000);
                            StartHeartbeat();
                        }
                    });
                }
            }
            else if (newState == WorkerState.Standby)
            {
                StopHeartbeat();
            }
            else // Dead
            {
                StopWork();
            }
        }

        public void UpdateActiveWorkers(int[] activeIds)
        {
            _currentActive = activeIds.OrderBy(x => x).ToArray();

            // samo najmanji ID ispisuje kad se lista promeni
            if (_currentActive.Length > 0
                && _currentActive.First() == _id
                && !_lastPrintedList.SequenceEqual(_currentActive))
            {
                _lastPrintedList.Clear();
                _lastPrintedList.AddRange(_currentActive);
                _logger.Log(
                    $"[Worker {_id}] Trenutno aktivni radnici: [{string.Join(", ", _currentActive)}]",
                    ConsoleColor.Green
                );
            }
        }

        public void ShutdownWorker() => StopWork();
    }
}
