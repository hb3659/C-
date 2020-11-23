using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021_Data_nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? a = 3.14;
            char? b = 'a';

            int num = 10;
            int? c = num;

            bool? isFlag = null;

            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("c: {0}", c);

            Console.WriteLine("isFlag: {0}", isFlag);
            Console.WriteLine("isFlag HasValue: {0}", isFlag.HasValue);

            if (isFlag.HasValue)
            {
                Console.WriteLine("is Flag HasValue: {0}", isFlag.HasValue);
            }
        }
    }
}
