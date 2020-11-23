using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  하나의 클래스를 여러개의 파일로 분할해주는 기능
 *  컴파일 시 하나의 클래스로 인식한다.
 *  
 *  - 특정한 하나의 클래스가 여러 용도로 사용하고 클래스로
 *    분할하기 어려울 때 partial 클래스를 사용하면 하나의
 *    클래스지만 여러개의 파일로 분할해서 보기가 편하다.
 *  
 *  - c++을 주로 사용할 경우 cpp, h 파일과 클래스명을
 *    동일하게 사용한다. 이 클래스는 파일 이름과 실제
 *    사용하는 클래스의 명이 다르게 설정하므로 이것을 
 *    처음 사용하는 사람이라면 이게 무슨 용도인지
 *    헷갈릴 수 있다.
 */
namespace _086_partial
{
    partial class AA
    {
        int num;
        public AA()
        {
            num = 0;
        }
        public void SetNum(int num){
            this.num = num;
        }
        public void ADD()
        {
            Console.WriteLine("{0} + {1} = {2}", num, num, (num + num));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
