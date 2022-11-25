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
using System.IO;
using System.Drawing.Drawing2D;

namespace Fitness_Club
{
    partial class MyAccount : LoginANDRegister
    {
        private Person loggedUser;
        public static string controller = "myAccount#";
        private string passwordLogadUser;
        public MyAccount(Person loggedUser)
        {
            this.loggedUser = loggedUser;
            InitializeComponent();
        }

        //get updated datlis of person.
        private Person RefrehPersonDatils()
        {

            string responseFromServer = ConnectWithServer.callToServer(AdminScreen.controller, "getDataForOnlyThisUserId#", loggedUser.UserId);
            List<Person> listP = new List<Person>();
            listP = ConnectWithServer.ConvartDataToListOfPersons(responseFromServer);
            return listP[0];

        }


        //putting the data on instead of
        private void MyAccount_Load(object sender, EventArgs e)
        {
            Person p = RefrehPersonDatils();
            profilePic.Image = p.ProfilePic;
            lblFname.Text = p.FirstName;
            lblLname.Text = p.LastName;
            lblPhone.Text = p.Phone;
            lblEmail.Text = p.Email;
            lblBornDete.Text = p.DateBorn;
            txtBoxFname.Text = p.FirstName;
            txtBoxLname.Text = p.LastName;
            textBoxPhone.Text = p.Phone;
            textBoxEmail.Text = p.Email;
            textBoxDateBorn.Text = p.DateBorn;
            string fullDataPass = ConnectWithServer.callToServer(controller, "GetPasswordAndLastUpdateByUserId#", loggedUser.UserId);
            passwordLogadUser = fullDataPass.Split(' ')[0];
            checkLastUpdatePassword(fullDataPass.Split(' ')[1]);
            string [] fullDataOfLevelExprince = getLevelExprinceAndCountDays(loggedUser.DateRegistion).Split(' ');

            lblExprinceCountDays.Text =$"You registered in the administrative system before {fullDataOfLevelExprince[2]} days.";
            lblLevel.Text = fullDataOfLevelExprince[0];
            lblLevel.ForeColor = Color.FromName(fullDataOfLevelExprince[1]);

        }



        //open files for selection profile pic 
        public void picBoxEditPicPropfile_Click(object sender, EventArgs e)
        {

            OpenFileDialog od = new OpenFileDialog();
            od.FileName = "";
            od.Filter = "Supported Imeges|*.jpg;*.png";
            if (od.ShowDialog() == DialogResult.OK)
            {
                profilePic.Load(od.FileName);
                btnSaveChenge.Visible = true;
            }

        }


        //put data about diffrent from today to last update password.
        private void checkLastUpdatePassword(string lastUpdatePasswordFromData)
        {
            if (lastUpdatePasswordFromData != "")
            {
                DateTime lastUpdatePassword = Convert.ToDateTime(lastUpdatePasswordFromData);
                string diff = (DateTime.Today - lastUpdatePassword).TotalDays.ToString();
                lblStrongPassAndLastUpdate.Text = $"You last updated your password {diff} days ago. level strong your password is: good.";
            }
            else
            {
                DateTime lastUpdatePassword = Convert.ToDateTime(loggedUser.DateRegistion);
                string diff = (DateTime.Today - lastUpdatePassword).TotalDays.ToString();
                lblStrongPassAndLastUpdate.Text = $"You last updated your password {diff} days ago. level strong your password is: good.";
            }
        }

        //get level exprince, color, and count of days exprince.
        private string getLevelExprinceAndCountDays(string dateRgistionInString)
        {
            
            DateTime dateRgistion = Convert.ToDateTime(dateRgistionInString);
            double diff = (DateTime.Today - dateRgistion).TotalDays;
            if (diff < 30)
            {
                return "Beginner MediumSeaGreen " + diff ;
            }
            else if (diff >= 30 && diff < 365 / 2)
            {
                return "Professional Peru " + diff;
            }
            else return "Master Gold " + diff;
        }
        private void btnSaveChenge_Click_1(object sender, EventArgs e)
        {
            string command = "UPDATE users SET profilePic = @image WHERE userId=@id";
            bool picUpdated=ConnectWithServer.updatePic(profilePic.Image, AdminScreen.static_userId, command);
            if (picUpdated)
            {
                MessageBox.Show("The image has been successfully replaced.");
                btnSaveChenge.Visible = false;
            }
            else
                MessageBox.Show("Oops something went wrong...");
        }

        //open the options entering passwords
        private void picBoxEditDatlis_Click(object sender, EventArgs e)
        {
            txtBoxFname.Visible = true; txtBoxLname.Visible = true; textBoxPhone.Visible = true;
            textBoxEmail.Visible = true; textBoxDateBorn.Visible = true; BtnSaveDatlis.Visible = true;
            picBoxEditDatlis.Visible = false;
        }


        //send requesting to server about updeting the password and response treatment.
        private void BtnChengeThePass_Click(object sender, EventArgs e)
        {
            if (picBoxNewPassIsStrong.Visible && picBoxPassCorrect.Visible)
            {
                string passwordChenged = ConnectWithServer.callToServer(controller, "editPasswordById#", loggedUser.UserId + "#" +
                      txtBoxPass.Text + "#" + txtBoxNewPass.Text);
                if (bool.Parse(passwordChenged))
                {
                    MessageBox.Show("Password changed successfully.");
                    lblStrongPassAndLastUpdate.Text = $"You last updated your password today. level strong your password is: good.";
                    txtBoxPass.Visible = false; txtBoxNewPass.Visible = false;
                    BtnChengeThePass.Visible = false; picBoxPassCorrect.Visible = false; picBoxNewPassIsStrong.Visible = false;
                }
                else
                    MessageBox.Show("Somthing worng, plese try again");
            }
            else
                MessageBox.Show("Entering incorrect fields, try again");

        }

        //Updating user fields, working with the server and verifying entered data.
        private void BtnSaveDatlis_Click(object sender, EventArgs e)
        {
            picBoxFnameVOn.Visible = false; picBoxDateBornVOn.Visible = false; picBoxLnameVOn.Visible = false;
            picBoxPhoneVOn.Visible = false; picBoxEmailVOn.Visible = false;

            if (txtBoxFname.Text != lblFname.Text || txtBoxLname.Text != lblLname.Text ||     //1. if user make any chenge.
                 textBoxPhone.Text != lblPhone.Text || textBoxEmail.Text != lblEmail.Text ||
                 textBoxDateBorn.Text != lblBornDete.Text)
            {
                if (nameIsProper(txtBoxFname.Text) && nameIsProper(txtBoxLname.Text) &&         //2. and validate fields is proper
               phoneIsProper(textBoxPhone.Text) && isEmail(textBoxEmail.Text) && isDate(textBoxDateBorn.Text))
                {
                    string emailExist = ConnectWithServer.callToServer(controller, "emailExist#", AdminScreen.static_userId + "#" + textBoxEmail.Text);
                    string phoneExist = ConnectWithServer.callToServer(controller, "phoneExist#", AdminScreen.static_userId + "#" + textBoxPhone.Text);
                    if (bool.Parse(emailExist))
                        MessageBox.Show("This email existing in the system. Plese entering another email.");
                    else  if (bool.Parse(phoneExist))
                        MessageBox.Show("This phone existing in the system. Plese entering another phone.");
                    else
                    {
                        //if all anything ok send to server all feilds and updete.
                        string dataUpdated = ConnectWithServer.callToServer(controller, "editDetailsPersonById#", loggedUser.UserId +
                          "#" + txtBoxFname.Text + '#' + txtBoxLname.Text + '#' + textBoxEmail.Text + '#' + textBoxPhone.Text
                          + '#' + textBoxDateBorn.Text + "#");

                        if (bool.Parse(dataUpdated))
                        {
                            MessageBox.Show("Your details have been successfully updated.");
                            BtnSaveDatlis.Visible = false; txtBoxFname.Visible = false; txtBoxLname.Visible = false; textBoxPhone.Visible = false;
                            textBoxEmail.Visible = false; textBoxDateBorn.Visible = false; BtnSaveDatlis.Visible = false;
                            picBoxEditDatlis.Visible = true;
                            MyAccount_Load(sender, e);
                        }
                        else MessageBox.Show("Oops something went wrong...");
                    }

                }
                else MessageBox.Show("The fields were entered incorrectly.\n Try again.");
            }
            else
            {
                txtBoxFname.Visible = false; txtBoxLname.Visible = false; textBoxPhone.Visible = false;
                textBoxEmail.Visible = false; textBoxDateBorn.Visible = false; BtnSaveDatlis.Visible = false;
                picBoxEditDatlis.Visible = true;

            }
        }


        //  A pictures of Vi that gives the user an indication of whether he is entering the data correctly.
        private void txtBoxFname_TextChanged(object sender, EventArgs e)
        {
            if (nameIsProper(txtBoxFname.Text) && txtBoxFname.Visible)
            {
                picBoxFnameVOn.Visible = true;
            }
            else
            {
                picBoxFnameVOn.Visible = false;
            }
        }

        private void txtBoxLname_TextChanged(object sender, EventArgs e)
        {

            if (nameIsProper(txtBoxLname.Text) && txtBoxLname.Visible)
            {
                picBoxLnameVOn.Visible = true;
            }
            else
            {
                picBoxLnameVOn.Visible = false;
            }

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Visible)
            {
                string emailExist = ConnectWithServer.callToServer(controller, "emailExist#", AdminScreen.static_userId + "#" + textBoxEmail.Text);
                if (isEmail(textBoxEmail.Text) && bool.Parse(emailExist)==false)
                {
                    picBoxEmailVOn.Visible = true;
                }
                else
                {
                    picBoxEmailVOn.Visible = false;
                }
            }

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPhone.Visible)
            {
                string phoneExist = ConnectWithServer.callToServer(controller, "phoneExist#", AdminScreen.static_userId + "#" + textBoxPhone.Text);
                if (phoneIsProper(textBoxPhone.Text) && bool.Parse(phoneExist)==false)
                {
                    picBoxPhoneVOn.Visible = true;
                }
                else
                {
                    picBoxPhoneVOn.Visible = false;
                }
            }
 
        }

        private void textBoxDateBorn_TextChanged(object sender, EventArgs e)
        {

            if (isDate(textBoxDateBorn.Text) && textBoxDateBorn.Visible)
            {

                picBoxDateBornVOn.Visible = true;
            }
            else
            {
                picBoxDateBornVOn.Visible = false;
            }
        }

        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {

            lblNotCorrect.Visible = true;
            if (txtBoxPass.Text == passwordLogadUser)
            {
                lblNotCorrect.Visible = false;
                picBoxPassCorrect.Visible = true;
                if (picBoxNewPassIsStrong.Visible)
                    BtnChengeThePass.Visible = true;
            }
            else
            {
                lblNotCorrect.Visible = true;
                picBoxPassCorrect.Visible = false;

            }
        }

        private void txtBoxNewPass_TextChanged(object sender, EventArgs e)
        {

            lblNotStrong.Visible = true;
            string res = strongPassword(txtBoxNewPass.Text);
            if (res == "good" && txtBoxNewPass.Text!= passwordLogadUser)
            {
                lblNotStrong.Visible = false;
                picBoxNewPassIsStrong.Visible = true;
                if (picBoxPassCorrect.Visible)
                    BtnChengeThePass.Visible = true;
            }
            else
            {
                if(txtBoxNewPass.Text != passwordLogadUser && txtBoxNewPass.Text!=txtBoxPass.Text)
                    lblNotStrong.Text = res;
                else
                    lblNotStrong.Text = "There is no change between the passwords";
                picBoxNewPassIsStrong.Visible = false;
            }
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            txtBoxPass.Visible = true;txtBoxNewPass.Visible = true;
        }


    }
}
