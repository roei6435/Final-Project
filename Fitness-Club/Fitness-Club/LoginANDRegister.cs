using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
//using System.Data;
using System.Data.SqlClient;

namespace Fitness_Club
{
    public partial class LoginANDRegister : Form
    {
        public LoginANDRegister()
        {
            InitializeComponent();
        }
        protected  SqlConnection conn = new SqlConnection("Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True");

        protected static string to, email, passcode;

        protected bool isEmail(string email)                            //to check if proper Email
        {
          string[] sub = email.Split('.');
            try
            {
                
                var addr = new System.Net.Mail.MailAddress(email);
                return (addr.Address == email) && sub[1] == "com" || sub[1] == "co";
            }
            catch
            {
                return false;
            }
        }

        protected string genratePasscode()
        {
            Random rnd = new Random();
            passcode = rnd.Next(99999).ToString();
            return passcode;
        }                       //to Generateryting passcode

        protected bool SendEmailPasscode(string email)
        {
               
                string fromMail = "roei6435@gmail.com";
                string fromPassword = "szucuztaplqjtvet";
                to = email;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Fitness-Club reset password";
                message.To.Add(new MailAddress(to));
                passcode = genratePasscode();
                message.Body = "Enter this passcode " + passcode + " for to be continued ";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(fromMail, fromPassword);
                smtp.EnableSsl = true;
                try
                {
                    smtp.Send(message);
                    return true;
                }
                catch
                {
                    return false;
                }

        }                   //sending email
        protected bool nameIsProper(String s)                    //to check if proper first/last name
        {

            if (s.Length < 2) return false;
            char ind = s[0]; bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (ind != s[i])
                    flag = true;
                if ((s[i] <= '9' && s[i] >= '0') || s[i] == ' ')
                    return false;
            }
            if (flag)
                return true;
            return false;
        }

        protected bool emailExist(string email)              //to check if email exist in dataBase
        {

            try
            {

                string querry = "SELECT * FROM users WHERE email ='" + email + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        protected bool PhoneExist(string phone)
        {
            try
            {

                string querry = "SELECT * FROM users WHERE phone ='" + phone + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    return true;
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }           //to check if phone exist in dataBase

        protected bool phoneIsProper(String s)                    //to check if is proper phone numbur
        {
            if (s.Length < 10) return false;
            for (int i = 0; i < s.Length; i++)
                if (!(s[i] <= '9' && s[i] >= '0') || s[i] == ' ')
                    return false;
            return true;
        }


        protected string strongPassword(string passwd)
        {
            if (passwd.Length < 8 || passwd.Length > 14)
                return "Minimum 8 char and maximum 14 char";
            else if (!passwd.Any(char.IsUpper))
                return "Minimum One upper case";
            else if (!passwd.Any(char.IsLower))
                return "Atleast one lower case";
            else if (passwd.Contains(" "))
                return "No white space";
            return "good";

        }         //to check password quelity

        protected string GetRandomPassword()                      //to Generateryting Quality Password.
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

    }
}
