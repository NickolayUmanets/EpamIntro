using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class PBX
    {
        private int portNumber;
        private int portState;
        private int portStatus;
        private int connectionDuration;
        private int dialDuration;

        public event EventHandler OnConnect;

        public event EventHandler OnDrop;

        public void DialDurationCount()
        {
            throw new System.NotImplementedException();
        }

        public void DropDial()
        {
            throw new System.NotImplementedException();
        }

        public void Connect()
        {
            throw new System.NotImplementedException();
        }
    }
}
