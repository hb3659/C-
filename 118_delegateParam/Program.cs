using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118_delegateParam
{
    delegate void delegateFunc();
    class MessageProcess
    {
        delegateFunc CallOKFunc;
        delegateFunc CallCancleFunc;
        public void Message(string msg, delegateFunc okFunc, delegateFunc cancleFunc)
        {
            CallOKFunc = okFunc;
            CallCancleFunc = cancleFunc;

            Console.WriteLine("Message: " + msg + " (0: ok, 1: cancle)");

            string inputStr = Console.ReadLine();

            if (inputStr.Equals("0"))
            {
                CallOKFunc();
            }
            else
            {
                CallCancleFunc();
            }
        }
    }
    class Program
    {
        static void CallOK()
        {
            Console.WriteLine("CallOK");
        }
        static void CallCancle()
        {
            Console.WriteLine("CallCancle");
        }
        static void Main(string[] args)
        {
            MessageProcess msg = new MessageProcess();
            msg.Message("Test Message", CallOK, CallCancle);

            msg.Message("Test Message",
                delegate ()
                {
                    Console.WriteLine("Call InDelegate");
                }, CallCancle);
        }
    }
}
