using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0814Seminar
{
    class Polygon //base class 
    {
        public int NumberOfSides { get; set; }

        public Polygon() { NumberOfSides = 0; }
        public Polygon(int numberOfSides) { NumberOfSides = numberOfSides; }

    }


    class Square : Polygon // Polygon 클래스 상속
    {
        public float Size { get; set; }
        public Square(float size)
        {
            Size = size;
            NumberOfSides = 4; // 부모 클래스에서 받은 속성사용 


        }


        static void Main(string[] arg)
        {

            Polygon polygon = new Square(4.5f);

            if (polygon is Square)
            {
                Square square = (Square)polygon;    
                Console.WriteLine (square.Size);
            }

        }






    }
}
