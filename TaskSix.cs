using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskSix
    {
        public static void work()
        {
            Console.WriteLine("Wprowadz tekst do przeszukania");
            string input = Console.ReadLine();
            List<char> charList = new();
            List<int> intList = new();
            for (int i=0; i<input.Length; i++)
            {
                if (isOnList(input[i], charList))
                { intList[getCharID(input[i], charList)] += 1; }
                else
                { charList.Add(input[i]); intList.Add(1); }
            }
            display(charList, intList);
        }

        static bool isOnList(char input, List<char> list)
        {
            foreach (char item in list)
            {
                if (input == item) return true;
            }
            return false;
        }
        static int getCharID(char input, List<char> charList)
        {
            for (int i = 0; i<charList.Count; i++)
            {
                if (input == charList[i]) { return i; }
            }
            return -1;

        }
        static void display(List<char> charList, List<int> intList)
        {
            int iterator = 0;
            foreach (char item in charList)
            {
                Console.WriteLine($"{item} występuje {intList[iterator]} razy");
                    iterator+= 1;
            }    
        }
    }
}
