using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0814Seminar
{
    struct Wrapper
    {
        public int[] numbers; //참조 타입 필드
        public static void Main(string[] args)
        {
            Wrapper wrapper = new Wrapper();
            wrapper.numbers = new int[3] { 1, 2, 3 };
            UpdateArray(wrapper);
            Console.WriteLine(wrapper.numbers[1]);

        } 

        public static void UpdateArray(Wrapper wrapper)
        {
            wrapper.numbers[1] = 200;
        }




    }
}
