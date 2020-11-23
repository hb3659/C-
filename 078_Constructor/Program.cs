using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*   
    constructor(생성자)
        - 객체를 생성할 때 호출되는 메서드
        - 클래스와 이름이 동일
        - 생성자도 오버로딩 가능
        - 메소드와 같이 매개변수를 가질 수 있으며,
          메소드와 달리 특정 값을 반환할 수는 없고 반환형도 없다.
        - 따로 구현해주지 않아도 컴파일러에서 생성자를 직접 만들어준다.
          ==> 기본 생성자(default constructor)
        - 생성자 생성 이유?
          ==> 객체의 필드를 원하는 값으로 초기화하려고 할 때
              적합한 장소가 생성자이기 때문

    destructor(소멸자)
        객체를 소멸시킬 때 호출되는 메서드
        소멸자는 호출하지 않아도 자동 호출된다
*/

namespace _078_Constructor
{
    class AA
    {
        int a;
        float f;

        public AA()
        {
            a = 0;
            f = 0f;

            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a: {0}", a);
            Console.WriteLine(" f: {0}", f);
        }
        public AA(int _a)
        {
            a = _a;

            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a: {0}", a);
            Console.WriteLine(" f: {0}", f);
        }
        public AA(int _a, float _f)
        {
            a = _a;
            f = _f;

            Console.WriteLine(" Call Constructor ");
            Console.WriteLine(" a: {0}", a);
            Console.WriteLine(" f: {0}", f);
        }

        ~AA()
        {
            Console.WriteLine(" Call Destructor ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            AA aaa = new AA(10);
            AA aaaa = new AA(100, 0.5f) ;
        }
    }
}
