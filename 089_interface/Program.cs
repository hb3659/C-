using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * interface == 이름만 있는 메소드(프로퍼티 포함)를 모아 놓은 것
 * Abstract Base 클래스와 유사한 기능을 하지만 다중 상속이 가능하다
 */
namespace _089_interface
{
    interface IAA
    {
        // public int a;        // 에러 (필드 불가)
        // private void IPrint();   // 에러 (private)
        // public void IPrint();    // 에러 (public)
        int A { get; set; }     // 프로퍼티
        void IAAPrint();
    }
    interface IBB
    {
        void IBBPrint();
    }
    class Super
    {
        protected int num;
        public virtual void Print()
        {
            Console.WriteLine("-------------------------------------");
        }
    }
    class AA : IAA
    {
        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA의 IAAPrint() 재정의");
        }
    }
    class BB : IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }
        public void IAAPrint()
        {
            Console.WriteLine("class BB interface IAA의 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB의 IBBPrint() 재정의");
        }
    }
    class CC: Super, IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("class Super => Print() 재정의");
        }
        public void IAAPrint()
        {
            Console.WriteLine("class CC => interface IAA의 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {
            Console.WriteLine("class CC => interface IBB의 IBBPrint() 재정의");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            aa.IAAPrint();

            BB bb = new BB();
            bb.IAAPrint();
            bb.IBBPrint();

            IAA iaa = new AA();     // 참조 가능 (인스턴스 생성 불가능)
            iaa.IAAPrint();

            IBB ibb = bb as IBB;
            ibb.IBBPrint();

            CC cc = new CC();
            cc.Print();
            cc.IAAPrint();
            cc.IBBPrint();

            Super sCC = cc as Super;
            sCC.Print();

            IAA IAAcc = cc as IAA;
            IAAcc.IAAPrint();

            IBB IBBcc = cc as IBB;
            IBBcc.IBBPrint();
        }
    }
}
