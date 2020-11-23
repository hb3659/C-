using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _083_override
{
    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }
    class AA : Super
    {
        public int a;
        public override void Print()
        {
            base.Print();

            Console.WriteLine("AA a: {0}", a);
        }
    }
    class BB : Super
    {
        public int b;
        public override void Print()
        {
            base.Print();
            Console.WriteLine("BB b: {0}", b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Super super = new Super();
            super.Print();

            Super aa = new AA();
            aa.Print();

            Super bb = new BB();
            bb.Print();
        }
    }
}
