﻿using System;
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
           // Console.WriteLine();
            Console.ReadKey();
        }

        //Saving all the logged to system in txt file.
        static void saveLogInTextFile(string ip, string date)
        {
            FileStream file = new FileStream("loginList.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"Logged in to the server from: {ip} in {date}.");
            writer.Close();
            file.Close();
        }

        //Found the controller and send the requset to the function.
        private static string SendingToProperControllerAndResponseData(string controller,string funName,string [] fullDataFromClientInArry)
        {
            if (controller == "login")
            {
                return conntrollerLoginActions(funName, fullDataFromClientInArry);
            }
            else if (controller == "Dashboard")
            {
                return conntrollerDashboardActions(funName, fullDataFromClientInArry);
            }
            else if (controller == "myAccount")
            {
                return conntrollermyAccountActions(funName, fullDataFromClientInArry);

            }
            return "Controller not found.";
        }

        //Find the requested function in any of the controllers.
        private static string conntrollerLoginActions(string functionName, string[] fullDataFromClientInArry)
        {
            if (functionName == "tryLogIn")
            {
                string email = fullDataFromClientInArry[2],
                password = fullDataFromClientInArry[3],
                admin = fullDataFromClientInArry[fullDataFromClientInArry.Length - 1];
                return Login.tryLogIn(email, password, admin);
            }
            else if (functionName == "fogotPassword")
            {
                return "somthing"; //RETURN Only one person
            }
            return "Function not found.";
        }
        private static string conntrollerDashboardActions(string functionName,string [] fullDataFromClientInArry)
        {
            if (functionName == "getAllDataForAdminScreenInDahsboard")
            {

                return Dashboard.getAllDataForAdminScreenInDahsboard(); //RETURN ALL DATA
            }
            else if (functionName == "getDataForOnlyThisUserId")
            {
                string userId = fullDataFromClientInArry[2];
                return  Dashboard.getDataForOnlyThisUserId(userId); //RETURN Only one person
            }
            return "Function not found.";
        }
        private static string conntrollermyAccountActions(string functionName, string[] fullDataFromClientInArry)
        {

            if (functionName == "editDetailsPersonById")
            {
                string userId = fullDataFromClientInArry[2],
                fname = fullDataFromClientInArry[3],
                lname = fullDataFromClientInArry[4],
                email = fullDataFromClientInArry[5],
                phone = fullDataFromClientInArry[6],
                dateBorn = fullDataFromClientInArry[7];
                return myAccount.editDetailsPersonById(userId, fname, lname, email, phone, dateBorn);
            }
            else if (functionName == "phoneExist")
            {
                string phone = fullDataFromClientInArry[2];
                return myAccount.phoneExist(phone);

            }
            else if (functionName == "emailExist")
            {
                string email = fullDataFromClientInArry[2];
                return myAccount.emailExist(email);

            }
            else if(functionName == "editPasswordById")
            {
                string userId = fullDataFromClientInArry[2],
                password = fullDataFromClientInArry[3],
                newPassword = fullDataFromClientInArry[4];
                return myAccount.editPasswordById(userId, password, newPassword);
            }
            else if (functionName == "GetPasswordAndLastUpdateByUserId")
            {
                string userId = fullDataFromClientInArry[2];
                return myAccount.GetPasswordAndLastUpdateByUserId(userId);
            }
            return "Function not found.";
        }
        static void openingTheServerToReceiveCalls()         //Save and print to the console the calls to the server.
        {

            try
            {
                byte[] bytes = new byte[256];
                int i, countReq=0;
                string dataOutput="" ;
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
                    dataOutput=SendingToProperControllerAndResponseData(controller, funName, fullDataFromClientInArry);
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



      

    }
}
