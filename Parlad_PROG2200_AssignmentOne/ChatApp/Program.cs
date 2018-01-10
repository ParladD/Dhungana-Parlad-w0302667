using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatLib;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //checking for the types of mode

            if (args.Contains("-server")){

                //server mode
                Server server = new Server();
            }
            else
            {
                //client mode
                Client client = new Client();
            }

        }


    }//end program
}
