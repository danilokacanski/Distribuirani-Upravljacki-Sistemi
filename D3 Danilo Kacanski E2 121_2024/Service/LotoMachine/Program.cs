using ServiceReference;

namespace Loto
{
    public static class Config
    {
        public const int SleepTime = 10000; // 10 sekundi pauza između izvlačenja
        public const int NumberMin = 0;
        public const int NumberMax = 10;
    }

    internal class Program
    {
        static PublisherClient PublisherClient = new();     // WCF klijent za publikovanje brojeva
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                i++;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine($"              IZVLACENJE BROJEVA RUNDA {i}");
                (int First, int Second) = WinningNumbers();

                Console.WriteLine($"              Dobitni brojevi su: {First} i {Second}");

                PublisherClient.Publish(First, Second);     // slanje brojeva svim prijavljenim klijentima
                Thread.Sleep(Config.SleepTime);         // pauza pre sledeceg izvacenja
            }
        }

        static (int, int) WinningNumbers()
        {
            Thread.Sleep(500); // Ceka se da se izvuku brojevi
            Random random = new();
            return (random.Next(Config.NumberMin, Config.NumberMax + 1), random.Next(Config.NumberMin, Config.NumberMax + 1));
        }
    }
}
