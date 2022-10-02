using System;
using System.Data;
using System.Data.SqlClient;
namespace Server_F.C
{
    internal class Dashboard
    {
        //FUNCTION FOR CONVARTION STRING TO BOOLEAN
        private static string GetAge(string dateOfBirth)
        {
            DateTime dateOfBirth1 = Convert.ToDateTime(dateOfBirth);    
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth1.Year * 100 + dateOfBirth1.Month) * 100 + dateOfBirth1.Day;

            return ((a - b) / 10000).ToString();
        }
        public static string Getgender(string flag)
        {
            if (flag== "True") return "male";
            else return "female";
        }
        public static string boolenCheck(string flag)
        {
            if (flag == "True") return "True";
            else return "False";
        }

        //Fetch from the database all relevant data from the users table, stored in a full key-separated string
        public static string getAllDataForAdminScreenInDahsboard()
        {
            string data ="";
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from users";
                cmd.Connection = Program.conn;
                Program.conn.Open();
                DataTable dt = new DataTable();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    for (int i = 0; rdr.Read(); i++)
                    {

                        data +=   rdr[0] + Program.separationKey;   //id
                        data +=  rdr[1] + Program.separationKey;    //fname
                        data +=   rdr[2] + Program.separationKey;   //lname
                        data +=  rdr[3] + Program.separationKey;    //email
                        data +=   rdr[4] + Program.separationKey;   //phone
                        data +=  rdr[6] + Program.separationKey;    //dateB
                        data += rdr[12] + Program.separationKey;    //dateRegistion
                        data += rdr[7] + Program.separationKey;     //gender
                        data +=  rdr[8] + Program.separationKey;    //admin 
                        data += rdr[9] + Program.separationKey;     //isAuth
                        data +=  rdr[10] + Program.startObjectKey;  //isBlocked
                    

                    }

                }

                Program.conn.Close();
                return data;

            }
            catch (Exception err)
            {
                Program.conn.Close();
                Console.WriteLine("from exption in function: " + err.Message);
                return err.Message;
            }
        }






    }
}
