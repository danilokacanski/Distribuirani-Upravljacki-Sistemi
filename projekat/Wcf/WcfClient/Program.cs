using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class Program
    {
        static async Task Main()
        {
            var rnd = new Random();
            // nasumičan raspored ID-jeva 0–9
            var ids = Enumerable.Range(0, 10)
                                .OrderBy(x => rnd.Next())
                                .ToList();

            var workers = new List<TaskWorker>();
            var logger = new ConsoleLogger();

            // registrujem sve radnike
            foreach (var id in ids)
            {
                await Task.Delay(100);
                var w = TaskWorkerFactory.Create(id);
                if (w != null)
                    workers.Add(w);
            }

            // obaveštenja iz Main u plavoj
            logger.Log("[Main] Sve registracije završene; redosled je nasumičan.", ConsoleColor.Blue);

            // čekamo dok ne postanu Dead
            while (workers.Any(w => w.CurrentState != WorkerState.Dead))
            {
                await Task.Delay(500);
            }

            logger.Log("[Main] Svi radnici su završili. Izvršenje je gotovo.", ConsoleColor.Blue);
        }
    }
}
