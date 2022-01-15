using System;
using System.Collections.Generic;

namespace Kolokwium2
{
    class Program
    {
        static void Main(string[] args)
        {
            // zadanie 1; liczba to maksymalna do której wyswietlac
            Console.WriteLine("### Zadanie 1 ###");
            TaskOne.perfectInRange(9000);
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 2 
            Console.WriteLine("### Zadanie 2 ###");
            TaskTwo.Combinations();
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 3
            Console.WriteLine("### Zadanie 3 ###");
            TaskThree.tables();
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 4, pierwszy to minimalna, drugi to maksymalna
            Console.WriteLine("### Zadanie 4 ###");
            TaskFour.writePrimesInRange(1, 100);
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 5, tutaj są wymiariy x/y tych macierzy do wprowadzenia
            Console.WriteLine("### Zadanie 5 ###");
            TaskFive.addMatrixes(5, 5);
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 6
            Console.WriteLine("### Zadanie 6 ###");
            TaskSix.work();
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 7
            Console.WriteLine("### Zadanie 7 ###");
            TaskSeven.work();
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 8
            Console.WriteLine("### Zadanie 8 ###");
            Console.WriteLine("Wprowadz tekst do zaszyfrowania");
            TaskEight.ciptherThis(Console.ReadLine());
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 9
            Console.WriteLine("### Zadanie 9 ###");
            TaskNine.solution();
            Console.WriteLine("");
            Console.ReadKey();


            //zadanie 10
            Console.WriteLine("###Zadanie 10###");
            var pastDate = new DateTime(2012, 01, 15, 9, 30, 0);
            TaskTen.makeMeProud(pastDate);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
