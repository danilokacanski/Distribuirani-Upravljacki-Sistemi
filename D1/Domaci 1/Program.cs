using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//                                  SINHRONO
// U sinhronom izvrsavanju program prolazi kroz listu sekvencijalno, jedan po jedan element.
// Zbir svih elemenata se racuna u jednoj petlji bez paralelizacije.
// Najsporiji i najlaksi pristup.
//                                  PARALELNO
// U paralelnom izvrsavanju lista se deli na delove prema broju niti.
// Koristi se Parallel.For sto omogucava da se vise niti istovremeno izvrsava i ubrzava obradu.
// Ovaj pristup koristi više jezgara procesora, efikasniji za velike podatke.
//
//                                  ASINHRONO
// U asinhronom izvrsavanju, lista se takodje deli na delove prema broju taskova - taskCount, slicnom logikom kao kod paralelnog izvrsavanja.
// Za svaki deo liste se kreira asinhroni zadatak Task.Run. Na kraju, pomocu await Task.WhenAll se sabiraju svi parcijalni rezultati i racuna se prosek.
// Najbolji pristup za upravljivost resursima.

namespace Domaci_1
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int elementCount = 100000000;
            int minValue = 0;
            int maxValue = 1000;

            // Inicijalizujemo listu sa 100 miliona nasumičnih vrednosti
            List<int> randomList = CreateList(elementCount);        // Radio sam i na klasican nacin i pomocu ove funckije kao Nenad jer mi izbaci da nema dovoljno
            // RAM-a i prekine se izvrsavanje ako se stavi da ima 1 000 000 000 elemenata, ali sa 100 000 000  radi normalno, tako da pretpostavljam da je do mog
            // PC-a problem, a da ce raditi inace
            for (int i = 0; i < elementCount; i++)
            {
                randomList.Add(random.Next(minValue, maxValue + 1));
            }

            // Definisemo broj niti koje cemo koristiti
            int[] threadCounts = { 2, 5, 10, 100 };

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Stopwatch sw = new Stopwatch();

            // Sinhrono izvrsavanje
            Console.WriteLine("Sinhrono izvrsavanje:");
            sw.Restart();
            double syncResult = CalculateAverageSynchronously(randomList);
            sw.Stop();
            Console.WriteLine($"Prosek: {syncResult}, Vreme: {sw.ElapsedMilliseconds} ms");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // Paralelno izvrsavanje
            Console.WriteLine("\nParalelno izvrsavanje:");
            foreach (var threadCount in threadCounts)
            {
                sw.Restart();
                double parallelResult = CalculateAverageInParallel(randomList, threadCount);
                sw.Stop();
                Console.WriteLine($"Prosek: {parallelResult}, Broj niti: {threadCount}, Vreme: {sw.ElapsedMilliseconds} ms");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }

            // Asinhrono izvrsavanje
            Console.WriteLine("\nAsinhrono izvrsavanje:");
            foreach (var threadCount in threadCounts)
            {
                sw.Restart();
                double asyncResult = CalculateAverageAsynchronously(randomList, threadCount).Result;
                sw.Stop();
                Console.WriteLine($"Prosek: {asyncResult}, Broj niti: {threadCount}, Vreme: {sw.ElapsedMilliseconds} ms");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }
        }

        // Inicijalizacija liste
        public static List<int> CreateList(int size)
        {
            Random random = new Random();
            Console.WriteLine($"Incijalizacija liste velicine {size} brojeva...");
            List<int> numbers = Enumerable.Range(0, size).Select(i => random.Next(0,1000)).ToList();
            Console.WriteLine("Gotovo!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            return numbers;

        }


        // Sinhrono izracunavanje proseka
        static double CalculateAverageSynchronously(List<int> list)
        {
            long totalSum = 0;

            // Prolazimo kroz svaki element liste sekvencijalno
            for (int i = 0; i < list.Count; i++)
            {
                totalSum += list[i];
            }

            return (double)totalSum / list.Count;
        }

        // Paralelno izracunavanje proseka
        static double CalculateAverageInParallel(List<int> list, int threadCount)
        {
            long[] partialSums = new long[threadCount];
            int partSize = list.Count / threadCount;

            Parallel.For(0, threadCount, i =>
            {
                int start = i * partSize;
                int end = (i == threadCount - 1) ? list.Count : (i + 1) * partSize;

                long partialSum = 0;
                for (int j = start; j < end; j++)
                {
                    partialSum += list[j];
                }
                partialSums[i] = partialSum;
            });

            return (double)partialSums.Sum() / list.Count;
        }

        // Asinhrono izracunavanje proseka
        static async Task<double> CalculateAverageAsynchronously(List<int> list, int taskCount)
        {
            int partSize = list.Count / taskCount;
            List<Task<double>> tasks = new List<Task<double>>();

            for (int i = 0; i < taskCount; i++)
            {
                int start = i * partSize;
                int end = (i == taskCount - 1) ? list.Count : (i + 1) * partSize;

                tasks.Add(Task.Run(() =>
                {
                    double partialSum = 0;
                    for (int j = start; j < end; j++)
                    {
                        partialSum += list[j];
                    }
                    return partialSum;
                }));
            }

            double[] results = await Task.WhenAll(tasks);
            return results.Sum() / list.Count;
        }
    }
}
