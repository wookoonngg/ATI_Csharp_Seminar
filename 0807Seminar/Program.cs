using System;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fruits = { "사과", "바나나", "체리" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }


            for(int i = 1; i <10; i++)
            {
                for (int j =1; j < 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }


            int[,] arr = new int[9,9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr[i,j] = (i + 1) * (j + 1);
                }
            }   


        }
    }
}