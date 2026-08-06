using System;

namespace _0807Seminar
{
   
    public class Program
    {
        
        static void Main(string[] args)
        {
            MachineAgent eq1 = new MachineAgent("1호기", "Basler");
            MachineAgent eq2 = new MachineAgent("2호기", "Hikvision");
            MachineAgent eq3 = new MachineAgent("3호기", "Cognex"); 


            eq1.grab();
            eq2.grab();
            eq3.grab();

            // 메인에서 (아우라)는 어떤 카메라가 와도 그냥 grab 함수만 호출 코드 동일 


        }



    }
}