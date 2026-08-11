using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0814Seminar
{
    struct S 
    {
        public int Value
        {
            get; set; //참조 타입 필드
        }
        public static void Main(string[] args)
        {
            S[] values = new S[10];
            S item = values[0];
            item.Value++;
            Console.WriteLine(values[0].Value);


        } 


    }
}
