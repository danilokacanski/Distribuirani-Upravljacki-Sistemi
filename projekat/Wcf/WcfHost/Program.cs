using System;
using System.ServiceModel;
using WcfService;

namespace HostApp
{
    internal class Program
    {
        static void Main()
        {
            var baseAddress = new Uri("http://localhost:8080/Service/");
            var host = new ServiceHost(typeof(WorkerCoordinator), baseAddress);

            var binding = new WSDualHttpBinding
            {
                
                Security = { Mode = WSDualHttpSecurityMode.None }
            };
            host.AddServiceEndpoint(typeof(IService), binding, "");

            try
            {
                host.Open();
                Console.WriteLine("[Host] Servis je pokrenut sa WSDualHttpBinding...");
                Console.ReadKey();
                host.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Host] Greška: {ex.Message}");
                host.Abort();
            }
        }
    }
}
