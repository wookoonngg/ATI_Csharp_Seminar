using System;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = 75;
            string message = (score > 70) ? "합격!" : "불합격!";
            Console.WriteLine(message); 

            if (score> 70)
            {
                message = "합격";
            }
            else
            {
                message = "불합격";

            }








        }
    }
}