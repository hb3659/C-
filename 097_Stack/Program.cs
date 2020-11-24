using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 * Stack
 *  - 순차적 데이터 처리
 *  - LIFO(Last In First Out)
 *  - 뒤로 가기 기능 구현
 *  - Push(), Pop(), Peek()
 */
namespace _097_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            for (int i = 0; i < 10; i++)
                stack.Push(i);

            Console.WriteLine("stack data: {0}", stack.Peek());
            while (stack.Count > 0)
                Console.WriteLine("stack data: {0}, count: {1}", stack.Pop(), stack.Count);

            // 배열데이터 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Stack stackCopy = new Stack(arrData);

            foreach (object data in stackCopy)
                Console.WriteLine("stackCopy data: " + data);
        }
    }
}
