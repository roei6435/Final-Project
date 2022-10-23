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

namespace Fitness_Club
{
     partial class MyAccount : LoginANDRegister
    {
        private Person loggedUser;
        static string controller = "myAccount#";
        public MyAccount(Person loggedUser)
        {
            this.loggedUser = loggedUser;   
            InitializeComponent();
        }

        //get updated datlis of person.
        private Person RefrehPersonDatils()        
        {
           
            string responseFromServer = ConnectWithServer.callToServer(AdminScreen.controller, "getDataForOnlyThisUserId#",loggedUser.UserId);
            List<Person> listP = new List<Person>();
            listP = ConnectWithServer.ConvartDataToListObjects(responseFromServer);
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

        }

        //open files for selection profile pic 
        private void picBoxEditPicPropfile_Click(object sender, EventArgs e)
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


        //function connacting to dataBase and update the profile picture.
        private void btnUpdatePic()
        {
            try
            {
                LogIn.static_conn.Open();
                SqlCommand cmd = LogIn.static_conn.CreateCommand();
                var image = new ImageConverter().ConvertTo(profilePic.Image, typeof(Byte[]));
                string id = AdminScreen.static_userId;
                cmd.Parameters.AddWithValue("@image", image);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandText = "UPDATE users SET profilePic = @image WHERE userId=@id";
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("The image has been successfully replaced.");
                else
                    MessageBox.Show("Oops something went wrong...");
                LogIn.static_conn.Close();
                btnSaveChenge.Visible=false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void btnSaveChenge_Click_1(object sender, EventArgs e)
        {
            btnUpdatePic();
        }

        private void picBoxEditDatlis_Click(object sender, EventArgs e)
        {
            txtBoxFname.Visible = true; txtBoxLname.Visible = true; textBoxPhone.Visible = true;
            textBoxEmail.Visible = true; textBoxDateBorn.Visible = true; BtnSaveDatlis.Visible = true;
           picBoxEditDatlis.Visible = false;
        }



        //Updating user fields, working with the server and verifying entered data.
        private void BtnSaveDatlis_Click(object sender, EventArgs e)
        {
            picBoxFnameVOn.Visible = false;picBoxDateBornVOn.Visible=false;picBoxLnameVOn.Visible=false;
            picBoxPhoneVOn.Visible = false;picBoxEmailVOn.Visible = false;

            if (txtBoxFname.Text != lblFname.Text|| txtBoxLname.Text!=lblLname.Text ||     //1. if user make any chenge.
                 textBoxPhone.Text != lblPhone.Text||textBoxEmail.Text!=lblEmail.Text||
                 textBoxDateBorn.Text!=lblBornDete.Text)
            {
                if (nameIsProper(txtBoxFname.Text) && nameIsProper(txtBoxLname.Text) &&         //2. and validate fields is proper
               phoneIsProper(textBoxPhone.Text) && isEmail(textBoxEmail.Text)&&isDate(textBoxDateBorn.Text))
                {

                                                                  //3.Check if email or phone changed, if yes check if can add to sysytem
                    string phoneExist = ConnectWithServer.callToServer(controller, "phoneExist#", textBoxPhone.Text);
                    string emailExist = ConnectWithServer.callToServer(controller, "emailExist#", textBoxEmail.Text);
                    if (bool.Parse(phoneExist) && textBoxPhone.Text != loggedUser.Phone)
                        MessageBox.Show("This phone exist in system.");
                    else if (bool.Parse(emailExist) && textBoxEmail.Text != loggedUser.Email)
                        MessageBox.Show("This email exist in system.");
                    else
                    {                                           
                                                                    //if all anything ok send to server all feilds and updete.
                        string dataUpdated = ConnectWithServer.callToServer(controller, "editDetailsPersonById#", loggedUser.UserId +
                      "#" + txtBoxFname.Text + '#' + txtBoxLname.Text +'#'+textBoxEmail.Text + '#' + textBoxPhone.Text
                      + '#' + textBoxDateBorn.Text+"#");


                        if (bool.Parse(dataUpdated))
                        {
                            MessageBox.Show("updated!!");
                            BtnSaveDatlis.Visible = false; txtBoxFname.Visible = false; txtBoxLname.Visible = false; textBoxPhone.Visible = false;
                            textBoxEmail.Visible = false; textBoxDateBorn.Visible = false; BtnSaveDatlis.Visible = false;
                            picBoxEditDatlis.Visible = true;
                            MyAccount_Load(sender, e);
                        }
                        else MessageBox.Show("Oops something went wrong...");

                    }


                }
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
            if(nameIsProper(txtBoxFname.Text)&& txtBoxFname.Visible)
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

            if (isEmail(textBoxEmail.Text) && textBoxEmail.Visible)
            {
                picBoxEmailVOn.Visible = true;
            }
            else
            {
                picBoxEmailVOn.Visible = false;
            }
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

            if (phoneIsProper(textBoxPhone.Text) && textBoxPhone.Visible)
            {
                picBoxPhoneVOn.Visible = true;
            }
            else
            {
                picBoxPhoneVOn.Visible = false;
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


    }
}
