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

namespace Fitness_Club
{
    public partial class FormMembers : Form
    {


        private Form activeForm;
        public FormMembers()
        {
            InitializeComponent();
               
        }
   
        SqlConnection conn = new SqlConnection("Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True");

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

      
        static private bool nameIsProper(String s)                    //is proper first/last name
        {
           
           if (s.Length<2)return false;
           char ind = s[0]; bool flag = false;
            for (int i = 0; i < s.Length; i++)
            {
                if(ind!=s[i])
                    flag = true;
                if ((s[i] <= '9' && s[i] >= '0') || s[i] == ' ')
                    return false;
            }   
            if (flag)
                return true; 
            return false;
        }
        bool isEmail(string email)                                     //  is proper Email
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
        private bool emailExist(string email)              //chek if email exist in dataBase
        {
           
            try
            {
               
            string querry = "SELECT * FROM person WHERE email ='" + email + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(querry,conn);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);   
            if(dt.Rows.Count > 0)
               return true;
            return false;   
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
                return false;
            }
        }
        private bool PhoneExist(string phone)
        {        
            try
            {

                string querry = "SELECT * FROM person WHERE phone ='" + phone + "'";
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

        }           //check if phone exist in dataBase
        static private bool phoneIsProper(String s)                    //is proper phone numbur
        {
            if (s.Length<10) return false;
            for (int i = 0; i < s.Length; i++)
                if (!(s[i] <= '9' && s[i] >= '0') || s[i] == ' ')
                    return false;
            return true;
        }

        public string strongPassword(string passwd)
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
            if (step1.ForeColor == Color.White)
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
            }         //step1
            else if(step2.ForeColor == Color.White)
            {
                //to check feilds gender and date born not null.
                if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
                    lblTitle.Text = "        Plese choose gender.";
                else if (comboBoxDay.Text == "" || comboBoxMou.Text == "" || comboBoxYear.Text == "")
                    lblTitle.Text = "        Invalid date, try again.";
                else   //go to penel3
                {
                    panelVerS3.Visible = true;
                    panelStep2.Visible = false;
                    lblTitle.Visible = false;               
                    lblTitle2.Location = new Point(320, 55);
                    lblTitle2.Font = new Font("Segoe UI", 14.0f);
                    lblTitle2.Text = "Verify your email: "+txtBoxEmail.Text+"\nusing the verification code we just sent";
                    lblTitle2.Visible = true;
                    step2.ForeColor = Color.DimGray;
                    step3.ForeColor = Color.White;
                }
                    
            }       //step2
            else if(step3.ForeColor == Color.White)        //step3
            {
                //check password same confirm password && password strong enough
                if (strongPassword(txtBoxPassword.Text) != "good")
                    lblTitle.Text = "    " + strongPassword(txtBoxPassword.Text);
                else if (txtBoxPassword.Text != txtBoxConfirmPass.Text)
                    lblTitle.Text = "   Password not Match, try again.";
               else                           //Create a new person.
                {
                    panelStep3.Visible = false;
                    lblTitle.Location = new Point(355, 85);
                    lblTitle.Text = "        The registration was successful";
                    panelStepsAndTitle.Location = new Point(550, 1);
                    step3.ForeColor = Color.DimGray;
                    step4.ForeColor = Color.White;
                    picBocSucc.Visible = true;
                    btnBack.Visible = false;
                    btnNext.Visible = false;
                }
                    

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (step2.ForeColor == Color.White)     //return to panel stup1
            {
                panelStep1.Visible = true;
                panelStep2.Visible = false;
                btnBack.Visible = false;
                lblTitle.Text = "                      Lat's start...";
                step2.ForeColor = Color.DimGray;
                step1.ForeColor = Color.White;
            }
            else if(step3.ForeColor == Color.White)      //return to penel 2
            {
                panelStep2.Visible = true;
                panelStep3.Visible = false;
                lblTitle.Text = "           Just a few more details...";
                step3.ForeColor = Color.DimGray;
                step2.ForeColor = Color.White;
            }
    
        }
        public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
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
            lblTitle.Text = "         Lat's start...";
            lblTitle.Visible = true;
            step3.ForeColor = Color.DimGray;
            step1.ForeColor = Color.White;
        }
    }
}
