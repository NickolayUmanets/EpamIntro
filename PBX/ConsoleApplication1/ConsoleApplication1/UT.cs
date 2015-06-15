using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class UT
    {
        private string subscriberName;
        private int subscriberNR;
        private int dialNR;
        private int incomingNR;

        public string SubscriberName { get; set; }
        public int SubscriberNR { get; set; }
        public int DialNR { get; set; }
        public int IncomingNR { get; set; }

        public event EventHandler<DialToAcceptorEventArgs> DialToAcceptor;

        public void Wait()
        {
            PBX.Port.PortState = "online";
            PBX.Port.PortStatus = "undetermined";
            DialNR = 0;
            IncomingNR = 0;
        }

        public void Dial(int numberToDial)
        {
            DialNR = numberToDial;
            PBX.Port.InitiatorPortNR = subscriberNR;
            if (DialToAcceptor!=null)
                DialToAcceptor(this, new DialToAcceptorEventArgs(numberToDial));

            throw new System.NotImplementedException();
        }

        public void Notify()
        {
            throw new System.NotImplementedException();
        }

        public void Answer()
        {            
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Subscribe()
        {
            throw new System.NotImplementedException();
        }
    }
}
