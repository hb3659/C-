using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _077_class
{
    class AA
    {
        // 멤버 변수
        int num1; // 기본적으로 private 속성
        public int num2, num3;

        // 멤버 함수
        public void Print()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc; {2}", num1, num2, num3);
        }

        private void PrintPrivate() // private 접근 한정자: 외부 접근 불가능
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc; {2}", num1, num2, num3);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.num2 = 100;
            aa.num3 = 1000;
            // aa.num1 = 10; // 에러: private 속성이기 때문

            aa.Print();
            // aa.PrintPrivate()   // private 속성이라 에러
        }
    }
}
