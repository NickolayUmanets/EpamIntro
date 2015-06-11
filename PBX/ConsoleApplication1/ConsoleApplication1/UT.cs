using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class UT
    {
        private string name;
        private int number;

        public void Wait()
        {
            throw new System.NotImplementedException();
        }

        public void Dial()
        {
            throw new System.NotImplementedException();
        }

        public void Ring()
        {
            throw new System.NotImplementedException();
        }

        public void Answer()
        {            
            throw new System.NotImplementedException();
            PBX.onConnect();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
            PBX.onDrop();
        }

        public void Subscribe()
        {
            throw new System.NotImplementedException();
        }
    }
}
