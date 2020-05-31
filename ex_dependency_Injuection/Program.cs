using System;

namespace ex_dependency_Injuection
{
    class Program
    {
        static void Main(string[] args)
        {
            User A = new User();
            A.Send(new FBMsg(), "guten nacht!");
            A.Send(new LineMsg(), "guten nacht!");


        }
    }
}
