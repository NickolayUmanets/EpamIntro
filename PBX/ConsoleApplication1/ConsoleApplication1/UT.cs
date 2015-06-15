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

        public void Wait()
        {
            PBX.Port.PortState = "online";
            throw new System.NotImplementedException();
        }

        public void Dial()
        {
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
