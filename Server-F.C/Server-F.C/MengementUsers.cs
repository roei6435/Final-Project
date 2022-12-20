using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_F.C
{
    internal class MengementUsers
    {
        public static string blockOrUnblockUser(string userId,string isBloked)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"update users set isBlocked=@isBlocked where userId=@userId;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@isBlocked", isBloked);
                Program.conn.Open();
                int updeted = cmd.ExecuteNonQuery();
                Program.conn.Close();            
                if (updeted > 0)
                    return "true";
                return "false";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "false";

            }

        }

        public static string addPaymentByUserAndClassId(string userId,string classId,string date,string paidVia,string sum)
        {

            try
            {
                Program.conn.Open();
                String sql = "INSERT INTO payments(userId,classId,date,paidVia,sum)values(@userId,@classId,@date,@paidVia,@sum)";
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@classId", classId);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@paidVia", paidVia);
                cmd.Parameters.AddWithValue("@sum", sum);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Program.conn.Close();
                return "true";

            }
            catch 
            {
                Program.conn.Close();
                return "false";
            }
        }


    }
}
