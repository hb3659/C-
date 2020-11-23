using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckPoint_02
{
    class Program
    {
        const string LINE = "-----------------------------------";
        const int END_LINE = 33;
        const int PLAYING_TIME = 5;

        static int runnerA = 0;
        static int runnerB = 0;
        static int runnerC = 0;
        static int runnerD = 0;

        static void ClearScreen()
        {
            Thread.Sleep(PLAYING_TIME);
            Console.Clear();
        }

        static void Process(Random rnd)
        {
            ++runnerA;
            ++runnerB;
            ++runnerC;
            ++runnerD;

            int rndNum = rnd.Next(0, 4);

            switch (rndNum)
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
        }

        static void UpdateScreen()
        {
            Console.WriteLine(LINE);

            for (int i = 0; i < runnerA; i++)
                Console.Write(" ");
            Console.Write("A");

            for (int i = END_LINE - runnerA; i >= 0; i--)
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
        }

        static bool CheckResult()
        {
            if (runnerA >= END_LINE || runnerB >= END_LINE || runnerC >= END_LINE || runnerD >= END_LINE)
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
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            while (true)
            {
                ClearScreen();

                Process(rnd);

                UpdateScreen();

                if (CheckResult() == false)
                    break;
             }

         }
     }
}
