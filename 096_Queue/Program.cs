using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 * Queue
 *  - 순차적 데이터 처리
 *  - FIFO(First In First Out)
 *  - 게임에서 순차적 AI기능 구현
 *  - Dequeue(), Enqueue(), Peek()
 */
namespace _096_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            for (int i = 0; i < 10; i++)
                queue.Enqueue(i);

            Console.WriteLine("queue data: {0}", queue.Peek());

            while (queue.Count > 0)
                Console.WriteLine("queue data: {0}, count: {1}",
                    queue.Dequeue(), queue.Count);

            // 배열데이터로 초기화
            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Queue queueCopy = new Queue(arrData);

            foreach(object data in queueCopy)
            {
                Console.WriteLine("queueCopy data: " + data);
            }
        }
    }
}
