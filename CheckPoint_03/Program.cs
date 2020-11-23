using System;
using System.Collections;
using System.Threading;

namespace CheckPoint_03
{
    class Program
    {
        const int DELAY_TIME = 100;
        const int FINISH_LINE = 47;
        static void UpdateView(char[] _tile, int[,] _map) 
        {
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    int tileIndex = _map[i, j];
                    Console.Write(_tile[tileIndex]);
                }
                Console.WriteLine();
            }
        }
        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }
        static void Run(int[] _arrindexX, int[,] _map)
        {
            for (int i = 0; i < _arrindexX.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = _arrindexX[i];

                int temp = _map[indexMaxX, indexY];  // temp = 3
                _map[indexMaxX, indexY + 1] = temp;
                _map[indexMaxX, indexY] = 0;

                _arrindexX[i]++;
            }
        }
        static bool RandomRun(Random _rnd, int[] _arrIndexX, int[,] _map)
        {
            bool isFinish = false;

            for (int i = 0; i < _arrIndexX.Length; i++)
            {
                if (_arrIndexX[i] > FINISH_LINE)
                {
                    return isFinish = true;
                }
            }

            int rndIndex = _rnd.Next(0, 5);
            int indexY = _arrIndexX[rndIndex];

            int temp = _map[rndIndex + 1, indexY];  // + 1 이유 == 울타리 제외하기 위해
            _map[rndIndex + 1, indexY + 1] = temp;
            _map[rndIndex + 1, indexY] = 0;

            _arrIndexX[rndIndex]++;

            return false;
        }
        static bool Check(bool _isFinish, int[] _arrIndexX, int[,] _map)
        {
            if (_isFinish)
            {
                Console.WriteLine();
                for (int i = 0; i < _arrIndexX.Length; i++)
                {
                    if (_arrIndexX[i] > FINISH_LINE)
                    {
                        Console.WriteLine("달리기 1등: {0}", i + 1);
                        break;
                    }
                }
                Console.Write("다시 시작하려면 0을 입력: ");
                string inputStr = Console.ReadLine();

                if (inputStr == "0")
                {
                    for (int i = 0; i < _arrIndexX.Length; i++)
                    {
                        _map[i + 1, _arrIndexX[i]] = 0;
                        _arrIndexX[i] = 0;
                        _map[i + 1, 0] = i + 3;
                        _map[i + 1, 49] = 2;
                    }
                }
                else
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //               0    1    2    3    4    5    6    7
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[7, 50]
            {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                {3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                {4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                {5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                {6,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                {7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };    // 주자(runnner) 출발선
            
            bool isFinish = false;

            while (true)
            { 
                Run(arrIndexX, map);
                isFinish = RandomRun(rnd, arrIndexX, map);
                UpdateView(tile, map);
                Check(isFinish, arrIndexX, map);
                ClearView();
            }
        }
    }
}
