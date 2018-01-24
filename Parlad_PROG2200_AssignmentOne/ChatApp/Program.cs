using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChatLib;

namespace ChatApp
{
    class Program
    {
        private static string msg;

        //server and client mode
        static Server server = new Server();
        static Client client = new Client();

        static void Main(string[] args)
        {
           
            //checking for the types of mode

            if (args.Contains("-server")){
                Console.WriteLine("Server is listening");
                server.ConnetionType("127.0.0.1", 13000);
            }
            else
            {
                MsgReadAndWrite();
                client.ConnetionType(msg, 13000);


            }

            Console.ReadKey();
        }


        public static void MsgReadAndWrite()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();

                    if(pressedKey.Key == ConsoleKey.I)
                    {
                        
                        Console.WriteLine("");
                        Console.Write("Type your Your Message here: ");
                        msg = Console.ReadLine(); //BLOCKING CALL
                        //client.ConnetionType("127.0.0.1", 15000);
                        Console.WriteLine("Your Msg was: {0}", msg);

                    }

                }
                else
                {

                    Console.WriteLine("Checking for messages");
                    Thread.Sleep(300);


                }
            }
        }


    }//end program
}
