using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskThree
    {
        public static void tables()
        {
                int[] tablica = new int[10] { 5,235,1234,5,-2345,-2,53,2341,-34,-34534 };
                int min = 0;
                int max = 0;
                double average = 0;
                int positiveCount = 0;
                for (int x = 0; x < tablica.Length; x++)
                {
                    if (min > tablica[x]) { min = tablica[x]; }
                    if (max < tablica[x]) { max = tablica[x]; }
                    if (tablica[x] > 0) { positiveCount++; }
                    average += tablica[x];
                }
                int a = Array.IndexOf(tablica, min);
                int b = Array.IndexOf(tablica, max);
                average = average / tablica.Length;
                Console.WriteLine($"Najmniejszy element wynosi: {min} wartość tego elementu znajduje się w indexie: {a}\n"    +
                                  $"Najwiekszy element wynosi: {max} wartość tego elementu znajduje się w indexie: {b}\n"     +
                                  $"Liczba dodatnich elementow wynosi: {positiveCount}\n"                                     +
                                  $"Srednia wartosci wszystkich elementow wynosi: {average}");
            }

        }
    }