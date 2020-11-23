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
