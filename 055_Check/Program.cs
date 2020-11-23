using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int num1;
            int num2;
            int count = 0;

            for(int i=0; i<5; i++)
            {
                Console.WriteLine("{0}: 다음 두 수의 합은 얼마일까요?", i+1);
                
                num1 = rdm.Next(0, 100);
                num2 = rdm.Next(0, 100);
                
                Console.Write("{0} + {1} = ", num1, num2);
                int result = int.Parse(Console.ReadLine());
                
                if(num1 + num2 == result)
                {
                    Console.WriteLine("정답입니다!\n");
                    count++;
                }
                else
                {
                    Console.WriteLine("정답은 {0} 입니다.\n", num1 + num2);
                }
            }
            Console.WriteLine("총 {0}문제 맞췄습니다!", count);
        }
    }
}
