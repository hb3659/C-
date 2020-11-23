using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081_03_classInheritance
{
    class Super
    {
        int num;
        protected string name;
        public Super(int num)
        {
            this.num = num;
        }
        public void PrintSuper()
        {
            Console.WriteLine("Super num: {0}", num);
        }
    }
    class Sub : Super
    {
        string name;
        public Sub(int num, string name) : base(num)    // 부모의 생성자 함수에 파라미터가 필요하기 때문
        {
            this.name = name;
        }
        public void PrintSub()
        {
            base.name = "Super";
            base.PrintSuper();

            Console.WriteLine("Super name: {0}", base.name);
            Console.WriteLine("Sub name: {0}", this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Sub sub = new Sub(26, "Jack");
            sub.PrintSub();
        }
    }
}
