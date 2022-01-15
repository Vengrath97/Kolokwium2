using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskTen
    {
        public static void makeMeProud(DateTime pastDate)
        {
            DateTime a = pastDate;
            DateTime b = DateTime.Now;
            Console.WriteLine($"Data wejściowa to: {a}.");
            Console.WriteLine($"Obecna data to: {b}.");
            Console.WriteLine($"in that past date, the day of week was: {a.DayOfWeek}");
            Console.WriteLine($"in that past date, the month was was: {a.ToString("MMMMMMMMM")}");
            Console.WriteLine($"Minęło {b.Year - a.Year} lat");
        }
    }
}