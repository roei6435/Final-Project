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
