using System;
using System.Linq;

namespace p151_ex5
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요.: ");
            string aa = Console.ReadLine();
            int a = Int32.Parse(aa);

            Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요.: ");
            string bb = Console.ReadLine();
            int b = Int32.Parse(bb);

            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요.: ");
            string cc = Console.ReadLine();
            int c = Int32.Parse(cc);

            int d = Math.Max(Math.Max(a, b), c);
            int e = Math.Min(Math.Max(a, b), c);
            Console.WriteLine($"입력하신 {a},{b},{c} 중 최대값은 {d}이며,최소값은 {e}입니다.");

            int f = a + b + c;
            int g = (a + b + c) / 3;
            Console.WriteLine($"입력하신{a},{b},{c} 의 합은 {f} 이며, 평균은 {g} 입니다.");
        }
    }
}