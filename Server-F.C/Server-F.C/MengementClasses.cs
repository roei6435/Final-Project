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
                        //string noPic = "null";
                       // if (rdr[3].GetType() != typeof(DBNull))
                         //   noPic = rdr[15].ToString();
                        data += rdr[0] + Program.separationKey;   //ClassId
                        data += rdr[1] + Program.separationKey;    //nameClass
                        data += rdr[2] + Program.startObjectKey;   //place
                        // data += rdr[3] + Program.separationKey;    //pic

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
    }
}
