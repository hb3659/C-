using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int num = rdm.Next(1, 100);
            int count = 0;

            while (true)
            {
                Console.Write("1 ~ 99 사이 어떤 숫자일까요? (0 입력 시 종료) ==> ");
                int answer = int.Parse(Console.ReadLine());

                if(answer == num)
                {
                    Console.WriteLine("정답입니다!");
                    Console.WriteLine("총 {0}번 시도했습니다.",count);
                    break;
                }
                else
                {
                    if(answer > num)
                    {
                        Console.WriteLine("입력한 수보다 작습니다");
                    }
                    else
                    {
                        Console.WriteLine("입력한 수보다 큽니다.");
                    }
                    count++;
                }
            }
        }
    }
}
