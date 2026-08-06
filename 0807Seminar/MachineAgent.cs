using System;
using System.Security.Cryptography.X509Certificates;

namespace _0807Seminar
{
    class MachineAgent
    {

        private string eq; // 장비 이름 ex) 카메라 종류 이름 ㄹㅇ hw
        private Camera camera; // 아까 만든 카메라 클래스 객체를 담아

        public MachineAgent(string eq, string cameraType)
        {
            this.eq = eq;

            if (cameraType == "Basler")
            {
                camera = new Camera(cameraType);
            }

            else if (cameraType == "Hikvision")
            {
                camera = new Camera(cameraType, true);
            }

            else if (cameraType == "Cognex")
            {
                camera = new Camera(cameraType, true, true);
            }
            else
            {
                Console.WriteLine(eq + "모르는 카메라입니다");

            }

        }


        public void grab()
        {

            if (camera == null)
            {
                Console.WriteLine(eq + " : 카메라가 없습니다");
                return;
            }


            Console.WriteLine(eq + " : 촬영 시작");
            camera.grab();
            Console.WriteLine(eq + " : 촬영 종료");
            Console.WriteLine();



        }




    }
}
