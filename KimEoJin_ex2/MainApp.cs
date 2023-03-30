using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimEoJin_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            for (int a = 5; a >= 1; a--)
            {
                for (int b = 0; b < a; b++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
}