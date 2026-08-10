using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0814Seminar
{
    class ch19
    {

        private int score; //Score 속성의 배킹필드

        public int Score //Score 속성 
        {
            get { return score; } //get함수 score 반환

            set
            {
                score = value; //외부에서 할당된 val을 score에 저장
                if (score < 0) score = 0; //유효한지 검사 음수면 0으로 ㅔㅅ팅
            }


        }
    }

}
