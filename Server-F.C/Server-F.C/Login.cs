using System;
using System.Text;
//using System.Data;
using System.Data.SqlClient;
using System.Data;

namespace Server_F.C
{
    internal class Login:Program
    {
        private static string CreateRandomPassword()
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < 12; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public static string encryptPassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        public static string decryptPassword(string encodedData)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encodedData);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }

        //Check if user exist in system.
        public static string tryLogIn(string email, string password,string admin)           
        {
            try
            {
                string passwordEncrypt=encryptPassword(password);
                conn.Open();            
                String sql = "SELECT (userId) from users where password = '" + passwordEncrypt + "' AND email='"+email+"' AND admin='"+admin+"'";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    
                    Console.WriteLine($"User ID {dataTable.Rows[0][0]} has successfully logged into the system.");
                    conn.Close();
                    return "true "+ dataTable.Rows[0][0];      
                }
                cmd.Dispose();
                conn.Close();
                Console.WriteLine("Login feild.");
                return "false null";
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }


        public static string updateLastConn(string userId)
        {
            string dateConnect = DateTime.Now.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = $"update users set lastConnect = '{dateConnect}' where userId = '{userId}';";
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

        public static string registerToSystem(string fname, string lname, string email,
            string phone, string dateBorn,string gender,string isAdmin)
        {
            try
            {
                string dateRegistion = DateTime.Now.ToString().Split(' ')[0],
                password = CreateRandomPassword();
                Program.conn.Open();
                String sql = "INSERT INTO users(fName,lName,email,phone,password,dateBorn,gender,admin,isAuth,dateRegistion,lastConnect)values(@fName,@lName,@email,@phone,@password,@dateBorn,@gender,@admin,@isAuth,@dateRegistion,@lastConnect)";
                SqlCommand cmd = Program.conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@fName", Program.uppercaseFirstLetter(fname));
                cmd.Parameters.AddWithValue("@lName", Program.uppercaseFirstLetter(lname));
                cmd.Parameters.AddWithValue("@email", Program.uppercaseFirstLetter(email));
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@password", encryptPassword(password));
                cmd.Parameters.AddWithValue("@dateBorn", dateBorn);
                cmd.Parameters.AddWithValue("@gender", bool.Parse(gender));
                cmd.Parameters.AddWithValue("@admin", bool.Parse(isAdmin));
                cmd.Parameters.AddWithValue("@isAuth", false);
                cmd.Parameters.AddWithValue("@dateRegistion", dateRegistion);
                cmd.Parameters.AddWithValue("@lastConnect", dateRegistion);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                Program.conn.Close();
                return "true "+password;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return "false";
            }
            
        }






    }
}
