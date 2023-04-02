using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimEoJin_ex3_4dowhile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int a = 5;
            do
            {
                for (int b = 0; b < a; b++)
                {
                    Console.WriteLine("*");

                }
                Console.WriteLine();
                a--;

            }
            while (a > 0);
        }
    }
}
