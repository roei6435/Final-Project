using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Data;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Server_F.C
{
    internal class Program
    {
        public static SqlConnection conn = new SqlConnection("Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True");
        public static int port = 13000;// number port
        public static IPAddress localAddress = IPAddress.Parse("127.0.0.1");
        public static TcpListener server = new TcpListener(localAddress, port);
         public static string separationKey = "&&&";
        public static string startObjectKey = "$$$";

        static void Main(string[] args)
        {
           openingTheServerToReceiveCalls();





            Console.ReadKey();
        }

        static void TestServer(string inputFromClient) => Console.WriteLine(inputFromClient);

        static void openingTheServerToReceiveCalls()         //Save and print to the console the calls to the server.
        {

            try
            {
                byte[] bytes = new byte[256];
                int i, countReq=0;
                string dataOutput ="" ;
                string fullDataFromClient = "" ;
                server.Start();
                while (true)
                {
                    
                    Console.WriteLine($"{countReq}: A server is waiting for requests.");
                    Console.WriteLine("---------------------------------------------------------------\n");
                    TcpClient client = server.AcceptTcpClient();
                    countReq++;
                    string ipClient = client.Client.RemoteEndPoint.ToString();
                    string dateCon = DateTime.Now.ToString();
                    Console.WriteLine($"New call to server from: {ipClient} in {dateCon}, numbur requset:{countReq}");
                    saveLogInTextFile(ipClient, dateCon);
                    // resev from client
                    NetworkStream stream = client.GetStream();// input data
                    i = stream.Read(bytes, 0, bytes.Length);  //number bytes
                    fullDataFromClient = Encoding.ASCII.GetString(bytes, 0, i); // convert data to string
                    string[] fullDataFromClientInArry = fullDataFromClient.Split('#');
                    string controller = fullDataFromClientInArry[0];
                    string funName=fullDataFromClientInArry[1];
                    Console.WriteLine($"Request from client: go to controller: {controller}, function: {funName}. ");
                    // send data
                    if (controller == "ServerRunning")
                    {

                        Program.TestServer(fullDataFromClientInArry[fullDataFromClientInArry.Length - 1]);
                    }
                    else if (controller == "login")
                    {

                        string email = fullDataFromClientInArry[2],
                            password = fullDataFromClientInArry[3],
                            admin = fullDataFromClientInArry[fullDataFromClientInArry.Length - 1];
                        dataOutput = Login.loginSuccsfully(email, password, admin);
                    }
                    else if (controller == "Dashboard")
                    {
                        if (funName == "getAllDataForAdminScreenInDahsboard")
                        {

                             dataOutput = Dashboard.getAllDataForAdminScreenInDahsboard(); //RETURN ALL DATA
                        }
                    }
                    else
                    {
                        dataOutput = "sabba";
                    }

                    BinaryWriter writer = new BinaryWriter(client.GetStream());
                    writer.Write(dataOutput);
                    client.Close();
                    Console.WriteLine($"Request number {countReq} has ended");
                    Console.WriteLine("---------------------------------------------------------------");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                
            }

        }


        public static string convartDictionaryToString(Dictionary<string, string> dic)
        {
            string response = null;
            foreach (KeyValuePair<string,string> i in dic)
                response += i.Key + separationKey + i.Value + separationKey; 
            return response;
        }
        
        public static Dictionary<string,string> convartStringToDictionary(string fullString)
        {
            string[] fullStringInArray = fullString.Split(new string[] { separationKey }, StringSplitOptions.None);
            Dictionary<string, string> dicResponse = new Dictionary<string, string>();
            for(int i = 0; i<fullString.Length; i=i+2)
              dicResponse.Add(fullStringInArray[i] + ':', fullStringInArray[i + 1]);
            return dicResponse; 
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
