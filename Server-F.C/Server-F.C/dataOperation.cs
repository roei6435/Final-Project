using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_F.C
{
    internal class dataOperation
    {
        public static string getAllReviewsByIdClass(string classId)
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"Select * from reviewsClasses where classId='{classId}' order by date DESC;";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {

                    for (int i = 0; rdr.Read(); i++)
                    {
                        data += rdr[0] + Program.separationKey;   //reviewId
                        data += rdr[1] + Program.separationKey;    //userId
                        data += rdr[3] + Program.separationKey;    //reviewContent
                        data += rdr[4] + Program.separationKey;  //rating
                        string date= (rdr[5] + "").Split(' ')[0];
                        data += date + Program.startObjectKey;   //date
                    }

                }

                Program.conn.Close();
                return data;

            }
            catch (Exception err)
            {
                Program.conn.Close();
                //Console.WriteLine("from exption in function: " + err.Message);
                return "";
            }
        }

        public static string getPersonIdArrayByClassId(string classId)
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"select userId from listClassesByUser where classesId='{classId}';";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    for (int i = 0; rdr.Read(); i++)
                    {
                        data += rdr[0] + Program.startObjectKey;    //userId
                    }

                }

                Program.conn.Close();
                return data;

            }
            catch (Exception err)
            {
                Program.conn.Close();
                Console.WriteLine("from exption in function: " + err.Message);
                return null;
            }
        }

        public static string getClassesIdArrayByPersonId(string userId)
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"select classesId from listClassesByUser where userId='{userId}'; ";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    for (int i = 0; rdr.Read(); i++)
                    {
                        data += rdr[0] + Program.startObjectKey;    //classId
                    }

                }

                Program.conn.Close();
                return data;

            }
            catch (Exception err)
            {
                Program.conn.Close();
                Console.WriteLine("from exption in function: " + err.Message);
                return null;
            }
        }

        public static string getAllPaymentsArrayByUserId(string userId)
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"select * from payments where userId='{userId}' ORDER BY date DESC;";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {

                    for (int i = 0; rdr.Read(); i++)
                    {
                        data += rdr[0] + Program.separationKey;   //idPayment
                        data += rdr[1] + Program.separationKey;    //userId
                        data += rdr[2] + Program.separationKey;    //classId
                        string date = (rdr[3] + "").Split(' ')[0];
                        data += date + Program.separationKey;   //date
                        data += rdr[4] + Program.separationKey;  //paidVia
                        data += rdr[5] + Program.startObjectKey;     //sum

                    }

                }

                Program.conn.Close();
                return data;

            }
            catch (Exception err)
            {
                Program.conn.Close();
                return "";
            }
            //
        }

        public static string getPersonArrayLikeMessageByMessageId(string messageId)
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"select userId from likesOfMessageAdmins where messageId='{messageId}';";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    for (int i = 0; rdr.Read(); i++)
                    {
                        data += rdr[0] + Program.startObjectKey;    //userId
                    }

                }

                Program.conn.Close();
                return data;

            }
            catch
            {
                Program.conn.Close();
                return "";
            }
        }




    }
}
