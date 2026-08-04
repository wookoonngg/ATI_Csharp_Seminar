using System;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = 3;
            int b = a++;
            Console.WriteLine($"a: {a}, b: {b}"); // b에는 원래 a 값이 할당되고 그 다음에 연산

            int c = 3;
            int d = ++c;
            Console.WriteLine($"c: {c}, d: {d}"); // c가 먼저 증가하고 그 다음할당 







        }
    }
}