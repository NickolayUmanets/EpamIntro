using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class DialToAcceptorEventArgs : EventArgs
    {
        public int acceptorPhoneNumber;

        public DialToAcceptorEventArgs(int phoneNUm)
        {
            acceptorPhoneNumber = phoneNUm;
        }
    }
}
