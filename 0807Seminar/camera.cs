using System;
namespace _0807Seminar
{
    class Camera
    {
        private string name; // 카메라 이름
        private bool trigger;  // 카메라 중 트리거가 필요한지 여부
        private bool light;   // 카메라 중 불 필요한 지 여부


        public Camera(string name)
        {

            this.name = name; // this keyword 사용해서 초기화
            trigger = false;  // 이건 기본 카메라 용 생성자 -> 트리거, 라이트 둘다 필요 없을때
            light = false;    // 판단은 machine agent 에서


         }


        public Camera (string name, bool trigger) // 생성자 오버로딩 
        {
            this.name = name;
            this.trigger = trigger;
            light = false; // 이건 트리거만 필요한 카메라 용 생성자
        }


        public Camera (string name, bool trigger, bool light)  // 생성자 오버로딩 
        {
            this.name = name;
            this.trigger = trigger;
            this.light = light; // 트리거 라이트 둘다 필요하니까 둘 다 필드 값을 받아와야함 


        }



        public string getName()
        {
            return name;
        }


        public void grab()
        {

            if (light)  // light가 트루로 들어오면 걸림
            {
                Console.WriteLine(getName() + " : 조명 ON 후 촬영 ");
            }

            if (trigger)  // 트리거 트루 시 걸림
            {
                Console.WriteLine(getName() + " : 트리거 발생 ");
            }


            Console.WriteLine(getName() + " : 촬영 완료 "); 

        }

    }
}
