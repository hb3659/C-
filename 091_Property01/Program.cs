using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Property : private 멤버 변수에 접근하기 위한 방법을 제공
 * set: 멤버변수에 값을 할당 (set 을 구현하지 않으면 readonly 와 같은 읽기 전용)
 * get: 멤버변수 값을 반환 (return)
 */
namespace _091_Property01
{
    class AA
    {
        private int num;
        public int NUM
        {
            get { return num; }
            set { num = value;}     // set 부분을 구현하지 않으면 readonly 와 같은 읽기 전용
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            // aa.num = 100;        // 에러 (정보은닉)
            aa.NUM = 100;       // set

            Console.WriteLine("aa.NUM: {0}", aa.NUM);       // get
        }
    }
}
