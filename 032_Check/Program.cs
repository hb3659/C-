using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            float c = 0.123f;
            char d = 'A';

            Console.WriteLine("a: {0}, a.GetType(): {1}", a, a.GetType());
            Console.WriteLine("a: {0}, a.GetType(): {1}", b, b.GetType());
            Console.WriteLine("a: {0}, a.GetType(): {1}", c, c.GetType());
            Console.WriteLine("a: {0}, a.GetType(): {1}", d, d.GetType());
        }
    }
}
