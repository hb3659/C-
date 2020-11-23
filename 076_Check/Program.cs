using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _076_Check
{
    class Program
    {
        static int InputNumber(int count)
        {
            int temp = 0;

            if (count == 0)
                Console.Write("첫번째 수를 입력해주세요: ");
            else
                Console.Write("두번째 수를 입력해주세요: ");

            temp =int.Parse(Console.ReadLine());

            return temp;
        }
        static void PrintResult(int a, int b)
        {
            Console.Write("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine();
        }
        static bool CheckEnd()
        {
            int temp = 0;

            Console.WriteLine("추가로 계산할까요? (1: YES, 0: NO, 단 총 10번까지 계산 가능)");
            temp = int.Parse(Console.ReadLine());

            if (temp == 1)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            int count = 0;
            const int MAX_COUNT = 10;

            int[] arrNum1 = new int[MAX_COUNT];
            int[] arrNum2 = new int[MAX_COUNT];

            while (true)
            {
                arrNum1[count] = InputNumber(0);
                arrNum2[count] = InputNumber(1);

                PrintResult(arrNum1[count], arrNum2[count]);

                count++;

                if(count >= MAX_COUNT || CheckEnd())
                {
                    for (int i = 0; i < count; i++)
                        PrintResult(arrNum1[i], arrNum2[i]);

                    break;
                }
            }
        }
    }
}
