using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("HelloWorld : " + args[0]);
            }
            else
            {
                Console.WriteLine("HelloWorld : args.length() == 0");
            }
            Console.ReadKey();
        }
    }
}
