using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 1)
            {
                Console.WriteLine("지금 듣는 강의는 " + args[0]);
                Console.WriteLine(args[1] + "좋아요!!");
            }
            else
            {
                Console.WriteLine("args.Length < 1");
            }

            Console.ReadKey();
        }
    }
}
