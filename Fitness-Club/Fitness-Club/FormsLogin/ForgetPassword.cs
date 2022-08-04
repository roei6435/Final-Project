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
using System.Data.SqlClient;



namespace Fitness_Club.Resources.FormsLogin
{
    public partial class ForgetPassword : LoginANDRegister
    {

 
        public ForgetPassword()
        {
            InitializeComponent();
        }
       
       
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (isEmail(txtBoxEmail.Text))
            {

                if (SendEmailPasscode(txtBoxEmail.Text))
                {
                    lblEmailSent.Visible = true;
                    lblEmailSent2.Text = to;
                    lblEmailSent2.Visible = true;
                    panelFields.Visible = false;
                    panelVer.Location = new Point(560, 125);
                    panelVer.Visible = true;
                }
                else
                {
                    lblNotProper.Text = "The email not proper, enter email again.";
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
           
            if (txtBoxNewPassword.Text==txtBoxConfirmPass.Text && strongPassword(txtBoxNewPassword.Text)=="good") 
            {
               //update password in dataBase
               lblChengeOk.Text = "ok";
               lblChengeOk.Visible = true;
         
            }
            else
            {
                //try again
                if (txtBoxNewPassword.Text != txtBoxConfirmPass.Text)
                    lblChengeOk.Text = strongPassword(txtBoxNewPassword.Text);
                else
                    lblChengeOk.Text = "Password not match!";
                lblChengeOk.Visible = true;

            }
        }

     
    }
}
