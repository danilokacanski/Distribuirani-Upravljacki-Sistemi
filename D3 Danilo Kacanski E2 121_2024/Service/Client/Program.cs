using ServiceReference;
using System;
using System.ServiceModel;

namespace Client
{   
    public static class Config      // konfiguracija osnovnih parametara
    {
        public const int MinNumber = 0;
        public const int MaxNumber = 10;
        public const string EndpointUrl = "http://localhost:57052/Service.svc/sub";
    }

    class PlayerCallback : ISubscriberCallback
    {   
        // server javlja klijentu da su se izvukli brojevi
        public void OnNotified(int FirstNumber, int SecondNumber, Dictionary<int, Player> OrderedPlayers)
        {
            int Rank = OrderedPlayers.Keys.ToList().IndexOf(Program.Player.Credentials.Id);
            Player Player = OrderedPlayers.Values.ToList()[Rank];
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine($"                Vasi brojevi: {Player.Ticket.FirstNumber}, {Player.Ticket.SecondNumber}");
            Console.WriteLine($"                Izvuceni brojevi: {FirstNumber}, {SecondNumber}");
            Console.WriteLine($"                Ukupna zarada: {Player.CurrentBalance}");
            Console.WriteLine($"                Pozicija na tabeli: {Rank + 1}");
            Console.ResetColor();
        }
    }

    internal class Program
    {
        static SubscriberClientBase? ServiceReference;
        public static Player? Player;
        static void Main(string[] args)
        {
            // inicijalizacija konteksta i veze sa WCFom
            InstanceContext context = new(new PlayerCallback());
            WSDualHttpBinding binding = new();
            EndpointAddress endpointAddress = new(Config.EndpointUrl);
            ServiceReference = new(context, binding, endpointAddress);

            InitPlayer();
            Console.ReadLine();
        }

        static void InitPlayer()
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("                     Vase ime:");
            string firstName = CheckForString();

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("                     Vase prezime");
            string lastName = CheckForString();

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("         Unesite Vas jednistveni broj (JMBG/Broj Licne karte):");
            Console.WriteLine("  Ukoliko Vas broj nije jednistven bicete onemoguceni da ucestvujete!");
            int id = CheckForInt(0, int.MaxValue);

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("      Prvi broj Vaseg loto listica (mora biti izmedju 0 i 10):");
            int firstNumber = CheckForInt(Config.MinNumber, Config.MaxNumber);

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("      Drugi broj Vaseg loto listica (mora biti izmedju 0 i 10):");
            int secondNumber = CheckForInt(Config.MinNumber, Config.MaxNumber);

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("                 Suma koju zelite da ulozite:");
            int investedMoney = CheckForInt(0, int.MaxValue);

            Player = new()
            {
                Credentials = new()
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName
                },
                Ticket = new()
                {
                    FirstNumber = firstNumber,
                    SecondNumber = secondNumber,
                    InvestedMoney = investedMoney
                },
                CurrentBalance = 0
            };
            // pozivanje metode za inicijalizaciju igraca na serveru
            ServiceReference?.InitPlayer(Player);
        }

        static string CheckForString()   
        {
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                         Uspesan unos!");
                    Console.ResetColor();
                    return input;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("         Sve sem praznog polja se prihvata. Unesite bilo sta:");
                Console.ResetColor();
            }
        }

        static int CheckForInt(int lowerLimit, int upperLimit)
        {
            int num;
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out num) && num >= lowerLimit && num <= upperLimit)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("                         Uspesan unos!");
                    Console.ResetColor();
                    return num;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" Molimo Vas uneste broj u opsegu: {lowerLimit} - {upperLimit}.");
                Console.ResetColor();
            }
        }
    }
}
