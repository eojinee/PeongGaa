using System;

namespace KimEoJin_ex4
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.Write("반복 횟수를 입력하세요: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                return;
            }

            for (int a = 1; a <= number; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
