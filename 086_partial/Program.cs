using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
