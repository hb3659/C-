using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  where
 */
namespace _106_where
{
    class REF
    {

    }
    class AA<T> where T : struct    // 값형식으로 제한
    {
        private T sData;
        public AA()
        {
            sData = default(T);
        }
        public void Print()
        {
            Console.WriteLine("" + sData);
        }
    }
    class BB<T> where T : class     // 참조 형식으로 제한
    {
        private T sRefData;
        public BB()
        {
            sRefData = default(T);
        }
        public void Print()
        {
            if (sRefData == null) Console.WriteLine("Null sRefData");
            else Console.WriteLine("sData: " + sRefData);
        }
    }
    interface II
    {
        void IIPrint();
    }
    class CC<T> where T : II
    {
        public T _interface;
    }
    class DD : II
    {
        public void IIPrint()
        {
            Console.WriteLine("DDbase: ");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // AA<REF> bb = new AA<REF>();
            // -> 오류: null 허용되지않는 vaule type
            AA<int> aa = new AA<int>();
            aa.Print();

            // BB<int> bb = new BB<int();
            // -> dhfb: 참조 형식이 아니므로
            BB<REF> bb = new BB<REF>();
            bb.Print();

            CC<II> cc = new CC<II>();
            // cc._interface = new REF();
            // -> 오류: 한정자가 interface
            cc._interface = new DD();
            cc._interface.IIPrint();
        }
    }
}
