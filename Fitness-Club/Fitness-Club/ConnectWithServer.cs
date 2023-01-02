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
        public static string controller = "dataOperation#";

        //main connact with server
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




        //conavartd data. 

        public static List<Person> ConvartDataToListOfPersons(string data)
        {
            string userId, fName, lName, email, phone, dateBorn, dateRegistion,lastConn;
            Image profilePic;
            bool gender, admin, isAuth, isBlocked;
            List<Person> ListOfAllPerson = new List<Person>();
            List<profilePicture> proPicList = ConnectWithServer.getListOfAllPics("select profilePic,userId from users");
            List<string> list = new List<string>();
            list = (data.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int j = 0; j < list.Count; j++)
            {
                List<string> invidualPerson = new List<string>();
                invidualPerson = (list.ElementAt(j).Split(new string[] { ConnectWithServer.separationKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                userId = invidualPerson[0];
                profilePic = getPicById(userId, proPicList);
                fName = invidualPerson[1];
                lName = invidualPerson[2];
                email = invidualPerson[3];
                phone = invidualPerson[4];
                dateBorn = invidualPerson[5];
                dateRegistion = invidualPerson[6];
                lastConn= invidualPerson[7];
                gender = bool.Parse(invidualPerson[8]);
                admin = bool.Parse(invidualPerson[9]);
                isAuth = bool.Parse(invidualPerson[10]);
                isBlocked = bool.Parse(invidualPerson[invidualPerson.Count - 1]);
                Person p = new Person(userId, fName, lName, email, phone, dateBorn, dateRegistion, gender, admin, isAuth, isBlocked, profilePic, lastConn);
                ListOfAllPerson.Add(p);


            }
            return ListOfAllPerson;

        }

        public static List<EventCalandarcs> ConvartDataToListOfEvent(string data)
        {
            string eventId,eventName, date, fromHour, toHour, location;
            List <EventCalandarcs> ListOfAllEvents = new List<EventCalandarcs> ();
            List<string> list = new List<string>();
            list = (data.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int j = 0; j < list.Count; j++)
            {
                List<string> invidualEvent = new List<string>();
                invidualEvent = (list.ElementAt(j).Split(new string[] { ConnectWithServer.separationKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                eventId = invidualEvent[0];
                eventName = invidualEvent[1];
                date = invidualEvent[2];
                fromHour = invidualEvent[3];
                toHour = invidualEvent[4];
                location = invidualEvent[invidualEvent.Count - 1];
                EventCalandarcs newEvent=new EventCalandarcs(eventId, eventName, date, fromHour, toHour,location);
                ListOfAllEvents.Add(newEvent);


            }
            return ListOfAllEvents;
        }

        public static List<Classes> ConvartDataToListOfClasses(string data,List<Person>listP)
        {
            string classId, nameClass, place,activity,about;
            Image pic;
            Person [] personRegistedThisClass; Reviews[] reviewsArrayForThisClass;
          
            List<Classes> ListOfAllClasses = new List<Classes>();
            List<profilePicture> proPicList = ConnectWithServer.getListOfAllPics("select pic, classId from classes");

            List<string> dataInStringArray = new List<string>();
            dataInStringArray = (data.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int j = 0; j < dataInStringArray.Count; j++)
            {
                List<string> invidualClass = new List<string>();
                invidualClass = (dataInStringArray.ElementAt(j).Split(new string[] { ConnectWithServer.separationKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                classId = invidualClass[0];
                nameClass = invidualClass[1];
                place = invidualClass[2];
                activity = invidualClass[3];
                about = invidualClass[invidualClass.Count - 1];
                pic = getPicById(classId, proPicList);
                personRegistedThisClass =getPersonArrayByClassId(classId, listP);
               
                Classes newClassAdded;
                newClassAdded = new Classes(classId, nameClass, place, bool.Parse(activity), about, pic);
                if (personRegistedThisClass != null)
                {
                    newClassAdded.ArrayRegisteredUsersThisClass = personRegistedThisClass;             
                }
                reviewsArrayForThisClass = getReviewArrayByClassId(newClassAdded, listP);
                if(reviewsArrayForThisClass != null)
                {
                    newClassAdded.ArrayReviews=reviewsArrayForThisClass;
                }
                ListOfAllClasses.Add(newClassAdded);
            }
            return ListOfAllClasses;
        }

  
        public static List<Reviews>convartDataToListOfReviews(string data,List<Person> listP,Classes c)
        {
            string id, userId, content, rating, dateInString;
            List<Reviews> ListOfAllReviews = new List<Reviews>();
            PersonList PL = new PersonList(listP);
            List<string> list = new List<string>();
            list = (data.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int j = 0; j < list.Count; j++)
            {
                List<string> invidualReview = new List<string>();
                invidualReview = (list.ElementAt(j).Split(new string[] { ConnectWithServer.separationKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                id = invidualReview[0];
                userId = invidualReview[1]; Person user = PL.findPersonById(userId);
                content = invidualReview[2];
                rating = invidualReview[3];
                dateInString = invidualReview[invidualReview.Count - 1]; DateTime date = Convert.ToDateTime(dateInString);

                Reviews review = new Reviews(id,user,c,content,rating,date);
                ListOfAllReviews.Add(review);
            }
            return ListOfAllReviews;
        }

        public static List<Payments> convartDataToListOfPayments(string data, List<Person> listP,List<Classes>listC)
        {
            string id, userId, classId, sum,paidVia, dateInString;
            List<Payments> ListOfAllPayments = new List<Payments>();
            PersonList PL = new PersonList(listP);
            ClassesList CL=new ClassesList(listC);
            List<string> list = new List<string>();
            list = (data.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int j = 0; j < list.Count; j++)
            {
                List<string> invidualPayment = new List<string>();
                invidualPayment = (list.ElementAt(j).Split(new string[] { ConnectWithServer.separationKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                id = invidualPayment[0];
                userId = invidualPayment[1]; Person user = PL.findPersonById(userId);
                classId = invidualPayment[2]; Classes c=CL.findClassById(classId);
                dateInString = invidualPayment[3]; DateTime date = Convert.ToDateTime(dateInString);
                paidVia = invidualPayment[4];   
                sum = invidualPayment[invidualPayment.Count - 1];

                Payments payment = new Payments(id, user, c,paidVia,sum, date);
                ListOfAllPayments.Add(payment);
            }
            return ListOfAllPayments;
        }

        public static List<Tweets> convartDataToListOfTweets(string data, List<Person> listP)
        {
            string id, userId,dateInString,content;
            Person[] arrOfLikes; 
            List<Tweets> ListOfAlltweets = new List<Tweets>();
            PersonList PL = new PersonList(listP);
            List<string> list = new List<string>();
            list = (data.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
            for (int j = 0; j < list.Count; j++)
            {
                List<string> invidualMessageAdmin = new List<string>();
                invidualMessageAdmin = (list.ElementAt(j).Split(new string[] { ConnectWithServer.separationKey }, StringSplitOptions.RemoveEmptyEntries)).ToList();
                id = invidualMessageAdmin[0];
                userId = invidualMessageAdmin[1]; Person user = PL.findPersonById(userId);
                dateInString = invidualMessageAdmin[invidualMessageAdmin.Count - 1]; DateTime date = Convert.ToDateTime(dateInString);
                content = invidualMessageAdmin[2];
                Tweets tweet = new Tweets(id, user, date, content);
                arrOfLikes = getPersonArrayLikeTweetByTweetId(id, listP);
                if(arrOfLikes != null)
                {
                    tweet.ArrLikesThisTweet = arrOfLikes;
                }
                ListOfAlltweets.Add(tweet);
            }
            return ListOfAlltweets;
        }


        //pic
        public static Image getPicById(string userId, List<profilePicture> list)
        {
            if (list != null)
            {
                foreach (profilePicture picture in list)
                {
                    if (picture.UserId == userId)
                        return picture.Img;
                }
               
            }
            return Properties.Resources.defult_pro_pic2;

        }

        public static List<profilePicture> getListOfAllPics(string commend)
        {
         
            List<profilePicture> list = new List<profilePicture>();
            try
            {
                SqlCommand cmd = new SqlCommand(commend, LogIn.static_conn);
                LogIn.static_conn.Open();  
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
                LogIn.static_conn.Close();
                return list;
            }
            catch
            {
                return null;
            }
        }

        public static bool updatePic(Image pic,string id,string command)
        {
            
            try
            {
                bool updated = false;
                LogIn.static_conn.Open();
                SqlCommand cmd = LogIn.static_conn.CreateCommand();
                var image = new ImageConverter().ConvertTo(pic, typeof(Byte[]));
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText =command;
                if (cmd.ExecuteNonQuery() > 0)
                    updated=true;
                LogIn.static_conn.Close();
                return updated;
            }
            catch 
            {
                return false;
            }
        }







        /// <summary>
        /// dataOperation
        /// 

        public static Person[] getPersonArrayLikeTweetByTweetId(string messageId,List<Person>listP)
        {
            string response = ConnectWithServer.callToServer(controller, "getPersonArrayLikeTweetByTweetId#", messageId);
            if (response == string.Empty)
                return null;
            List<Person> result = new List<Person>();
            PersonList PL = new PersonList(listP);
            string[] idArray = (response.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries));
            foreach (string id in idArray)
            {
                Person p = PL.findPersonById(id);
                result.Add(p);
            }
            return result.ToArray();
        }


        public static Payments[] getPaymentsArrayByUserId(string userId,List<Person> listP,List<Classes>listC)
        {
            string fullPaymentsData = ConnectWithServer.callToServer(controller, "getAllPaymentsArrayByUserId#", userId);
            if (fullPaymentsData != string.Empty)
            {
                List<Payments> listPayments = ConnectWithServer.convartDataToListOfPayments(fullPaymentsData, listP,listC);
                return listPayments.ToArray();
            }
            return null;
        }

        public static Reviews[] getReviewArrayByClassId(Classes c, List<Person> listP)///
        {

            string fullDataReviews = ConnectWithServer.callToServer(controller, "getAllReviewsByIdClass#", c.ClassId);
            if (fullDataReviews != string.Empty)
            {
                List<Reviews> listR = ConnectWithServer.convartDataToListOfReviews(fullDataReviews, listP, c);
                return listR.ToArray();
            }
            return null;
        }

        public static Person[] getPersonArrayByClassId(string classId, List<Person> listP)
        {
            string response = ConnectWithServer.callToServer(controller, "getPersonIdArrayByClassId#", classId);
            if (response == string.Empty)
                return null;
            List<Person> result = new List<Person>();
            PersonList PL = new PersonList(listP);
            string[] idArray = (response.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries));
            foreach (string id in idArray)
            {
                Person p = PL.findPersonById(id);
                result.Add(p);
            }
            return result.ToArray();
        }


        public static Classes[] getClassesArrayByPersonId(string userId, List<Classes> listC)
        {
            string response = ConnectWithServer.callToServer(controller, "getClassesIdArrayByPersonId#", userId);
            if (response == string.Empty)
                return null;
            List<Classes> result = new List<Classes>();
            ClassesList CL = new ClassesList(listC);
            string[] idArray = (response.Split(new string[] { ConnectWithServer.startObjectKey }, StringSplitOptions.RemoveEmptyEntries));
            foreach (string id in idArray)
            {
                Classes c = CL.findClassById(id);
                result.Add(c);
            }
            return result.ToArray();
        }






        public static List<Person> addArraysClassesAndPaymentsToPersonList(List<Person> listP, List<Classes> listC)
        {
            List<Person> newList = new List<Person>();
            foreach (Person person in listP)
            {
                Classes[] classArray = null;
                Payments [] paymentArray=null;
                classArray = getClassesArrayByPersonId(person.UserId, listC);
                paymentArray = getPaymentsArrayByUserId(person.UserId,listP ,listC);
                if (classArray != null)
                {
                    person.ClassesArray = classArray;
                }
                if(paymentArray != null)
                {
                    person.PaymentsArray = paymentArray;
                }
                newList.Add(person);
            }
            return newList;
        }

    }
}






