using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _052_Operator_break
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = 0;

            while (true)
            {
                Console.Write("(1) 구구단 중 몇 단?   (2) 나가기 (0을 입력) ==> ");
                inputNum = int.Parse(Console.ReadLine());

                if((inputNum == 0))
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }

                for(int i = 1; i < 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", inputNum, i, inputNum * i);
                }
            }
        }
    }
}
