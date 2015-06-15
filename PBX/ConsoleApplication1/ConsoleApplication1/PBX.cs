using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace ConsoleApplication1
{
    public class PBX
    {
        internal class Port
        {
            private int portNumber; // to identify UT subscriber
            private int initiatorPortNR;
            private int acceptorPortNR;
            private static string portState = "online"; // online, offline, busy
            private static string portStatus = "undetermined"; // acceptor, initiator, undetermined
            private System.Timers.Timer dialDurationTimer = new System.Timers.Timer(10000);
            
            public static int PortNR { get; set; }
            public static int InitiatorPortNR { get; set; }
            public static int AcceptorPortNR { get; set; }
            public static string PortState { get; set; }
            public static string PortStatus { get; set; }

            
            private TimeSpan connectionDuration; // to pass it to tarificator. must has time-related type
            private TimeSpan connectionDurationLimit; // = new TimeSpan(0, 0, 25);
            private TimeSpan dialDuration; // = new TimeSpan(int hours, int minutes, int seconds);
            private TimeSpan dialDurationLimit; // = new TimeSpan(0, 0, 10); // to drop dial of initiator if no answer after set value is reached . must has time-related type
            

            public Port()
            {
                PortNR = 0;
                InitiatorPortNR = 0;
                AcceptorPortNR = 0;
                PortState = "online";
                PortStatus = "undetermined";
                connectionDurationLimit = new TimeSpan(0, 0, 25);
                dialDurationLimit = new TimeSpan(0, 0, 10);
            }

            dial
            private void OnDialDurationTimeOut(object sender, System.Timers.ElapsedEventArgs e)
            {
                
            }
        }

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
            if ()
            {
                
            }
            throw new System.NotImplementedException();
        }

        public void ConnectOpen()
        {
            throw new System.NotImplementedException();
        }

        public void ConnectClose()
        {
            throw new System.NotImplementedException();
        }
    }
}
