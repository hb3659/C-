using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _112_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNum = 10;

            try
            {
                checked
                {
                    maxNum += Int32.MaxValue;
                }
                // 확인만 하는것이라 실제 값이 적용X
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("e.Source: " + e.Source);
            }
            catch(Exception e)
            {
                Console.WriteLine("e.Message: " + e.Message);
            }

            Console.WriteLine("maxNum: " + maxNum);
        }
    }
}
