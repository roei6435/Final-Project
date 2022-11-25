using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_F.C
{
    internal class MengementClasses
    {
        public static string getAllDataClasses()
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from classes";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    // string pic;
                    for (int i = 0; rdr.Read(); i++)
                    {
                        data += rdr[0] + Program.separationKey;   //ClassId
                        data += rdr[1] + Program.separationKey;    //nameClass
                        data += rdr[2] + Program.separationKey;   //place
                         data += rdr[4] + Program.separationKey;    //activity
                        data += rdr[5] + Program.startObjectKey;  //about

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

        public static string editDatilsClass(string classId,string name,string position,string activity,string about)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"update classes set nameClass=@nameClass , positionClass=@positionClass , active=@active , about=@about where classId=@classId;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nameClass", Program.uppercaseFirstLetter(name));
                cmd.Parameters.AddWithValue("@positionClass", Program.uppercaseFirstLetter(position));
                cmd.Parameters.AddWithValue("@active", activity);
                cmd.Parameters.AddWithValue("@about", Program.uppercaseFirstLetter(about));
                cmd.Parameters.AddWithValue("@classId", classId);
                Program.conn.Open();
                cmd.ExecuteNonQuery();
                Program.conn.Close();
                return "true";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "false";

            }
        }

        public static string getAllReviewsByIdClass(string classId)
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"select * from reviewsClasses where classId='{classId}'";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                   
                    for (int i = 0; rdr.Read(); i++)
                    {
                       // Console.WriteLine(rdr[6].ToString().Split(' ')[0]);
                        data += rdr[0] + Program.separationKey;   //reviewId
                        data += rdr[1] + Program.separationKey;    //userId
                       // data += rdr[2] + Program.separationKey;   //classId
                        data += rdr[3] + Program.separationKey;    //reviewContent
                        data += rdr[4] + Program.separationKey;  //rating
                        data += rdr[5] + Program.startObjectKey;   //date


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
       
        public static string deleteReviewById(string reviewId)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"delete from reviewsClasses where reviewId='{reviewId}';";
                Program.conn.Open();
                int deleted = cmd.ExecuteNonQuery();
                Program.conn.Close();
                if (deleted > 0)
                    return "true";
                return "false";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "false";

            }
        }

    }
}
