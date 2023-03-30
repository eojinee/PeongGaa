using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimEoJin_ex3_2dowhile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            do
            {
                b = 1;
                do
                {
                    Console.Write("*");
                    b++;

                }
                while (b <= a);
                Console.WriteLine();
                a++;

            }
            while (a <= 5);
        }
    }
}