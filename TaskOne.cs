using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskOne
    {
        public static bool isPerfect(int input)
        {
            int sumofdenominators = 0;
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0) { sumofdenominators += i; }
            }
            return (sumofdenominators == input) ? true : false;
        }
        public static void perfectInRange(int input)
        {
            List<int> listOfPerfectInRange = new List<int>();
            for (int i = 6; i < input; i++) //6, bo 6 to najmniejsza "doskonała liczba, nie ma sensu sprawdzać niżej
            {
                if (isPerfect(i)) Console.WriteLine(i);
            }
        }
    }
}