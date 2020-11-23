using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _064_Func_default
{
    class Program
    {
        static void PrintValue(int a, int b, int c = 100, int d = 0)
        {
            Console.WriteLine("PrintValue: {0}  {1}  {2}  {3}", a, b, c, d);
        }
        static void Main(string[] args)
        {
            PrintValue(0, 0, 0, 0);
            PrintValue(100, 2, 1);
            PrintValue(300, 200);
        }
    }
}