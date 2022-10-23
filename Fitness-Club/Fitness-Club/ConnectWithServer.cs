using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;

namespace Fitness_Club
{
    internal class ConnectWithServer
    {

        public static int port = 13000;
        static public IPAddress hostName = IPAddress.Parse("127.0.0.1");
        public static string separationKey = "&&&";
        public static string startObjectKey = "$$$";

        public static void HelloServerFromClient()
        {
            callToServer("ServerRunning#", "TestServer#", "hello from client");

        }
        public static string callToServer(string contr, string funName, string input)
        {

            try
            {
                TcpClient client = new TcpClient(hostName.ToString(), port);
                byte[] dataSendFromClient = Encoding.ASCII.GetBytes(contr + funName + input);  //converting string to bytes
                NetworkStream stream = client.GetStream();                 //netwwork stream-class for sending data
                stream.Write(dataSendFromClient, 0, dataSendFromClient.Length);


                BinaryReader reader = new BinaryReader(client.GetStream());    //Read response from client
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

        public static List<Person> ConvartDataToListObjects(string data)
        {
            string userId, fName, lName, email, phone, dateBorn, dateRegistion;
            Image profilePic;
            bool gender, admin, isAuth, isBlocked;
            List<Person> ListOfAllPerson = new List<Person>();
            List<profilePicture> proPicList = ConnectWithServer.getListOfAllPics();
            List<string> list = new List<string>();
            list = (data.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int j = 0; j < list.Count; j++)
            {
                List<string> invidualPerson = new List<string>();
                invidualPerson = (list.ElementAt(j).Split(new string[] { ConnectWithServer.separationKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                userId = invidualPerson[0];
                profilePic = getProfilePicByUserId(userId, proPicList);
                fName = invidualPerson[1];
                lName = invidualPerson[2];
                email = invidualPerson[3];
                phone = invidualPerson[4];
                dateBorn = invidualPerson[5];
                dateRegistion = invidualPerson[6];
                gender = bool.Parse(invidualPerson[7]);
                admin = bool.Parse(invidualPerson[8]);
                isAuth = bool.Parse(invidualPerson[9]);
                isBlocked = bool.Parse(invidualPerson[invidualPerson.Count - 1]);
                Person p = new Person(userId, fName, lName, email, phone, dateBorn, dateRegistion, gender, admin, isAuth, isBlocked, profilePic);
                ListOfAllPerson.Add(p);


            }
            return ListOfAllPerson;

        }

        public static Image getProfilePicByUserId(string userId, List<profilePicture> list)
        {
            foreach (profilePicture picture in list)
            {
                if (picture.UserId == userId)
                    return picture.Img;
            }
            return Properties.Resources.defult_pro_pic2;
        }
        public static List<profilePicture> getListOfAllPics()
        {
            SqlConnection conn = new SqlConnection("Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True");
            List<profilePicture> list = new List<profilePicture>();
            try
            {
                SqlCommand cmd = new SqlCommand("select profilePic,userId from users", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    for (int i = 0; reader.Read(); i++)
                    {
                        if (!reader[0].Equals(DBNull.Value))      //HAVE PIC
                        {
                            byte[] img = (byte[])(reader[0]);
                            Image image = (Bitmap)((new ImageConverter()).ConvertFrom(img));
                            profilePicture PP = new profilePicture(image, reader[1].ToString());
                            list.Add(PP);
                        }
                        else
                        {
                            profilePicture PP = new profilePicture( reader[1].ToString());
                            list.Add(PP);
                        }
                    }                   
                }
                conn.Close();
                return list;
            }
            catch (Exception err)
            {
                return null;
            }
        }











    }
}






