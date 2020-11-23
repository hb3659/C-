using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_01_classInheritance
{
    class Super
    {
        // private 속성이라면 상속X (가장 강력한 접근 제어자)
        // protected == 상속관계의 자식 클래스만 쓸 수 있다
        protected int a;
        public void Print()
        {
            Console.WriteLine("Super Print()");
        }
    }
    class Sub : Super
    {
        int b;
        public void Print()
        {
            Console.WriteLine("Sub Print() a: {0}, b: {0}", a, b);
        }

        // 부모 클래스의 멤버 변수를 받음
    }
    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();
            Sub sub = new Sub();
            sub.Print();
            super.Print();
        }
    }
}
