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
            Strength,
            Dexterity,
            Constitution,
            Inteligence,
            Wisdom,
            Charisma,
        }
        public static void solution()
        {
            int namesCount = Enum.GetNames(typeof(MyEnum)).Length;
            for (int i=0; i<namesCount; i++)
            {
                Console.WriteLine($"Enum z nazwą {Enum.GetNames(typeof(MyEnum))[i]} ma wartość liczbową {i}");
            }
        }
    }
}
