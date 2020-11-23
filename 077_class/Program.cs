using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _077_class
{
    /*
       private
            1. 외부접근 불가능 => 같은 클래스 안에서만 접근할 수 있게 한다
            2. 오로지 해당 클래스 내부의 메소드만으로 접근 가능하다
            3. 상속된 하위클래스도 접근 불가능, 제일 강력한 접근 제어로 정보 은닉을 위한 장치

       public
            1. 외부접근 가능 : 모든 클래스에서 사용 가능하다
            2. 클래스 앞부분에 public을 붙이는 경우는 다른 패키지에서 사용할 수 있는 클래스로 만든다
            (단 클래스가 public이 아닌 경우는 같은 패키지에서만 접근 가능)

       protected
            1. 상속관계에 있는 자식 클래스만 쓸 수 있게 만든 것
            2. 같은 패키지의 클래스와 다른 패키지의 서브 클래스에서도 접근할 수 있게 한다
     */
    class AA
    {
        // 멤버 변수
        // 필드
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
            // new 연산자 ==> 객체를 생성하고 생성자를 호출하는 데 사용
            aa.num2 = 100;
            aa.num3 = 1000;
            // aa.num1 = 10; // 에러: private 속성이기 때문

            aa.Print();
            // aa.PrintPrivate()   // private 속성이라 에러
        }
    }
}
