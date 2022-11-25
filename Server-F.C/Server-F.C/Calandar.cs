using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_F.C
{
    internal class Calandar
    {
        public static string countUserEventsInDay(string userId, string date)
        {
            try
            {

                string querry = $" SELECT * FROM events WHERE date = '{date}' and userId={userId}";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, Program.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt.Rows.Count + "";

            }
            catch 
            {
                return null;
            }
        }
        public static string insertNewEvent(string userId, string eventName, string date, string from, string to, string location)
        {

            try
            {
                Program.conn.Open();
                String sql = "INSERT INTO events(userId,eventName,date,fromHour,toHour,location)values(@userId,@eventName,@date,@fromHour,@toHour,@location)";
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@eventName", eventName);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@fromHour", from);
                cmd.Parameters.AddWithValue("@toHour", to);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Program.conn.Close();
                return "true";

            }
            catch (Exception ex)
            {
               // Console.WriteLine(ex);
                Program.conn.Close();
                return "false";
            }

        }

        public static string allEventsForThisDay(string userId, string date)
        {
            string data = "";
            try
            {
                Program.conn.Open();
                String sql = "SELECT * FROM events where date = @date AND userId=@userId";
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@userId", userId);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    data += rdr[0] + Program.separationKey;    //eventId
                    data += rdr[2] + Program.separationKey;   //eventName
                    data += rdr[3] + Program.separationKey;    //date
                    data += rdr[4] + Program.separationKey;   //fromHour
                    data += rdr[5] + Program.separationKey;    //toHour
                    data += rdr[6] + Program.startObjectKey;   //location
                }
                rdr.Dispose();
                cmd.Dispose();
                Program.conn.Close();
                return data;
            }
            catch 
            {
                return "false";
            }
        }

        public static string deleteEventByEventId(string userId, string eventId)
        {
            try
            {


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"delete  FROM events WHERE eventId='{eventId}' AND userId='{userId}';";
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
