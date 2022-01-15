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
                int najmniejszy = 0;
                int najwiekszy = 0;
                double sredniaWszystkich = 0;
                int liczbaDodatnichElementow = 0;


                for (int x = 0; x < tablica.Length; x++)
                {
                    if (najmniejszy > tablica[x])
                    {
                        najmniejszy = tablica[x];
                    }
                    if (najwiekszy < tablica[x])
                    {
                        najwiekszy = tablica[x];
                    }
                    if (tablica[x] > 0)
                    {
                        liczbaDodatnichElementow++;
                    }
                    sredniaWszystkich += tablica[x];
                }
                int a = Array.IndexOf(tablica, najmniejszy);
                int b = Array.IndexOf(tablica, najwiekszy);
                sredniaWszystkich = sredniaWszystkich / tablica.Length;
                Console.WriteLine("\nNajmniejszy element wynosi: {0} wartość tego elementu znajduje się w indexie: {1} \nNajwiekszy element wynosi: {2} wartość tego elementu znajduje się w indexie: {3} \nLiczba dodatnich elementow wynosi: {4} \nSrednia wartosci wszystkich elementow wynosi: {5}", najmniejszy, a, najwiekszy, b, liczbaDodatnichElementow, sredniaWszystkich);
                Console.ReadKey();
            }

        }
    }