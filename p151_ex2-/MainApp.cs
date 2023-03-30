using System;


namespace p151_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요.");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number >= 90)
            {
                Console.WriteLine($"입력하신 점수는{number}(은) A학점 입니다.");

            }
            else if (number >= 80)
            {
                Console.WriteLine($"입력하신 점수는{number}(은) B학점 입니다.");

            }
            else if (number >= 70)
            {
                Console.WriteLine($"입력하신 점수는{number}(은) C학점 입니다.");

            }
            else if (number <= 69)
            {
                Console.WriteLine($"입력하신 점수는{number}(은) F학점 입니다.");
            }


        }
    }
}