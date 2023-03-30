using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimEoJin_ex3_1while
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1;
            while (a <= 5)
            {
                b = 1;
                while (b <= a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine("");
                a++;
            }
        }
    }
}