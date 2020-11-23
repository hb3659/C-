using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*   
    constructor(생성자)
    객체를 생성할 때 호출되는 메서드
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
