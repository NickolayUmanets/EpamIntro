using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBX_test
{
    public class PBX
    {
        public event EventHandler<PbxEventArgs> onSend;

        public void SendSingnal()
        {
            if (onSend != null)
                onSend(this, new PbxEventArgs("This is signal!", "This is message!"));
        }
    }

    public class PbxEventArgs : EventArgs
    {
        public string Signal { get; set; }
        public string Message { get; set; }

        public PbxEventArgs(string signal, string message)
        {
            Signal = signal;
            Message = message;
        }
    }

    public class TerminalUser
    {
        public void GetSignal(object obj, PbxEventArgs args)
        {
            Console.WriteLine(string.Format("This is one {0}, {1}", args.Message, args.Signal));
        }

        public void GetSignal1(object obj, PbxEventArgs args)
        {
            Console.WriteLine(string.Format("This is two {0}, {1}", args.Message, args.Signal));
        }


    }

    class Program
    {

        static void Main(string[] args)
        {
            PBX pbx = new PBX();

            TerminalUser t1 = new TerminalUser();
            TerminalUser t2 = new TerminalUser();
            pbx.onSend += t1.GetSignal;
            pbx.onSend += t2.GetSignal1;

            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                pbx.SendSingnal();
            }
            pbx.SendSingnal();
            Console.Read();

        }
    }
}
