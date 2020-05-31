using System;
using System.Collections.Generic;
using System.Text;

namespace ex_dependency_Injuection 
{
    class FBMsg : IMsg
    {
        public void SendMsg(string msg)
        {
            Console.WriteLine("Message from FB: " + msg);
        }
    }
}
