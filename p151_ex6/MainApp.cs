using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151_ex6
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요.(ex.2):");
            string a = Console.ReadLine();
            int grade = Int32.Parse(a);


            Console.Write("현재 본인의 점수를 입력해 주세요.(ex.85)");
            string b = Console.ReadLine();
            int score = Int32.Parse(b);

            if (score > 0 && score <= 100)
            {
                if (grade == 4)
                {
                    if (score >= 70)
                    {
                        Console.WriteLine($"입력하신 점수 {score}은(는) 합격입니다.");
                    }
                    else if (score < 70)
                    {
                        Console.WriteLine($"입력하신 점수 {score}은(는) 불합격입니다.");
                    }

                }

                else if (grade > 0 && grade <= 3)
                {
                    if (score >= 60)
                    {
                        Console.WriteLine($"입력하신 점수 {score}은(는) 합격입니다.");
                    }
                    else if (score < 60)
                    {
                        Console.WriteLine($"입력하신 점수 {score}은(는) 불합격입니다.");
                    }
                }
            }

            else
            {
                Console.WriteLine("점수를 잘못 입력하셨습니다. 확인후 다시 입력해주세요");
            }

        }
    }
}
