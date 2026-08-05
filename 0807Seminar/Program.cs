using System;

namespace ch9
{
   
    public class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int result = Factorial(5);
            Console.WriteLine($"Factorial of 5 is: {result}");


        }
    }
}