using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_Filozofa
{
    internal class Philosopher
    {
        public int Index {  get; set; }

        public Philosopher(int index)
        { 
            Index = index;      // indeks koji odredjuje njegov broj, a i brojeve viljuski koje uzima
        }
        
        public void Eat()
        {
            int left = Index;       // leva i desna viljuska, stim da je leva uvek na broju filizofa, a za desnu se moze desiti za 4og da bude viljska broj 5
            int right = (Index + 1) % 5;        // koja ne postoji u sustini zbog kruznog stola pa ide moduo

            Console.WriteLine($"Filozof {Index} razmislja...");     // blokiranje viljuski
            Program.forks[left].Wait();
            Program.forks[right].Wait();

            Console.WriteLine($"Filozof {Index} jede sa viljuskama {left} i {right}.");     // simulacija jedenja
            Thread.Sleep(1000);

            Console.WriteLine($"Filozof {Index} je zavrsio sa jelom i spustio viljuske {left} i {right}.");     // oslobadjanje viljuski
            Program.forks[left].Release();
            Program.forks[right].Release();

            Console.WriteLine($"Filozof {Index} nastavlja da razmislja...");        // da se oznaci kraj svega
        }
    }
}
