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

        public static string phoneExist(string userId, string phone)
        {
            try
            {

                string querry = $"SELECT * FROM users WHERE phone ='{phone}' and userId!='{userId}';";
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
        public static string emailExist(string userId,string email)              //to check if email exist in dataBase
        {

            try
            {

                string querry = $"SELECT * FROM users WHERE email ='{email}' and userId!='{userId}';";
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

        public static string getDataForOnlyThisUserId(string userId)
        {
            string data = "";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"select * from users where userId='{userId}';";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    // string pic;
                    for (int i = 0; rdr.Read(); i++)
                    {
                        string lastConn = "null";
                        if (rdr[15].GetType() != typeof(DBNull))
                            lastConn = rdr[15].ToString();
                        data += rdr[0] + Program.separationKey;   //id
                        data += rdr[1] + Program.separationKey;    //fname
                        data += rdr[2] + Program.separationKey;   //lname
                        data += rdr[3] + Program.separationKey;    //email
                        data += rdr[4] + Program.separationKey;   //phone
                        data += rdr[6] + Program.separationKey;    //dateB
                        data += rdr[12] + Program.separationKey;    //dateRegistion
                        data += lastConn + Program.separationKey;  //lastConn
                        data += rdr[7] + Program.separationKey;     //gender
                        data += rdr[8] + Program.separationKey;    //admin 
                        data += rdr[9] + Program.separationKey;     //isAuth
                        data += rdr[10] + Program.startObjectKey;  //isBlocked

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

        public static string editDetailsPersonById(string userId,string fName,string lName,
            string email,string phone,string dateBorn)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"update users set fName=@fName , lName=@lName , email=@email , phone=@phone, dateBorn=@dateBorn where userId=@userId;";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@fName", Program.uppercaseFirstLetter(fName));
                cmd.Parameters.AddWithValue("@lName", Program.uppercaseFirstLetter(lName));
                cmd.Parameters.AddWithValue("@email", Program.uppercaseFirstLetter(email));
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

        public static string GetPasswordAndLastUpdateByUserId(string userId)
        {
            string password = null;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = $"SELECT password, lastUpdateOfPassword from users where userId='{userId}';";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    password=rdr[0]+" "+rdr[1];
                }

                Program.conn.Close();
                return password;

            }
            catch (Exception err)
            {
                Program.conn.Close();
                Console.WriteLine("from exption in function: " + err.Message);
                return null;
            }
        }

        public static string editPasswordById(string userId,string password,string newPassword)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"update users set password = '{newPassword}', lastUpdateOfPassword = '{DateTime.Today.ToString().Split(' ')[0]}' where password = '{password}' and userId = '{userId}';";
                Program.conn.Open();
                int updeted=cmd.ExecuteNonQuery();
                Program.conn.Close();
                if(updeted>0)
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
