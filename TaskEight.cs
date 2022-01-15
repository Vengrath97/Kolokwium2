using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2
{
    class TaskEight
    {
        public static void ciptherThis(string text)
        {
            string cipher = "GADERYPOLUKI";
            string cipherText = String.Empty;
            text = text.ToUpper();
            for (int a = 0; a < text.Length; a++)
            {
                for (int b = 0; b < cipher.Length; b++)
                {
                    if (text[a] == cipher[b])
                    {
                        if      (b % 2 == 0)    { cipherText += cipher[b + 1]; }
                        else                    { cipherText += cipher[b - 1]; }
                    }
                }
                if (cipherText.Length - a == 0) { cipherText += text[a]; }
            }
            Console.WriteLine(cipherText);
        }
    }
}
