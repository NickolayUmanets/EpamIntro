﻿using System;
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

            public int PortNR { get; set; }
            public int InitiatorPortNR { get; set; }
            public int AcceptorPortNR { get; set; }
            public string PortState { get; set; }
            public string PortStatus { get; set; }

            
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
