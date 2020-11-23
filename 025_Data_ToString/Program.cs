using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025_Data_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b = 3.141592653589793238f;
            decimal c = 3.141592653589793238m;

            string strA = a.ToString();
            string strB = b.ToString();
            string strC = c.ToString();

            Console.WriteLine("a.ToString(): {0}", strA);
            Console.WriteLine("b.ToString(): {0}", strB);
            Console.WriteLine("c.ToString(): {0}", strC);
        }
    }
}
