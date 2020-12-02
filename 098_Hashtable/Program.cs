using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
/*
 * Hashtable
 *  - 키와 값이 쌍으로 구성되는 데이터
 *  - 탐색 속도가 빠르고 사용이 편리
 */
namespace _098_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("pos", 10);
            hashTable.Add("name", "Jack");
            hashTable["weight"] = 10.8f;

            foreach (object key in hashTable.Keys)
                Console.WriteLine("key: {0}, data: {1}", key, hashTable[key]);

            Console.WriteLine();

            Hashtable hashTableCopy = new Hashtable()
            {
                ["pos"] = 10,
                ["name"] = "Jane",
                ["weight"] = 100.8f
            };

            foreach (object key in hashTableCopy.Keys)
                Console.WriteLine("key: {0}, data: {1}", key, hashTableCopy[key]);
        }
    }
}
