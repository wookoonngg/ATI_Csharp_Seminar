using System;

namespace ch9
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i == 3) 
                {
                    continue; // 아래 콘솔 코드 실행 안함
                }
                  Console.WriteLine(i);
                 }




        }
    }
}