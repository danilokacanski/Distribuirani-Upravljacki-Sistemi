using ClientApp;

namespace ClientApp
{
    internal class TaskWorkerFactory
    {
        // kreira TaskWorker i registruje ga kod servisa
        public static TaskWorker Create(int workerId)
        {
            var worker = new TaskWorker(workerId);
            var result = worker.Register();
            return result.Status == MessageStatus.Ok
                ? worker   // uspešna registracija
                : null;    // nije registrovan (npr. već postoji)
        }
    }
}
