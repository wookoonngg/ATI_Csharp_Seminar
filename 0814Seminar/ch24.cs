namespace _0814Seminar
{


    public interface IFileWriter // 인터페이스 -> 멤버 선언만
    {
        string Extension { get; } // 구현 없는 속성 (읽기 전용)
        void Write(string filename_); // 구현 없는 메소드
    }


    public class TextFileWriter : IFileWriter //IFileWriter 인터페이스 구현
    {
        public string Extension //override 키워드 사용하지 않음
        {
            get { return ".txt"; }
        }

        public void Write(string filename) // 모든 메소드 public or abstract 이 때 abstract 키워드 사용 불가
        {
            Console.WriteLine($"텍스트 파일 '{filename + Extension}'에 내용을 씁니다.");
        }
    }


    public class RtfFileWriter : IFileWriter
    {
        public string Extension
        {
            get { return ".rtf"; }
        }

        public void Write (string filename)
        {
            Console.WriteLine($"RTF 파일 '{filename + Extension}'에 내용을 씁니다.");
        }
    }

    class ch24
    {
        static void Main(string[] args)
        {

            IFileWriter[] fileWriters = new IFileWriter[2];
            fileWriters[0] = new TextFileWriter();
            fileWriters[1] = new RtfFileWriter();


            foreach (IFileWriter writer in fileWriters)
            {
                writer.Write("document"); // 각 객체마다의 Write() 메소드가 호출됨 다형성 구현
            }

        }
    }
}
