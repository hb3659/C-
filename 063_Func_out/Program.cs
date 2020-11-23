using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _063_Func_out
{
    class Program
    {
        static void initNum(out int addNum)
        {
            addNum = 100;
        }

        static void initRefNum(ref int refNum)
        {
            refNum = 100;
        }

        static void Main(string[] args)
        {
            int a;
            int b;

            initNum(out a);
            Console.WriteLine("a: " + a);

            b = 0;
            initRefNum(ref b);
            Console.WriteLine("b: " + b);
        }
    }
}
