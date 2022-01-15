using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskNine
    {
        enum MyEnum
        {
            Strength = 2,
            Dexterity,
            Constitution,
            Inteligence,
            Wisdom,
            Charisma,
        }
        public static void solution()
        {
            int iterator = 0;
            foreach (int i in Enum.GetValues(typeof(MyEnum)))
            {
                Console.WriteLine($"Enum z nazwą {Enum.GetNames(typeof(MyEnum))[iterator]} ma wartość liczbową {i}");
                iterator += 1;
            }
        }
    }
}
