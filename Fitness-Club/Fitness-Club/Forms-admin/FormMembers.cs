using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace Fitness_Club
{
    public partial class FormMembers : LoginANDRegister
    {


       // private Form activeForm;
        
        public FormMembers()
        {
            InitializeComponent();
               
        }
   
       

        private void loadTheme()                                 //loading color
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))        //if btn prv is button
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemColor.primaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemColor.secondColor;
                }
            }


        }
        private void FormMembers_Load(object sender, EventArgs e)
        {
            loadTheme();
        }

    
        private void viewPass_Click(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = false;
            txtBoxConfirmPass.UseSystemPasswordChar = false;
        }


        //Checking the proper of fields on chenged

        private void txtBoxFname_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFname.Text.Length == 0)
            {
                viFn.Visible = false;
                picBoxFnameOk.Visible = false;
            }
            else if (!nameIsProper(txtBoxFname.Text))
            {
                viFn.Visible = true;
                picBoxFnameOk.Visible = false;
            }
            else
            {
                picBoxFnameOk.Visible = true;
                viFn.Visible = false;
            }
        }     

        private void txtBoxLname_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxLname.Text.Length == 0)
            {
                vOffLN.Visible = false;
                picBoxLnameOk.Visible = false;
            }
            else if (!nameIsProper(txtBoxLname.Text) || txtBoxLname.Text.Length < 2)
            {
                vOffLN.Visible = true;
                picBoxLnameOk.Visible = false;
            }
            else
            {
                picBoxLnameOk.Visible = true;
                vOffLN.Visible = false;
            }
        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxEmail.Text.Length == 0)
            {
                vOffEmail.Visible = false;
                picBoxEmailOk.Visible = false;
            }
            else if (!isEmail(txtBoxEmail.Text) || emailExist(txtBoxEmail.Text))
            {
                vOffEmail.Visible = true;
                picBoxEmailOk.Visible = false;
            }
            else
            {
                vOffEmail.Visible = false;
                picBoxEmailOk.Visible = true;
            }
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPhone.Text.Length == 0)
            {
                vOffPass.Visible = false;
                picBoxPassOk.Visible = false;
            }
            else if (PhoneExist(comboBoxBefore.Text + txtBoxPhone.Text) ||
                !phoneIsProper(comboBoxBefore.Text + txtBoxPhone.Text))
            {
                vOffPass.Visible = true;
                picBoxPassOk.Visible = false;
            }
            else
            {
                vOffPass.Visible = false;
                picBoxPassOk.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)        
        {
            if (step1.ForeColor == Color.White)     //step1
            {
                
                //cheked feilds 
                //return error in the title.
                if (!nameIsProper(txtBoxLname.Text)||!nameIsProper(txtBoxFname.Text))
                    lblTitle.Text = "        Invalid name, try again.";
                else if (!isEmail(txtBoxEmail.Text))
                    lblTitle.Text = "        Invalid email, try again.";
                else if (emailExist(txtBoxEmail.Text))
                    lblTitle.Text = "      This email exists in the system.";
                else if (!phoneIsProper(comboBoxBefore.Text + txtBoxPhone.Text))
                    lblTitle.Text = "      Invalid phone numbur, try again.";
                else if (PhoneExist(comboBoxBefore.Text + txtBoxPhone.Text))
                    lblTitle.Text = " This phone connected to atoher account.";
                //If evtithing ok,go to penel 2.
                else                       
                {
                    panelStep1.Visible = false;
                    panelStep2.Visible = true;
                    btnBack.Visible = true;
                    lblTitle.Text = "           Just a few more details...";
                    step1.ForeColor= Color.DimGray;
                    step2.ForeColor = Color.White;

                }    
            }        
            else if(step2.ForeColor == Color.White)        //step2
            {
                //to check feilds gender and date born not null.
                if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
                    lblTitle.Text = "        Plese choose gender.";
                else if (comboBoxDay.Text == "" || comboBoxMou.Text == "" || comboBoxYear.Text == "")
                    lblTitle.Text = "        Invalid date, try again.";
                else   //go to penel3--send passcode to email
                {
                    SendEmailPasscode(txtBoxEmail.Text);
                    panelVerS3.Visible = true;
                    panelStep2.Visible = false;
                    lblTitle.Visible = false;               
                    lblTitle2.Location = new Point(320, 55);
                    lblTitle2.Font = new Font("Segoe UI", 14.0f);
                    lblTitle2.Text = "Verification Passcode sent to email:\n" + txtBoxEmail.Text+"\nenter the verification code we just sent.";
                    lblTitle2.Visible = true;
                    step2.ForeColor = Color.DimGray;
                    step3.ForeColor = Color.White;
                }
                    
            }      
            else if(step3.ForeColor == Color.White)        //step3
            {
                if (passcode == (txtBoxPassCode.Text))
                {   
                    //crate parson,add to data base
                   // Person p1=new Person()
                    //sending email with password and completed registor
                }
                else
                {
                   lblTitle2.Text = "Passcode not match, try again";
                }


            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (step2.ForeColor == Color.White)     //return to panel stup1
            {
                lblTitle2.Visible = false;
                lblTitle.Visible = true;
                panelStep1.Visible = true;
                panelStep2.Visible = false;
                btnBack.Visible = false;
                lblTitle.Text = "                      Lat's start...";
                step2.ForeColor = Color.DimGray;
                step1.ForeColor = Color.White;
            }
            else if(step3.ForeColor == Color.White)      //return to penel 2
            {
                lblTitle.Visible = true;
                lblTitle2.Visible = false;
                panelStep2.Visible = true;
                panelStep3.Visible = false;
                lblTitle.Text = "           Just a few more details...";
                step3.ForeColor = Color.DimGray;
                step2.ForeColor = Color.White;
            }
    
        }
        
        private void txtBoxConfirmPass_TextChanged(object sender, EventArgs e)
        {

            if (txtBoxConfirmPass.Text == "")
            {
                picBoxConPassVOff.Visible = false;
                picBoxConPassVOn.Visible = false;
            }
            else if (txtBoxPassword.Text!= txtBoxConfirmPass.Text)
            {
                picBoxConPassVOff.Visible = true;
                picBoxConPassVOn.Visible = false;
            }
            else
            {
                picBoxConPassVOff.Visible = false;
                picBoxConPassVOn.Visible = true;
            }
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxPassword.Text == "") {
                picBoxPassVOn.Visible = false;
                picBoxPassVOff.Visible = false;
            }
            else if (strongPassword(txtBoxPassword.Text) != "good")
            {
                picBoxPassVOn.Visible = false;
                picBoxPassVOff.Visible = true;
            }
            else
            {
                picBoxPassVOn.Visible = true;
                picBoxPassVOff.Visible = false;
            }
                
        }

        private void lblCheckEmail_Click(object sender, EventArgs e)
        {
            panelStep1.Visible = true;
            panelVerS3.Visible = false;
            btnBack.Visible = false;
            lblTitle2.Visible = false;
            lblTitle.Text = "                       Lat's start...";
            lblTitle.Visible = true;
            step3.ForeColor = Color.DimGray;
            step1.ForeColor = Color.White;
        }
    }
}
