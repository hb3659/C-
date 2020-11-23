using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * static 키워드 = 변수나 함수, 클래스에 정적 속성을 부여하는 것
 * 클래스로부터 객체를 생성하지 않고 변수나 함수를 호출할 수 있도록 해준다
 */
namespace _080_static
{
    class AA
    {
        public static int a;
        public static int b;
        public static readonly int c = 200;     // readonly == 상수화(읽기 전용)

        public int num;
        public static void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);

            //num = 100;   // 에러: static 속성의 메소드는 static 속성의 변수만 사용 가능하다
        }
    }
    class BB
    {
        public int a;
        public int b;
        public void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA.a = 10;      // 객체 생성 없이 바로 접근 가능
            AA.b = 100;     // 객체 생성 없이 바로 접근 가능
            //AA.c = 200;   // 오류: readonly 이므로 변경 불가

            AA.Print();     // 객체 생성 없이 바로 접근 가능

            // BB.a
            // BB.b
            // BB.Print     // 모두 오류(객체 생성 안했기 때문)

            BB bb = new BB();       // static 키워드가 없기 때문에 인스턴스화 시켜줘야 한다
            bb.a = 100;
            bb.b = 200;

            bb.Print();
        }
    }
}
