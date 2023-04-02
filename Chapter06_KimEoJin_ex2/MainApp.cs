using System;


namespace Chapter06_KimEoJin_ex2
{
    class MainApp
    {
        public static void Main()
        {
            double mean = 0;

            Mean(1, 2, 3, 4, 5,ref mean);

            Console.WriteLine("평균 : {0}", mean);

        }
        public static void Mean(
            double a, double b, double c, double d , double e, ref  double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
        
    }
}
 // 평균이 0이 나온이유 : Mean 메소드에서 mean 변수를 참조 호출로 받지 않았기 때문에 변수값이 안바뀐것같당
 //mean 변수에다가 ref 넣고  Mean 메소드에서도 mean앞에다가 ref넣은께 됬어용