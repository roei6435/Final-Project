using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Fitness_Club
{
    internal class ConnectWithServer
    {

        public static int port = 13000;
        static public IPAddress hostName = IPAddress.Parse("127.0.0.1");
        public static string separationKey = "&&&";
        public static string startObjectKey = "$$$";
        public static string callToServer(string contr, string funName, string input)
        {



            try
            {
                TcpClient client = new TcpClient(hostName.ToString(), port);
                byte[] dataSendFromClient = Encoding.ASCII.GetBytes(contr + funName + input);  //converting string to bytes
                NetworkStream stream = client.GetStream();                 //netwwork stream-class for sending data
                stream.Write(dataSendFromClient, 0, dataSendFromClient.Length);


                BinaryReader reader = new BinaryReader(client.GetStream()); //Read the response from server.
                string responseFromSerever = reader.ReadString();
                stream.Close();
                client.Close();
                return responseFromSerever;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static void HelloServerFromClient()
        {
            callToServer("ServerRunning#", "TestServer#", "hello from client");

        }



    }
}






