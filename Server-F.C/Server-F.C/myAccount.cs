using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_F.C
{
    internal class myAccount
    {

        public static string phoneExist(string phone)
        {
            try
            {

                string querry = "SELECT * FROM users WHERE phone ='" + phone + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, Program.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    return "true";
                return "false";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
        public static string emailExist(string email)              //to check if email exist in dataBase
        {

            try
            {

                string querry = "SELECT * FROM users WHERE email ='" + email + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, Program.conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    return "true";
                return "false";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        public static string editDetailsPersonById(string userId,string fName,string lName,
            string email,string phone,string dateBorn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"update users set fName=@fName , lName=@lName , email=@email , phone=@phone, dateBorn=@dateBorn where userId=@userId;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@fName", fName);
                cmd.Parameters.AddWithValue("@lName", lName);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@dateBorn", dateBorn);
                cmd.Parameters.AddWithValue("@userId", userId);
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




    }
}
