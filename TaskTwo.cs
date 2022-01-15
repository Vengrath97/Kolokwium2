using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskTwo
    {
        public static void Combinations()
        {
            Console.WriteLine("Start");
            int suma = 10;
            int count = 0;
            for (int zlotowki = 0; zlotowki <= suma; zlotowki++)
            {
                for (int dwuzlotowki = 0; dwuzlotowki <= suma; dwuzlotowki++)
                {
                    for (int pieciozlotowki = 0; pieciozlotowki <= suma; pieciozlotowki++)
                    {
                        if (zlotowki * 1 + dwuzlotowki * 2 + pieciozlotowki * 5 == suma)
                        {
                            Console.WriteLine("zlotowka = {0} dwa zlote = {1} piec zlote = {2}", zlotowki, dwuzlotowki, pieciozlotowki);
                            count += 1;
                        }
                    }
                }
            }
            Console.WriteLine($"Razem {count} możliwości");

        }
    }
}
