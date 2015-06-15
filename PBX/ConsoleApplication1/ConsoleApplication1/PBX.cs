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
            private int initiatorPortNR;
            private int acceptorPortNR;
            private string portState = "online"; // online, offline, busy
            private string portStatus = "undetermined"; // acceptor, initiator, undetermined

            private static void CreateTimeSpan(int hours, int minutes, int seconds)
            {
                TimeSpan connectionDuration = new TimeSpan(hours, minutes, seconds);
                TimeSpan connectionDurationLimit = new TimeSpan(0, 0, 25);
                TimeSpan dialDuration = new TimeSpan(hours, minutes, seconds);
                TimeSpan dialDurationLimit = new TimeSpan(0, 0, 10);
            }

        }

        private int connectionDuration; // to pass it to tarificator. must has time-related type
        private int dialDuration; // to drop dial of initiator if no answer after set value is reached . must has time-related type

        

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
