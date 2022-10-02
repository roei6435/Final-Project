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
      
   
        //Check if user exist in system.
       public static string loginSuccsfully(string email, string password,string admin)           
        {
            try
            {

                conn.Open();            
                String sql = "SELECT (userId) from users where password = '" + password+"' AND email='"+email+"' AND admin='"+admin+"'";
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    
                    Console.WriteLine($"User ID {dataTable.Rows[0][0].ToString()} has successfully logged into the system.");
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
