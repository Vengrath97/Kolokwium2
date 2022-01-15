using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskFour
    {
        public static bool isPrime(int input)
        {
            if (input < 2) return false;
            if (input == 2) return true;
            bool isPrime = true;
            for (int i=2; i<input/2+2; i++)
            {
                if ((input % i) == 0) { isPrime = false; }
            }
            return isPrime;
        }
        public static void writePrimesInRange(int min, int max)
        {
            for (int i=min; i<=max; i++)
            {
                if (TaskFour.isPrime(i) == true) { Console.WriteLine(i); }
            }
        }
    }
}
