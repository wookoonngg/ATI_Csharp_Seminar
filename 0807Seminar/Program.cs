using System;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {


            double a = double.PositiveInfinity;
            float b = float.NegativeInfinity;

            Console.WriteLine(a + 1);
            Console.WriteLine(b - 1);

            double nanValue = double.NaN;
            Console.WriteLine(nanValue);

            double undefinedRsult = 0.0 / 0.0;
            Console.WriteLine(undefinedRsult);

            int maximumInt = int.MaxValue; // int 타입이 가질 수 있는 최댓값
            int minimumInt = int.MinValue; // int 타입이 가질 수 있는 최솟
            short maximumShort = short.MaxValue; // short 타입이 가질 수 있는 최댓값

            Console.WriteLine($"int 최대값: {maximumInt}"); // 출력: int 최대값: 2147483647
            Console.WriteLine($"int 최소값: {minimumInt}"); // 출력: int 최소값: -2147483648
            Console.WriteLine($"short 최대값: {maximumShort}"); // 출력: short 최대값: 32767





        }
    }
}