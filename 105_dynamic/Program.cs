using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * dynamic 키워드
 *  - object, var
 *  - 런타임에 변수 형식 변경 가능(변수형이 결정됨)
 *  - 일반화 함수에서 변수타입 대응가능
 *  
 * default 키워드
 *  - value type: 0 초기화
 *  - reference type: null 초기화
 */
namespace _105_dynamic
{
    class Program
    {
        static T AddArray<T>(T[] arrDatas)
        {
            // T temp = 0; 에러 발생
            // object temp = 0; 박싱, 언박싱 발생
            dynamic temp = default(T);
            for(int i = 0; i < arrDatas.Length; i++)
            {
                temp += arrDatas[i];
            }
            return temp;
        }
        static T SumArray<T>(T[] arrDatas)
        {
            T temp = default(T);
            for(int i = 0; i < arrDatas.Length; i++)
            {
                temp += (dynamic)arrDatas[i];
            }
            return temp;
        }
        static void PrintArray<T>(T[] arrDatas)
        {
            foreach(var data in arrDatas)
            {
                Console.WriteLine("data: {0}", data);
            }
        }
        static void Main(string[] args)
        {
            int[] arrNums = { 1, 2, 3, 4, 5 };

            Console.WriteLine("AddArray: {0}", AddArray(arrNums));
            PrintArray(arrNums);
        }
    }
}
