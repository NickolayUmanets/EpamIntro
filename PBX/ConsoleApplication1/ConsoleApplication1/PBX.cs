using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class PBX
    {
        private class Port
        {
            private int portNumber; // to identify UT subscriber
            private string portState; // online, offline, busy
            private string portStatus; // acceptor, initiator            
        }

        private int connectionDuration; // to pass it to tarificator. must has time-related type
        private int dialDuration; // to drop dial of initiator if no answer after set value is reached . must has time-related type

        
        public delegate void Del_DialDurationCount();
        public event Del_DialDurationCount onConnect;

        public delegate void Del_ConnectClose();
        public event EventHandler onDrop;

        public void DialDurationCount()
        {
            int result;
            throw new System.NotImplementedException();
        }

        public void ConnectionlDurationCount()
        {            
            throw new System.NotImplementedException();
        }

        public void DropDial()
        {
            throw new System.NotImplementedException();
        }

        public void ConnectOpen()
        {
            portState = "busy"; // online, offline, busy
            throw new System.NotImplementedException();
        }

        public void ConnectClose()
        {
            portState = "online"; // online, offline, busy
            throw new System.NotImplementedException();
        }
    }
}
