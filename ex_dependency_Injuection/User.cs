using System;
using System.Collections.Generic;
using System.Text;

namespace ex_dependency_Injuection
{
    class User 
    {
        public void Send(IMsg msgSvc, string msg)
        {
            msgSvc.SendMsg(msg);
        }
    }
}
