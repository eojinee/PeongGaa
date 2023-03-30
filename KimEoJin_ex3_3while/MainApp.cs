using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimEoJin_ex3_3while
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 5;
            while (a > 0)
            {
                int b = 0;
                while (b < a)
                {
                    Console.Write("*");
                    b++;
                }
                Console.WriteLine("");
                a--;
            }



        }
    }
}