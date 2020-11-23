using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _067_Check
{
    class Program
    {
        static void Start()
        {
            Console.WriteLine("성적 프로그램");
        }

        static void Input(ref int kor, ref int math, ref int eng)
        {
            Console.Write("국어 성적 입력: ");
            kor = int.Parse(Console.ReadLine());

            Console.Write("수학 성적 입력: ");
            math = int.Parse(Console.ReadLine());

            Console.Write("영어 성적 입력: ");
            eng = int.Parse(Console.ReadLine());
        }

        static int TotalSum(int kor, int math, int eng)
        {
            Console.WriteLine("kor: {0},  math: {1},  eng: {2}", kor, math, eng);
            return kor + eng + math;
        }

        static void Average(int total, out float average)
        {
            average = total / 3;
        }
        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int math = 0;
            int total;
            float average;

            Start();
            Input(ref kor, ref math, ref eng);
            total = TotalSum(kor, math, eng);
            Average(total, out average);

            Console.WriteLine("Total: {0}    Average: {1}", total, average);
        }
    }
}
