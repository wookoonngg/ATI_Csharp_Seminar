using System;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[][] jaggedMatrix = new int[3][]; // 3행 행렬 하나 생성 
            jaggedMatrix[0] = new int[] { 1, 2, 3 }; // 첫 번째 행은 1,2,3 3개 배열 또 생성 
            jaggedMatrix[1] = new int[] { 4, 5 }; // 두 번째 행은 4,5 2개 배열 
            jaggedMatrix[2] = new int[] { 6, 7, 8, 9 }; // 세 번째 행은 6,7,8,9 4개 배열

            Console.WriteLine(jaggedMatrix[1][1]);

            int[,] rectangularMatrix = new int[2, 3]; // 2행 3열 행렬 생성
            rectangularMatrix[0, 0] = 1;
            rectangularMatrix[0, 1] = 2;
            Console.WriteLine(rectangularMatrix[0, 1]);


        }
    }
}