using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskSeven
    {
        public static void work()
        {
            string[] tab = { "COM-1996", "PRI-2003", "DES-2020", "KEYB-2006", "DISP-2012" };
            for (int i = 0; i < tab.Length; i++)
            {
                string[] datazakupu1 = tab[i].Split('-');
                Console.WriteLine($"Dla produktu: {datazakupu1[0]}");
                int datazakupu = DateTime.Now.Year - Convert.ToDateTime($"1/1/{datazakupu1[1]}").Year;
                string ileodzakupu = (datazakupu < 0) ? $"uplynely {datazakupu} lata" : $"uplynelo {datazakupu} lat";
                Console.WriteLine($"Od daty zakupu {ileodzakupu}");
            }
        }
    }
}
