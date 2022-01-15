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
            List<int> denominators = new List<int>();
            int sumofdenominators = 0;
            for (int i = 1; i < input; i++)
            {
                int change = input % i;
                if (change == 0) { denominators.Add(i); }
            }
            foreach (int item in denominators)
            {
                sumofdenominators += item;
            }
            return (sumofdenominators == input) ? true : false;
        }
        public static List<int> perfectInRange(int input)
        {
            List<int> listOfPerfectInRange = new List<int>();
            for (int i = 6; i < input; i++) //6, bo 6 to najmniejsza "doskonała liczba, nie ma sensu sprawdzać niżej
            {
                if (isPerfect(i)) listOfPerfectInRange.Add(i);
            }
            foreach (int item in listOfPerfectInRange)
            {
                Console.WriteLine(item);
            }
            return listOfPerfectInRange;
        }
    }
}