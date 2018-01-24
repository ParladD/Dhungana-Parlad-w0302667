using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ChatLib
{
    public class Server : Connection
    {
        public override void ConnetionType(string ip, int port)
        {
            //


            TcpListener server = null;

            try
            {
                // Set the TcpListener on port 13000.
                //  Int32 port = 13000;
                IPAddress localAddr = IPAddress.Parse(ip);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(localAddr, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                String data = null;

                // Enter the listening loop.
                while (true)
                {

                    TcpClient client = server.AcceptTcpClient();
                    ReadAndWrite(bytes, data, client);
                }



            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Stop listening for new clients.
                server.Stop();
            }

        }

        public void ReadAndWrite(Byte[] bytes, string data, TcpClient client)
        {
            // Get a stream object for reading and writing

            NetworkStream stream = client.GetStream();
            int i;

            // Loop to receive all the data sent by the client.
            while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
            {
                // Translate data bytes to a ASCII string.
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);



                byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                // Send back a response.
                stream.Write(msg, 0, msg.Length);

            }
             
            // Shutdown and end connection
            client.Close();
        }
    }//end server



}//end chatlib
