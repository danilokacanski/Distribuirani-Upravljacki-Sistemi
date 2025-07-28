using System;
using System.Collections.Concurrent;
using System.Linq;
using System.ServiceModel;
using System.Timers;

namespace WcfService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WorkerCoordinator : IService
    {
        // ID radnika → detalji
        private readonly ConcurrentDictionary<int, WorkerInfo> _workers
            = new ConcurrentDictionary<int, WorkerInfo>();
        // proverava „pulse” svakih sekundu
        private readonly Timer _monitorTimer;
        private readonly Random _rnd = new Random();
        private const int CheckInterval = 1000;
        private const int HeartbeatTimeoutSeconds = 15;
        private const int MaxActive = 5;
        private readonly object _sync = new object();

        public WorkerCoordinator()
        {
            _monitorTimer = new Timer(CheckInterval) { AutoReset = true };
            _monitorTimer.Elapsed += MonitorWorkers;
            _monitorTimer.Start();
            Console.WriteLine("[Service] Koordinator pokrenut.");
        }

        public Message Register(int id)
        {
            Console.WriteLine($"[Service] Radnik {id} zahteva registraciju.");
            lock (_sync)
            {
                var info = new WorkerInfo
                {
                    State = WorkerState.Standby,
                    LastHeartbeat = DateTime.UtcNow,
                    Callback = OperationContext.Current.GetCallbackChannel<ICallback>()
                };

                if (!_workers.TryAdd(id, info))
                {
                    Console.WriteLine($"[Service] Radnik {id} je već registrovan.");
                    return new Message { Status = MessageStatus.Error, Error = MessageError.AlreadyRegistred };
                }

                // aktiviraj do MaxActive radnika
                if (_workers.Values.Count(w => w.State == WorkerState.Active) < MaxActive)
                {
                    SetState(id, WorkerState.Active);
                    Console.WriteLine($"[Service] Radnik {id} aktiviran.");
                }
                else
                {
                    Console.WriteLine($"[Service] Radnik {id} ide u Standby.");
                }

                return new Message { Status = MessageStatus.Ok };
            }
        }

        public void SendHeartbeat(int id)
        {
            if (_workers.TryGetValue(id, out var info))
            {
                if (info.State == WorkerState.Dead)
                {
                    Console.WriteLine($"[Service] Kasni heartbeat od mrtvog {id}.");
                    info.Callback.ShutdownWorker();
                }
                else
                {
                    info.LastHeartbeat = DateTime.UtcNow;
                }
            }
        }

        private void MonitorWorkers(object _, ElapsedEventArgs __)
        {
            lock (_sync)
            {
                foreach (var kv in _workers)
                {
                    var id = kv.Key;
                    var info = kv.Value;

                    if (info.State == WorkerState.Active &&
                        DateTime.UtcNow - info.LastHeartbeat > TimeSpan.FromSeconds(HeartbeatTimeoutSeconds))
                    {
                        SetState(id, WorkerState.Dead);
                        Console.WriteLine($"[Service] Radnik {id} nije slao heartbeat → označen Dead.");

                        var standby = _workers
                            .Where(x => x.Value.State == WorkerState.Standby)
                            .Select(x => x.Key)
                            .ToList();

                        if (standby.Any())
                        {
                            var replacer = standby[_rnd.Next(standby.Count)];
                            SetState(replacer, WorkerState.Active);
                            Console.WriteLine($"[Service] Standby {replacer} preuzima posao.");
                        }
                    }
                }
            }
        }

        private void SetState(int id, WorkerState newState)
        {
            var info = _workers[id];
            info.State = newState;
            if (newState == WorkerState.Active)
                info.LastHeartbeat = DateTime.UtcNow;

            try
            {
                info.Callback.ChangeWorkerState(newState);
            }
            catch
            {
                // ignorisanje neuspelih callback-a
            }

            // obavesti sve o novoj listi aktivnih
            var actives = _workers
                .Where(x => x.Value.State == WorkerState.Active)
                .Select(x => x.Key)
                .OrderBy(x => x)
                .ToArray();

            Console.WriteLine($"[Service] Trenutno aktivni radnici: [{string.Join(", ", actives)}]");
            BroadcastActiveList(actives);
        }

        private void BroadcastActiveList(int[] actives)
        {
            foreach (var kv in _workers)
            {
                try
                {
                    kv.Value.Callback.UpdateActiveWorkers(actives);
                }
                catch
                {
                    // ignorisanje neuspelih callback-a
                }
            }
        }
    }
}
