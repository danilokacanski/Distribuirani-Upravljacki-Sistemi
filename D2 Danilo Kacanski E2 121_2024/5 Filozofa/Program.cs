using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_Filozofa
{
    // Ovaj program omogucava svakom filzofu da se naizmenicno zamisli i onda jede.
    // Da bi se to desilo mora da drzi obe viljuske.
    // Koriscenjem semafora sprecena su dva filozofa koji sede jedan pored drugog da jedu, cime se izbegava potencijalna
    // mrtva petlja i osigurava se da svaki filozof ima priliku da jede. 
    // Ovaj proces se zavrsava kada svi filozofi zavrse sa jelom.
    internal class Program
    {
        public static SemaphoreSlim[] forks = new SemaphoreSlim[5];         // niz semafora za koji se koriste za viljuske
        static void Main(string[] args)
        {
            Console.WriteLine("################################");
            Console.WriteLine("Filozofi su seli za sto da jedu!");
            Console.WriteLine("################################");
            for (int i = 0; i < 5; i++)
            {
                forks[i] = new SemaphoreSlim(1, 1);         // samo jedan filozof moze drzati viljusku
            } 
            
            List<Thread> philosophers = new List<Thread>(5);

            for (int i = 0;i < 5;i++)      // pokretanje niti za svakog filozofa
            {
                int index = i;
                Thread philosopher = new Thread(() => new Philosopher(index).Eat())
                {
                    Name = $"Filozof - {index}"
                };
                philosophers.Add(philosopher);
                philosopher.Start();
            }
                
            foreach (Thread t in philosophers)      // cekanje da svi zavrse sa jelom
            {
                t.Join();
            }
            Console.WriteLine("##################################");
            Console.WriteLine("Svi filozofi su zavrsili sa jelom!");
            Console.WriteLine("##################################");

        }
    }
}
