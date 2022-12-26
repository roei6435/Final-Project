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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Fitness_Club
{
    public partial class LoginANDRegister : Form
    {
        public LoginANDRegister()
        {
            InitializeComponent();
        }
    

        protected static string to, email, passcode;

        public static bool isEmail(string email)                            //to check if proper Email
        {
            email = email.ToLower();
            string[] sub = email.Split('.');
            try
            {
                
                var addr = new System.Net.Mail.MailAddress(email);
                return (addr.Address == email) && sub[1] == "com" || ( sub[1] == "co"&&sub[2]=="il");
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

        protected bool SendEmailWellcomeToSystem(string email,string password,string fullName)
        {
               
                string fromMail = "roei6435@gmail.com";
                string fromPassword = "szucuztaplqjtvet";
                to = email;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Wellcome to Fitness-Club";
                message.To.Add(new MailAddress(to));
                message.Body = $"Wellcome dear {fullName}. Now your for logged to system the password is:{password}\n" +
                $"You can change it in application-settings password. ENJOY. :) ";
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

        }


        public bool SendEmailPasscode(string email)
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

        }
        //sending email
        public static bool nameIsProper(String name)                    //to check if proper first/last name
        {
           return Regex.IsMatch(name, @"^[a-zA-Z ]+$");
        }

        public static bool phoneIsProper(String numbur)                    //to check if is proper phone numbur
        {

            if (numbur.Length < 10) return false;
            return numbur.All(char.IsDigit);
        }

        private void LoginANDRegister_Load(object sender, EventArgs e)
        {

        }

       
        protected bool isDate(string date) 
        {
            try
            {
                DateTime dt = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dt.Year < 1900|| dt.Year > DateTime.Now.Year-1) return false; 
                return true;
            }
            catch
            {
                return false;
            }
           
        }


        protected string strongPassword(string passwd)
        {
            if (passwd.Length < 8 || passwd.Length > 14)
                return "Minimum 8 char and maximum 14 char";
            else if (!passwd.Any(char.IsUpper))
                return "Minimum One upper case";
            else if (!passwd.Any(char.IsLower))
                return "Atleast one lower case";
            else if (passwd.Contains(" ")||passwd.Contains("#"))
                return "No white space or #";
            return "good";

        }         //to check password quelity

       public static string lastConnectDiff(string lastConn)
        {
            
            if (lastConn != "null")
            {
                var prevDate = Convert.ToDateTime(lastConn);
                var today = DateTime.Now;

                var diffOfDates = today - prevDate;

                if (diffOfDates.Days == 0 && diffOfDates.Hours == 0)
                {
                    if (diffOfDates.Minutes < 11)
                        return "Active now";
                    return diffOfDates.Minutes + "m";
                }
                else if (diffOfDates.Days == 0 && diffOfDates.Hours != 0)
                    return diffOfDates.Hours + "h";
                else
                {
                    if(diffOfDates.Days<7)
                        return diffOfDates.Days + "d";
                    return $"{diffOfDates.Days/7}w";
                }

            }
            return "-";

        }

        public static string uppercaseFirstLetter(string str)
        {
            string res = char.ToUpper(str[0]).ToString();
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i - 1] == ' ')
                    res += char.ToUpper(str[i]);
                else
                    res += char.ToLower(str[i]);
            }
            return res;
        }


    }
}
