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
using System.Globalization;
using System.Text.RegularExpressions;

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

        static void openingTheServerToReceiveCalls()       //The central function receives requests and handles them.
        {

            try
            {
                byte[] bytes = new byte[1640];
                int i, countReq = 0;
                string dataOutput = "";
                string fullDataFromClient = "";
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
                    string funName = fullDataFromClientInArry[1];
                    Console.WriteLine($"Request from client: go to controller: {controller}, function: {funName}. ");
                    // send data
                    dataOutput = SendingToProperControllerAndResponseData(controller, funName, fullDataFromClientInArry);
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

        static void Main(string[] args)
        {
            //  MengementClasses.getAllReviewsByIdClass("3");
            openingTheServerToReceiveCalls();
          
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

        public static string uppercaseFirstLetter(string str)
        {
           str= str.ToLower();
           return char.ToUpper(str[0]) + str.Substring(1);
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
            else if(controller == "Calandar")
            {
                return conntrollerCalandarActions(funName, fullDataFromClientInArry);
            }
            else if(controller == "MengementUsers")
            {
                return conntrollerMengementUsersActions(funName, fullDataFromClientInArry);
            }
            else if(controller== "MengementClasses")
            {
                return conntrollerMengementClassesActions(funName, fullDataFromClientInArry);
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
            else if(functionName == "updateLastConn")
            {
                string userId=fullDataFromClientInArry[2];
                return Login.updateLastConn(userId);
            }
            else if (functionName == "registerToSystem")
            {
                string fname = fullDataFromClientInArry[2],
                lname = fullDataFromClientInArry[3],
                email = fullDataFromClientInArry[4],
                phone = fullDataFromClientInArry[5],
                dateBorn = fullDataFromClientInArry[6],
                gender = fullDataFromClientInArry[7],
                isAdmin = fullDataFromClientInArry[8];
                return Login.registerToSystem(fname, lname, email, phone, dateBorn, gender, isAdmin);
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
                string userId = fullDataFromClientInArry[2],
                phone = fullDataFromClientInArry[3];
                return myAccount.phoneExist(userId, phone);

            }
            else if (functionName == "emailExist")
            {
                string userId = fullDataFromClientInArry[2],
                    email= fullDataFromClientInArry[3];
                return myAccount.emailExist(userId,email);

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
        private static string conntrollerCalandarActions(string functionName, string[] fullDataFromClientInArry)
        {
            string userId = fullDataFromClientInArry[2];
            if (functionName == "countUserEventsInDay")
            {
                string date = fullDataFromClientInArry[3];
                return Calandar.countUserEventsInDay(userId, date);

            }
            else if (functionName == "insertNewEvent")
            {
                string eventName = fullDataFromClientInArry[3],
                    date = fullDataFromClientInArry[4],
                    from = fullDataFromClientInArry[5],
                    to = fullDataFromClientInArry[6],
                    location = fullDataFromClientInArry[7];
                return Calandar.insertNewEvent(userId, eventName, date, from, to, location);
            }
            else if (functionName == "allEventsForThisDay") 
            {
                string  date = fullDataFromClientInArry[3];
                return Calandar.allEventsForThisDay(userId, date);
            }
            else if(functionName == "deleteEventByEventId")
            {
                string eventId=fullDataFromClientInArry[3];
                return Calandar.deleteEventByEventId(userId, eventId);  
            }
            return "Function not found.";
        }

        private static string conntrollerMengementUsersActions(string functionName, string[] fullDataFromClientInArry)
        {
            string userId = fullDataFromClientInArry[2];
            if (functionName == "blockOrUnblockUser")
            {
                string blocked = fullDataFromClientInArry[3];
                return MengementUsers.blockOrUnblockUser(userId, blocked);

            }
            else if (functionName == "meso")
            {
                return "klom";
            }
            return "Function not found.";
        }

        private static string conntrollerMengementClassesActions(string functionName, string[] fullDataFromClientInArry)
        {
            if (functionName == "getAllDataClasses")
            {

                return MengementClasses.getAllDataClasses(); //RETURN ALL DATA
            }
            else if (functionName == "getPersonIdArrayByClassId")
            {
                string classId = fullDataFromClientInArry[2];
                return MengementClasses.getPersonIdArrayByClassId(classId);
            }
            else if(functionName == "editDatilsClass")
            {
                string classId = fullDataFromClientInArry[2],
                    name = fullDataFromClientInArry[3],
                    pos = fullDataFromClientInArry[4],
                    activity = fullDataFromClientInArry[5],
                    about = fullDataFromClientInArry[6];
                return MengementClasses.editDatilsClass(classId,name,pos,activity,about);
            }
            else if(functionName== "getAllReviewsByIdClass")
            {
                string classId=fullDataFromClientInArry[2]; 
                return MengementClasses.getAllReviewsByIdClass(classId);
            }
            else if(functionName== "deleteReviewById")
            {
                string reviewId=fullDataFromClientInArry[2];
                return MengementClasses.deleteReviewById(reviewId);
            }
            return "Function not found.";
        }



    }
}
