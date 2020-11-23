using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Data8
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            int num = (int)a;

            Console.WriteLine("문자 : {0}, 아스키 코드 값 : {1}, 문자로 캐스트 연산 : {2}", a, num, (char)num);        }
    }
}
