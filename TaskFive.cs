using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskFive
    {
        public static void addMatrixes(int x, int y)
        {
            Random rnd = new Random();
            int[,] a = new int[x, y];
            int[,] b = new int[x, y];
            int[,] c = new int[x, y];


            //generacja
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    a[ix, iy] = rnd.Next(100);
                }
            }
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    b[ix, iy] = rnd.Next(100);
                }
            }

            //liczy C
            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    c[ix, iy] = a[ix, iy] + b[ix, iy];
                }
            }
            ///Wyswietlanie
            Console.WriteLine("MACIERZ A:");

            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    Console.Write($"{a[ix, iy]}  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("MACIERZ B:");

            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    Console.Write($"{b[ix, iy]}  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("MACIERZ WYNIKOWA C:");

            for (int ix = 0; ix < x; ix++)
            {
                for (int iy = 0; iy < y; iy++)
                {
                    Console.Write($"{c[ix, iy]}  ");
                }
                Console.WriteLine("");
            }
        }
    }
}
