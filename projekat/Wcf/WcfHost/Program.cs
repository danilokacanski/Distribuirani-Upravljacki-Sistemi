using System;
using System.ServiceModel;
using WcfService;

namespace HostApp
{
    internal class Program
    {
        static void Main()
        {
            // adresa na kojoj hostujemo WCF servis
            var baseAddress = new Uri("http://localhost:8080/Service/");
            var host = new ServiceHost(typeof(WorkerCoordinator), baseAddress);

            // koristimo duplex binding bez sigurnosti
            var binding = new WSDualHttpBinding
            {
                Security = { Mode = WSDualHttpSecurityMode.None }
            };
            host.AddServiceEndpoint(typeof(IService), binding, "");

            try
            {
                host.Open(); // start servisa
                Console.WriteLine("[Host] Servis je pokrenut sa WSDualHttpBinding...");
                Console.ReadKey(); // čeka da korisnik stisne taster
                host.Close(); // uredno zatvaranje
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Host] Greška: {ex.Message}");
                host.Abort(); // silovito gašenje u slučaju greške
            }
        }
    }
}
