using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 * 094_Check를 입력 제한 없이 처리
 *  - 입력받은 두 수의 결과를 저장하는 프로그램
 *  - 제한없이 계속 입력받을 수 있음
 *  - 저장했던 자료 모두 보여주기
 */
namespace _102_Check
{
    class Number
    {
        private int num1;
        private int num2;

        public int N1 { get { return num1; } }
        public int N2 { get { return num2; } }

        public Number()
        {
            this.num1 = 0;
            this.num2 = 0;
        }

        public void inputNum()
        {
            Console.Write("Please enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter second number: ");
            num2 = int.Parse(Console.ReadLine());
        }
        public int sumNum()
        {
            return num1 + num2;
        }
    }
    class Program
    {
        static int selCal()
        {
            Console.Write("1. Calulate  0. Exit : ");
            int select = int.Parse(Console.ReadLine());

            return select;
        }
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            bool isLoop = true;

            while (isLoop)
            {
                if (selCal() == 1)
                {
                    Number num = new Number();
                    num.inputNum();
                    queue.Enqueue(num.N1 + " + " + num.N2 + " = " + num.sumNum()) ;

                    Console.WriteLine("{0} + {1} = {2}", num.N1, num.N2, num.N1 + num.N2);
                }
                else
                    isLoop = false;
            }

            foreach (object data in queue)
                Console.WriteLine(data);
        }
    }
}
