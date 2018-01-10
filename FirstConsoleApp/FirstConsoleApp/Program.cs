using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Contains("-server"))
            {

                Console.WriteLine("Runnig as server...");
            }
            else
            {
                Program.PressedKey();
            }

            Console.ReadKey(); // waiting for input for any key, keeps the console open

        }

        public static void PressedKey()
        { 
            while(true)
            {

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();

                    if (pressedKey.Key == ConsoleKey.I)
                    {
                        Console.WriteLine("");
                        Console.Write("Type your Your Message here: ");
                        string msg = Console.ReadLine(); //BLOCKING CALL

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
    }
}
