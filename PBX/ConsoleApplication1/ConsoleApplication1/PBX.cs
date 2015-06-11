using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class PBX
    {
        private int portNumber;
        private string portState; // online, offline, busy
        private string portStatus; // acceptor, initiator
        private int connectionDuration;
        private int dialDuration;       

        public delegate void Del_DialDurationCount();
        public event Del_DialDurationCount onConnect;

        public delegate void Del_ConnectClose();
        public event EventHandler onDrop;

        public void DialDurationCount()
        {
            int result;
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
