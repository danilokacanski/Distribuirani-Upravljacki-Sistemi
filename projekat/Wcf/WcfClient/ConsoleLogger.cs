using System;

namespace ClientApp
{
    // Logger za konzolu
    internal class ConsoleLogger
    {
        // obično ispis u beloj
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // ispis u drugoj boji
        public void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
