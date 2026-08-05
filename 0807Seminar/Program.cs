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


            int menuChoice = 3;
            switch (menuChoice)
            {
                case 1: 
                    Console.WriteLine("메뉴 1 선택");
                    break;
                case 2:
                    Console.WriteLine("메뉴 2 선택");
                    break;
                case 3:
                    Console.WriteLine("메뉴 3 선택");
                    break;
                default:
                    Console.WriteLine("잘못된 선택");
                    break;
            }



        }
    }
}