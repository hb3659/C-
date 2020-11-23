using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _082_as
{
    class Base
    {
        int num;
        public void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }
    class AA : Base
    {
        int a;
        public void PrintA()
        {
            Console.WriteLine("a: {0}", a);
        }
    }
    class BB : Base
    {
        int b;
        public void PrintB()
        {
            Console.WriteLine("b: {0}", b);
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA();
            aa.Print();

            if(aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체입니다.");
            }else if(aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체입니다.");
            }

            Base bb = new BB();

            BB copyBB = bb as BB;   // 강제 형 변환
            // BB copyBB = (BB)bb;  // 가능

            if (null != copyBB)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("copyBB는 BB 객체를 형식 변환!!");
                copyBB.PrintB();
            }

            AA copyAA = bb as AA;
            if(null == copyAA)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("copyAA는 AA 객체가 아니므로 null!!");

                copyAA = new AA();
                copyAA.Print();
                // copyAA.PrintA()      // 가능하지만 원하는 값이 출력 안된다

                AA asAA = copyAA as AA;     // 강제 형 변환
                asAA.PrintA();
            }
        }
    }
}
