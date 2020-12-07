using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 델리게이트(delegate)
 *  - 대리자(메소드 참조형)
 *  - 메소드의 틀을 만들어 소통
 *  - 클래스간 통신에 활용
 *  - delegate 리턴형 식별자(파라미터);
 */
namespace _116_delegate
{
    delegate int DelegateFunc(int a);
    class Program
    {
        static int Add(int a)
        {
            Console.WriteLine("Add");
            return a + a;
        }
        static void Main(string[] args)
        {
            DelegateFunc delegateFunc = Add;        // delegateFunc(Add)
            Console.WriteLine("delegateFunc: " + delegateFunc(10));
        }
    }
}
