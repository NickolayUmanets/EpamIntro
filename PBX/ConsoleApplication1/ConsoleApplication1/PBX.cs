using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;
using System.Runtime.CompilerServices;

namespace ConsoleApplication1
{
    public class PBX
    {
        internal class Port : INotifyPropertyChanged
        {
            public enum PortStates
            {
                Offline,
                Online,
                Busy,
                Undetermined,
                Acceptor,
                Initiator
            }

            private PortStates _portState;
            private int portNumber; // to identify UT subscriber
            private int initiatorPortNR;
            private int acceptorPortNR;
            private static string portStatus = "undetermined"; // acceptor, initiator, undetermined
            private System.Timers.Timer dialDurationTimer = new System.Timers.Timer(10000);
            
            public static int PortNR { get; set; }
            public static int InitiatorPortNR { get; set; }
            public static int AcceptorPortNR { get; set; }

            public PortStates PortState
            {
                get { return _portState; }
                set
                {
                    if (this._portState != value)
                    {
                        this._portState = value;
                        NotifyPropertyChanged();
                    }
                }
            }
            public static string PortStatus { get; set; }

            
            private TimeSpan connectionDuration; // to pass it to tarificator. must has time-related type
            private TimeSpan connectionDurationLimit; // = new TimeSpan(0, 0, 25);
            private TimeSpan dialDuration; // = new TimeSpan(int hours, int minutes, int seconds);
            private TimeSpan dialDurationLimit; // = new TimeSpan(0, 0, 10); // to drop dial of initiator if no answer after set value is reached . must has time-related type

            public event PropertyChangedEventHandler PropertyChanged;

            public void OnDialToAcceptor(object sender, DialToAcceptorEventArgs e)
            {
                
            }

            public Port()
            {
                PortNR = 0;
                InitiatorPortNR = 0;
                AcceptorPortNR = 0;
                PortState = PortStates.Online;
                PortStatus = "undetermined";
                connectionDurationLimit = new TimeSpan(0, 0, 25);
                dialDurationLimit = new TimeSpan(0, 0, 10);


                dialDurationTimer.Elapsed += OnDialDurationTimeOut;
            }

            private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }            

            private void OnDialDurationTimeOut(object sender, System.Timers.ElapsedEventArgs e)
            {
                    
            }

            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {

            }

        }

        private int portQantity = 3;
        private Dictionary<int, Port> Ports = new Dictionary<int, Port>(); //Dictionary for getting port based on phoneNumber
        private Dictionary<Port, int> PhoneNumbers = new Dictionary<Port, int>(); // Dictionary fpr getting phoneNUmber based on port


        public PBX()
        {
            for (int i = 1; i < portQantity; i++)
            {
                Port port = new Port();
                port.PropertyChanged += this.OnPortStateChanged;
                Ports.Add(25678+i, port);
                PhoneNumbers.Add(port, 25678 + i);

            }
        }

        public void OnPortStateChanged(object sender, PropertyChangedEventArgs e)
        {
            Port senderPort = sender as Port;
            if (senderPort.PortState == Port.PortStates.Initiator)
            {
                Port prt;
                Ports.TryGetValue(senderPort.)
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
