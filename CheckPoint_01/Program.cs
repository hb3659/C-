using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckPoint_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const string LINE = "-----------------------------------";
            const int END_LINE = 33;

            int runnerA = 0;
            int runnerB = 0;
            int runnerC = 0;
            int runnerD = 0;

            Random rdm = new Random();

            while (true)
            {
                ++runnerA;
                ++runnerB;
                ++runnerC;
                ++runnerD;

                int rdmNum = rdm.Next(0, 4);

                switch (rdmNum)
                {
                    case 0:
                        ++runnerA;
                        break;
                    case 1:
                        ++runnerB;
                        break;
                    case 2:
                        ++runnerC;
                        break;
                    case 3:
                        ++runnerD;
                        break;
                }

                Console.WriteLine(LINE);

                for (int i = 0; i < runnerA; i++)
                    Console.Write(" ");
                Console.Write("A");

                for (int i = END_LINE - runnerA; i >= 0 ; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runnerB; i++)
                    Console.Write(" ");
                Console.Write("B");

                for (int i = END_LINE - runnerB; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runnerC; i++)
                    Console.Write(" ");
                Console.Write("C");

                for (int i = END_LINE - runnerC; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runnerD; i++)
                    Console.Write(" ");
                Console.Write("D");

                for (int i = END_LINE - runnerD; i >= 0; i--)
                    Console.Write(" ");
                Console.WriteLine("|");

                Console.WriteLine(LINE);

                if(runnerA >= END_LINE || runnerB >= END_LINE || runnerC >= END_LINE || runnerD >= END_LINE)
                {
                    string result = "Winner is ";

                    if (runnerA >= END_LINE)
                        Console.WriteLine(result + "A!");
                    else if (runnerB >= END_LINE)
                        Console.WriteLine(result + "B!");
                    else if (runnerC >= END_LINE)
                        Console.WriteLine(result + "C!");
                    else
                        Console.WriteLine(result + "D!");

                    Console.Write("다시 시작하려면 0을 입력 => ");

                    if (int.Parse(Console.ReadLine()) == 0)
                    {
                        runnerA = 0;
                        runnerB = 0;
                        runnerC = 0;
                        runnerD = 0;
                    }

                }

                Thread.Sleep(100);
                Console.Clear();
                
            }
        }
    }
}
