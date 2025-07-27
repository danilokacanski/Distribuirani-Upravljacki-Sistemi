using ClientApp.ServiceProxy;

namespace ClientApp
{
    internal class TaskWorkerFactory
    {
        public static TaskWorker Create(int workerId)
        {
            var worker = new TaskWorker(workerId);
            var result = worker.Register();
            return result.Status == MessageStatus.Ok ? worker : null;
        }
    }
}
