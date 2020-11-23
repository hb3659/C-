using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수를 입력하세요 ");
            int kor = int.Parse(Console.ReadLine());
            Console.Write("영어 점수를 입력하세요 ");
            int eng = int.Parse(Console.ReadLine());
            Console.Write("수학 점수를 입력하세요 ");
            int mat = int.Parse(Console.ReadLine());
            Console.Write("과학 점수를 입력하세요 ");
            int sci = int.Parse(Console.ReadLine());

            int sum = kor + eng + mat + sci;
            float avg = sum / 4f;

            Console.WriteLine("총점: {0}     평균: {1}", sum, avg);
        }
    }
}
