using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026_Data_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA = "100";
            string strB = "3.141592";
            string strC = "3.141592653589793238";

            int parseA = int.Parse(strA);
            float parseB = float.Parse(strB);
            decimal parseC = decimal.Parse(strC);

            Console.WriteLine("int.Parse: {0}", parseA);
            Console.WriteLine("float.Parse: {0}", parseB);
            Console.WriteLine("decimal.Parse: {0}", parseC);
        }
    }
}
