using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_Data_const
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            const int MIN = 0;

            Console.WriteLine("MIN: {0} ~ MAX: {1}", MIN, MAX);

            // MAX = 1000;
            // 상수이기 때문에 변경 불가능
        }
    }
}
