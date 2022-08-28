using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;
using System.Data.SqlClient;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Data;

namespace Server_F.C
{
    internal class Program
    {
        public static int port = 13000;// number port
        public static IPAddress localAddress = IPAddress.Parse("127.0.0.1");
        public static TcpListener server = new TcpListener(localAddress, port);

        static void Main(string[] args)
        {
            FirstConnectWithClient();
        }

        static string TestServer() => "The test was successful";

        static void FirstConnectWithClient()         //Save and print to the console the calls to the server.
        {

            try
            {
                byte[] bytes = new byte[256];
                int i;
                string fullDataFromClient = null, dataOutput = null;
                server.Start();
                while (true)
                {

                    Console.WriteLine("Waiting ... ");
                    TcpClient client = server.AcceptTcpClient();
                    string ipClient = client.Client.RemoteEndPoint.ToString();
                    string dateCon = DateTime.Now.ToString();
                    Console.WriteLine($"New call to Server from: {ipClient} in {dateCon}.");
                    saveLogInTextFile(ipClient, dateCon);
                    // resev from client
                    NetworkStream stream = client.GetStream();// input data
                    i = stream.Read(bytes, 0, bytes.Length);  //number bytes
                    fullDataFromClient = Encoding.ASCII.GetString(bytes, 0, i); // convert data to string
                    string[] fullDataFromClientInArry = fullDataFromClient.Split('#');
                    Console.WriteLine();
                    string controller = fullDataFromClientInArry[0];
                    string funName=fullDataFromClientInArry[1];
                    Console.WriteLine($"A new request from client function {funName} from countroller {controller}");
                    // send data
                    if(controller== "ServerRunning")
                    {
                        dataOutput = Program.TestServer();
                    }
                    else if (controller == "login")
                    {
                        string email = fullDataFromClientInArry[2],
                            password = fullDataFromClientInArry[3],
                            admin = fullDataFromClientInArry[fullDataFromClientInArry.Length - 1];
                        dataOutput = Login.loginSuccsfully(email, password, admin);
                    }
                    else
                    {
                        dataOutput = "sabba";
                    }
                    byte[] msg = Encoding.ASCII.GetBytes(dataOutput);
                    stream.Write(msg, 0, msg.Length); // send to client
                    client.Close();
                    Console.WriteLine("Call is fhinish");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        static void saveLogInTextFile(string ip, string date)
        {
            FileStream file = new FileStream("loginList.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"Logged in to the server from: {ip} in {date}.");
            writer.Close();
            file.Close();
        }
    }
}
