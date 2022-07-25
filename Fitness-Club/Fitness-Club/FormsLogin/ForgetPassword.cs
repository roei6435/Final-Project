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
using System.Data;
using System.Data.SqlClient;



namespace Fitness_Club.Resources.FormsLogin
{
    public partial class ForgetPassword : Form
    {

        public static string to, email,passcode;
 
        public ForgetPassword()
        {
            InitializeComponent();
        }
        string strCon = "Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True";
        
        private string genratePasscode()
        {
            Random rnd = new Random();
            passcode=rnd.Next(99999).ToString();
            return passcode;
        }

        public string properPassword(string passwd)
        {
            if (passwd.Length < 8 || passwd.Length > 14)
                return "Minimum 8 char and maximum 14 char";
            else if (!passwd.Any(char.IsUpper))
                return "Minimum One upper case";
            else if (!passwd.Any(char.IsLower))
                return "Atleast one lower case";
            else if (passwd.Contains(" "))
                return "No white space";
            return "good!!";
            
            

        }
        bool isEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    
        private void btnSend_Click(object sender, EventArgs e)
        {

                  
            if (isEmail((txtBoxEmail.Text).ToString()))
            {
                string fromMail = "roei6435@gmail.com";
                string fromPassword = "szucuztaplqjtvet";
                to = (txtBoxEmail.Text).ToString();
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

                    lblEmailSent.Visible = true;
                    lblEmailSent2.Text = to;
                    lblEmailSent2.Visible = true;
                    panelFields.Visible = false;
                    panelVer.Location = new Point(560, 125);
                    panelVer.Visible = true;
                }
                catch (Exception ex)
                {
                    lblNotProper.Text = ex.ToString();
                    lblNotProper.Visible = true;
                }
            }        
            else
            {
                lblNotProper.Text = "The email not proper, enter email again.";
                lblNotProper.Visible = true;   
            }
        
        }

    
        private void btnVer_Click(object sender, EventArgs e)
        {
            if (passcode == (txtBoxPassCode.Text.ToString())){
                panelVer.Visible = false;
                panelCnfirm.Location = new Point(570, 110);
                panelCnfirm.Visible = true; 
                email=(txtBoxEmail.Text.ToString());

            }
            else
            {
                lblEmailSent.Text = "Passcode not match, try again";
                lblEmailSent2.Visible = false;
            }

        }

        private void btnReturnToHomeForm_Click(object sender, EventArgs e)
        {
            LogIn log=new LogIn();
            this.Hide();
            log.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelVer.Visible = false;
            panelCnfirm.Location = new Point(570, 180);
            panelCnfirm.Visible = true;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            txtBoxConfirmPass.UseSystemPasswordChar = false;
            txtBoxNewPassword.UseSystemPasswordChar = false;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            panelVer.Visible = false;
            panelFields.Location = new Point(570, 180);
            panelFields.Visible = true;
            lblEmailSent2.Visible = false;
            lblEmailSent.Visible = false;
            lblEmailSent.Text = "Verification passcode sent to email";
            lblEmailSent2.Text = "";
            txtBoxPassCode.Text = "";

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
           
            if (txtBoxConfirmPass.Text==txtBoxNewPassword.Text&&properPassword(txtBoxNewPassword.Text) =="good") 
            {
                //chenge password in dataBase
               lblChengeOk.Text = "ok";
               lblChengeOk.Visible = true;
         
            }
            else
            {
                //try again
                lblChengeOk.Text = properPassword(txtBoxNewPassword.Text);
                lblChengeOk.Visible = true;
                txtBoxNewPassword.Text = "";
                txtBoxConfirmPass.Text = "";
            }
        }
    }
}
