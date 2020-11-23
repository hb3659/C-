using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int max_grade = 0;
            int min_grade = 100;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요 ==> ");
                int grade = int.Parse(Console.ReadLine());

                if (grade > max_grade)
                {
                    max_grade = grade;
                }
                else if(grade < min_grade)
                {
                    min_grade = grade;
                }
            }

            Console.WriteLine("최고 성적: {0}  최저 성적: {1}", max_grade, min_grade);
        }
    }
}
