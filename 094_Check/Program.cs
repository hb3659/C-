using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _094_Check
{
    class SumNum
    {
        private int Num1;
        private int Num2;
        public void InputNum()
        {
            Console.Write("첫번째 수를 입력하세요: ");
            Num1 = int.Parse(Console.ReadLine());

            Console.Write("두번째 수를 입력하세요: ");
            Num2 = int.Parse(Console.ReadLine());
        }
        public void PrintSum()
        {
            Console.WriteLine("{0} + {1} = {2}", Num1, Num2, (Num1 + Num2));
        }
    }
    class Program
    {
        static bool Check()
        {
            int temp = 0;

            Console.Write("추가로 계산할까요? (1: Yes 0: No, 총 계산 횟수는 10회 입니다.): ");
            temp = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (temp == 1)
                return false;
            else
                return true;
        }
        static void Main(string[] args)
        {
            const int MAX = 10;
            SumNum[] sn = new SumNum[MAX];

            int count = 0;

            for (int i = 0; i < MAX; i++)
            {
                sn[i] = new SumNum();       // 각 배열마다 인스턴스화
            }

            while (true)
            {
                sn[count].InputNum();
                sn[count].PrintSum();

                count++;

                Console.WriteLine();
                if(count>MAX || Check())
                {
                    for(int i = 0; i < count; i++)
                    {
                        sn[i].PrintSum();
                    }

                    break;
                }
            }
        }
    }
}
