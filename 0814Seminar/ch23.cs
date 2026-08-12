using System;

namespace _0814Seminar
{
    public abstract class SearchEngine // 추상 클래스 
    {
        public abstract string[] Search(string findThis); //추상 메소드 - 본문 없음


        public void LogSearchQuery(string query) //추상 클래스 일반 메소드 가지기 가능 
        {
            Console.WriteLine($"쿼리 로그: {query}");
        }
    }


    public class BingSearch : SearchEngine // 위에 추상 클래스의 추상 메소드를 구현해야함 
    {
        public override string[] Search (string findThis) //override 반드시 필요
        {
            LogSearchQuery (findThis); //기반 클래스 일반 메소드 사용가능 
            Console.WriteLine($"BingSearch가 '{findThis}'를 검색합니다.");
            return new string[] { "Bing Result X", "Bing Result  Y" };
        }
    }



}
       