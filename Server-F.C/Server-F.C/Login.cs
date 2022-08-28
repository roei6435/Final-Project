using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data;
using System.Data.SqlClient;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Data;

namespace Server_F.C
{
    internal class Login:Program
    {
        public static SqlConnection conn = new SqlConnection("Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True");
   




       public static string loginSuccsfully(string email, string password,string admin)            //have user
        {
            try
            {

                conn.Open();            
                String sql = "SELECT * from users where password = '"+password+"' AND email='"+email+"' AND admin='"+admin+"'";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                //cmd.Parameters.AddWithValue("@email", email);
                //cmd.Parameters.AddWithValue("@password", password);
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                  
                    Console.WriteLine("login Succsfully.");
                    conn.Close();
                    return "true";
                   
                }
                cmd.Dispose();
                conn.Close();
                Console.WriteLine("Login feild.");
                return "false";
            }
            catch (Exception ex)
            {
                conn.Close();
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }



   

    }
}
