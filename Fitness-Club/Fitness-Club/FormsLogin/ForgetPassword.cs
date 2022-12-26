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
using System.Runtime.InteropServices;
using System.Windows.Threading;

namespace Fitness_Club.Resources.FormsLogin
{
    public partial class ForgetPassword : LoginANDRegister
    {
        private string userId = "none";
        public int fiveMinutes = 300;
        private DispatcherTimer dispatcherTimer;
        public ForgetPassword()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        //MOUSE MOVING FUCTIOUNS

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); //send position window

        private void panelTitle_MouseDown_1(object sender, MouseEventArgs e)                     //moving from panel title
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ForgetPassword_Load(object sender, EventArgs e)
        {
            dispatcherTimer = new DispatcherTimer();                //CREATE TIMER
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

        }
        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if(fiveMinutes > 0)
            {
                //TIMER WORK
                fiveMinutes--;
                int minutes = fiveMinutes / 60, sec = fiveMinutes - (minutes * 60);
                float percent = ((minutes * 60 + sec) / 300f) * 100;
                circleTimer.Text = $"{minutes}:{sec.ToString("00")}";
                circleTimer.Value = Convert.ToInt32(percent);
            }
            else
            {                          //RESET TIMER
                fiveMinutes = 300;
                dispatcherTimer.Stop();
                activeAndNonActivePanels(step1, panelStep1, step2, panelStep2);
               
            }

        }

        //MOVEING IN STEPS 
        private void activeAndNonActivePanels(Label lineActive,Panel panelActive, Label lineNonActive, Panel panelNonActive)
        {
            lineActive.ForeColor = Color.White;
            lineNonActive.ForeColor = Color.DimGray;
            panelActive.Visible = true;
            panelNonActive.Visible = false;
        }
        
        //STEP 1
        private void btnSendMail_Click(object sender, EventArgs e)
        {
            lblErrorStep1.Visible = true;
            //VALIDATION INPUTS
            if (!lblNotCorrectPhone.Visible && !lblNotCorrectEmail.Visible&&txtBoxEmail.Text!=string.Empty&&txtBoxPhone.Text!=string.Empty)
            {
               //REQUEST TO SERVER
                string response=ConnectWithServer.callToServer(MyAccount.controller, "userExistByEmailAndPhone#", txtBoxEmail.Text + "#" + txtBoxPhone.Text + "#");
                try
                {
                    bool userExist = bool.Parse(response.Split(' ')[0]);
                    userId = response.Split(' ')[1];
                    if (!userExist)            //USER NOT EXIST
                    {
                        lblErrorStep1.Text = "Sorry, no user linked to these details was found.";
                        
                    }
                    else
                    {

                        if (!SendEmailPasscode(txtBoxEmail.Text))   //EMAIL NOT SENDING(ERROR)
                        {
                            lblErrorStep1.Text = "Oops, somthing worng...";     
                        }
                        else
                        {
                            //IF ALL IT'S OK
                            lblEmailSent.Text = $"Verification Passcode sent to email {txtBoxEmail.Text}. the verification code is valid for 5 minutes only.";
                            lblErrorStep1.Visible = false;
                            dispatcherTimer.Start();
                            activeAndNonActivePanels(step2, panelStep2, step1, panelStep1);

                        }
                        
                    }
                }
                catch
                {
                    //RESPONSE=ERROR FROM SERVER
                    lblErrorStep1.Text = "Oops, somthing worng...";          
                }
               
            }
            else
            {
                //PHONE OR EMAIL NOT CORRECT
                if (lblNotCorrectPhone.Visible)          
                {
                    lblErrorStep1.Text = "Sorry, an invalid phone was entered.";
                }
                else
                {
                    lblErrorStep1.Text = "Sorry, an invalid email was entered."; //was entered email not correct  
                }
            }
        }

        //BACK TO STEP 1
        private void btnBackToStep1_Click(object sender, EventArgs e)
        {
            fiveMinutes = 300;
            dispatcherTimer.Stop();
            activeAndNonActivePanels(step1, panelStep1, step2, panelStep2);
        }

        //STEP 2
        private void btnVerify_Click(object sender, EventArgs e)
        {

            if (passcode == txtBoxPassCode.Text)
            {
                activeAndNonActivePanels(step3, panelStep3, step2, panelStep2);
            }
            else
            {
                lblErrorStep2.Visible = true;
            }
          

        }

        //STEP 3
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //VALIDATION PASSWORDS
            if (!lblPasswordStrong.Visible && !lblPasswordMatch.Visible &&
                txtBoxNewPassword.Text != string.Empty && txtBoxConfirmPassword.Text != string.Empty)
            {
                //REQUEST TO SERVER - UPDATE
                string passwordUpdated = ConnectWithServer.callToServer(MyAccount.controller, "editPasswordById#", userId + "#" + txtBoxNewPassword.Text);
                try
                {
                    if (bool.Parse(passwordUpdated))
                    {
                        //UPDATED SUCCESSFULLY
                        activeAndNonActivePanels(step4, panelStep4, step3, panelStep3);
                    }
                }
                catch
                {
                    //ANY ERROR
                    MessageBox.Show("Oops, somthing worng");
                }
            }
            else
            {
                //FAILED INPUT
                MessageBox.Show("Please enter valid data.");
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (LoginANDRegister.isEmail(txtBoxEmail.Text))
            {
                lblNotCorrectEmail.Visible = false;
            }
            else
            {
                lblNotCorrectEmail.Visible = true;
            }
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (LoginANDRegister.phoneIsProper(txtBoxPhone.Text))
            {
                lblNotCorrectPhone.Visible = false;
            }
            else
            {
                lblNotCorrectPhone.Visible = true;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxPhone.Text = string.Empty;
            txtBoxEmail.Text = string.Empty;
        }

        private void btnClearPasswords_Click(object sender, EventArgs e)
        {
            txtBoxConfirmPassword.Text = string.Empty;
            txtBoxNewPassword.Text = string.Empty;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            txtBoxNewPassword.UseSystemPasswordChar = false;
            txtBoxConfirmPassword.UseSystemPasswordChar = false;
        }

        private void txtBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            string result = strongPassword(txtBoxNewPassword.Text);
            lblPasswordStrong.Visible = true;
            if(result != "good")
            {
                lblPasswordStrong.Text = result;
            }
            else
            {
                lblPasswordStrong.Visible = false;
            }
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswordMatch.Visible = true;
            if (txtBoxNewPassword.Text == txtBoxConfirmPassword.Text)
            {
                lblPasswordMatch.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LogIn lo = new LogIn();
            this.Hide();
            lo.Show();
        }
        private void btnReturnToHomeForm_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




    }
}
