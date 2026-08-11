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
            S[] values = new S[10]; //S  구조체 배열을 기본값으로 일단 생성
            S item = values[0]; //item에 values[0]복사본이 할당
            item.Value++; // item 복사본 Value가 증가
            Console.WriteLine(values[0].Value); // 원본은 변함 없으니 출력 0


        } 


    }
}
