using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_Data_cast
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            double dNum = (double)num;
            Console.WriteLine("num: {0}, dNum: {1}", num, dNum);

            double dnum2 = 123456789123;
            int num2 = (int)dnum2;  // ==> 데이터 왜곡 발생!!
            Console.WriteLine("dnum2: {0}, num2: {1}", dnum2, num2);
        }
    }
}
