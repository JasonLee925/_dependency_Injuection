using System;
using System.Collections.Generic;
using System.Text;

namespace ex_dependency_Injuection
{
    class LineMsg : IMsg
    {
        public void SendMsg(string msg)
        {
            Console.WriteLine("Message from Line: " + msg);
        }
    }
}
