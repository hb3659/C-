using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 구조체는 값 타입 => 스택 메모리에 저장
 * 클래스는 참조 타입 => 힙 메모리에 저장
 * 
 * 생성자를 선언할 수 있으나 반드시 파라미터가 존재해야 한다
 * 상속이 불가능하다
 * 필드 선언시 const 또는 static으로 선언한 경우에만 초기화가 가능하다
 * new 연산자를 사용하지 않고 인스턴스화 할 수 있다
 * 
 * --> 변수의 크기가 작거나 수명이 짧고 자주 할당되는 객체는 구조체로 만드는 것이 좋다
 */
namespace _088_struct
{
    struct AA
    {
        public int x;
        public int y;
        //public AA()       // 에러 (파라미터 없음)
        public AA(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Print()
        {
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA(10,20);
            aa.x = 100;
            aa.Print();

            AA aaa;     // new 없이 인스턴스화 가능
            aaa.x = 100;
            aaa.y = 200;
            aaa.Print();

            AA copyAA = aa;     // Value Type
            copyAA.x = 1000;
            copyAA.y = 2000;
            copyAA.Print();

            aa.Print();
        }
    }
}
