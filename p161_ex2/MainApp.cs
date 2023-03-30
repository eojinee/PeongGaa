using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p161_ex2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 2개와 연산기호를 입력해주세요!");
            Console.Write("첫번째 정수를 입력해주세요.:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("두번쨰 정수를 입력해주세요.:");
            int b = int.Parse(Console.ReadLine());

            Console.Write("연산기호를 입력해주세요. ex)+,-,*,/,% :");
            char op = char.Parse(Console.ReadLine());

            int result = 0;
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;

                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                case '%':
                    result = a % b;
                    break;


            }
            Console.WriteLine($"입력하신{a}{op}{b}의 결과값은 {result}입니다. ");
        }
    }
}