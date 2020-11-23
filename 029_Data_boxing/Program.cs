using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _029_Data_boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;       // boxing
            int j = (int)o;     // unboxing
            i = 456;

            Console.WriteLine("i: {0}, o: {1}, j: {2}", i, o, j);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(i, o));

            /*string s = "123";
            object k = s;
            string x = (string)k;
            s = "666";

            Console.WriteLine("s: {0}, k: {1}, x:{2}", s, k, x);
            Console.WriteLine("ReferenceEquals: {0}", Object.ReferenceEquals(s, k));*/
        }
    }
}
