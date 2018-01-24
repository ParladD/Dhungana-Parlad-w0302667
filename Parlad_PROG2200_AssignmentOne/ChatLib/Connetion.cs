using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ChatLib
{
    public abstract class Connection
    {

        string msg;
        string readKey;

        public abstract void ConnetionType(string ip, Int32 port);

      



    }//end read and write

       

     
}
