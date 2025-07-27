using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.ServiceProxy;
using ClientApp.Logging;

namespace ClientApp
{
    internal class Program
    {
        static async Task Main()
        {
            var rnd = new Random();
            var ids = Enumerable.Range(0, 10)
                                     .OrderBy(x => rnd.Next())
                                     .ToList();
            var workers = new List<TaskWorker>();
            var logger = new ConsoleLogger();

            // 1) Registracija
            foreach (var id in ids)
            {
                await Task.Delay(100);
                var w = TaskWorkerFactory.Create(id);
                if (w != null)
                    workers.Add(w);
            }

            // [Main] u plavoj boji
            logger.Log("[Main] Sve registracije završene; redosled je nasumičan.", ConsoleColor.Blue);
            logger.Log("[Main] Čekam da se svi radnici ugase...", ConsoleColor.Blue);

            // 2) Čekamo kraj
            while (workers.Any(w => w.CurrentState != WorkerState.Dead))
                await Task.Delay(500);

            logger.Log("[Main] Svi radnici su završili. Izvršenje je gotovo.", ConsoleColor.Blue);
        }
    }
}
