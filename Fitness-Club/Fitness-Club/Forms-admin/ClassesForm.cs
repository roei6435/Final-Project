using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Fitness_Club.Forms_admin
{
    public partial class ClassesForm : Form
    {
        public static string controller = "MengementClasses#";
        private List <Classes> listC;  
        private List <Person> listP;
        private Classes classSelected;
        private int indicator = 0;
        private int jump = 4;
        public ClassesForm(List <Person> listP)
        {
            this.listP = listP;
            InitializeComponent();
        }
        private void loadTheme()
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

        private void Classes_Load(object sender, EventArgs e)
        {
            loadTheme();

            //GET FROM SERVER ALL DATA ABOUT CLASSES AND CONVERTING TO LIST OF CLASSES.
            string response = ConnectWithServer.callToServer(controller, "getAllDataClasses#", "");   
            listC = ConnectWithServer.ConvartDataToListOfClasses(response, listP);

            //MATCH ALL NAMES FOR COMBOBOX
            foreach (Classes c in listC)
            {
                comboBoxNameClasses.Items.Add(c.NameClass);                
            }

            //PUT APPROPRIATE DATA INTO THE FIRST CLASS IN THE LIST
            classSelected = listC[0];
            comboBoxNameClasses.Text = classSelected.NameClass;
            putDataOfClassInFeilds(classSelected);
            fatchAndPutTheReviewsDataByClassId(classSelected.ClassId);
            panelCavarPicClass.Visible = true;panelFriends.Visible = true;panelEditor.Visible = true;panelAbout.Visible=true;    
          
        }
        private void fatchAndPutTheReviewsDataByClassId(string classId)
        {
           
            displayDataListFriends(indicator, jump, classSelected.ArrayRegisteredUsersThisClass);

            //GET ALL DATA FOR  THE CLASS UNIQE ABOUT REVIEWS 
            string fullDataReviews = ConnectWithServer.callToServer(controller, "getAllReviewsByIdClass#", classId);
            if (fullDataReviews != string.Empty)
            {
                panalTitleRaiting.Visible = true; panelReviewsEmpty.Visible = false;
                List<Reviews> listR = ConnectWithServer.convartDataToListOfReviews(fullDataReviews, listP, classSelected);

     
                getAllDataAboutRating(listR);

                //IF MORE 3, GET LIST WITH ONLAY 3 MUST LASTED REVIEWS 
                if (listR.Count > 3)
                    displayDataReviews(0, 3, getTheLastThreeReviews(listR));
                else
                    displayDataReviews(0,3, listR);

            }
            else
            {
                panalTitleRaiting.Visible = false; panelReviewsEmpty.Visible = true;
                DataGridReview.Rows.Clear();
            }
        }

        private void getAllDataAboutRating(List <Reviews> list)
        {

            //CALCULATE AVERAGE RATING (NUMBUR)
            float sum = 0;
            foreach (Reviews review in list)
            {
                sum += float.Parse(review.Rating);
            }

            //PUT DATA IN TITLE
            lblReviewRaiting.Text = $"Average rating by friends of a {classSelected.NameClass} class";
            lblAvgRaiting.Text = (sum / list.Count).ToString("0.#");
            string raiting = ((int)(sum / list.Count) + "");     
            
            //HOW MATCH STAR DISPLAY
            switch (raiting)
            {
                case "1":
                    star1.Visible = true; star2.Visible = false;
                    star3.Visible = false; star4.Visible = false;
                    star5.Visible = false; break;
                case "2":
                    star1.Visible = true; star5.Visible = false;
                    star2.Visible = true; star3.Visible = false;
                    star4.Visible = false; ; break;
                case "3":
                    star1.Visible = true; star2.Visible = true;
                    star3.Visible = true; star4.Visible = false;
                    star5.Visible = false; ; break;
                case "4":
                    star1.Visible = true; star2.Visible = true;
                    star3.Visible = true; star4.Visible = true;
                    star5.Visible = false; break;
                default:
                    star1.Visible = true; star2.Visible = true;
                    star3.Visible = true; star4.Visible = true;
                    star5.Visible = true; break;

            }
        }


        //GETS A LIST OF REVIEWS, RETURNS A LIST OF LAST 3 REVIEWS
        private List<Reviews> getTheLastThreeReviews(List<Reviews> list)  
        {
            List<Reviews> top3 = new List<Reviews>();
            var today = DateTime.Now;
           
            while (top3.Count < 3)
            {
                int maxDiffrence = (today - list[0].Date).Days; Reviews r = list[0];
                foreach (Reviews review in list)
                {                      
                    if ((today - review.Date).Days < maxDiffrence)
                    {
                        maxDiffrence = (today - review.Date).Days;
                        r = review;
                    }
                }
                list.Remove(r);
                top3.Add(r);
            }
            return top3;    
        }
        private Classes findClassByName(string name)
        {
            foreach(Classes c in listC)
            {
                if(c.NameClass.Equals(name))
                    return c;
            }
            return null;
        }

        private void putDataOfClassInFeilds(Classes c)
        {
           
            panelCavarPicClass.BackgroundImage = c.Pic;
            lblFullName.Text = c.NameClass;
            comboBoxNameClasses.Text = c.NameClass;
            textBoxName.Text= c.NameClass;
            txtBoxPos.Text = c.Place;
            lblPosition.Text = c.Place;
            SwitchActive.Checked = c.Activity;
            lblFullAboutData.Text = c.About;   
            textBoxAbout.Text = c.About;
            lblId.Text = c.ClassId;

            if (c.Activity)
            {
                lblActivity.Text = "Activity class";
                ActivePic.Visible = true;
            }
            else
            {
                lblActivity.Text = "Inactive class";
                ActivePic.Visible = false;
            }
            if (c.ArrayRegisteredUsersThisClass != null)
            {
                lblFriends.Text = "Friends  " + c.ArrayRegisteredUsersThisClass.Length;
                if (c.ArrayRegisteredUsersThisClass.Length == 1)
                {
                    lblCountFriends.Text = $"One friend.";
                    profilePic2.Visible = false; profilePic1.Visible = true;
                    profilePic1.Image = c.ArrayRegisteredUsersThisClass[0].ProfilePic;
                }
                else
                {
                    if (c.ArrayRegisteredUsersThisClass.Length == 2)
                        lblCountFriends.Text = $"Two friends.";
                    else
                        lblCountFriends.Text = $"And {c.ArrayRegisteredUsersThisClass.Length - 2} more friends";
                    profilePic2.Visible = true; profilePic1.Visible = true;
                    profilePic1.Image = c.ArrayRegisteredUsersThisClass[0].ProfilePic;
                    profilePic2.Image = c.ArrayRegisteredUsersThisClass[1].ProfilePic;
                }
            }
            else
            {
                lblFriends.Text = "Friends  0";
                lblCountFriends.Text = "";
                profilePic1.Visible = false; profilePic2.Visible = false;
            }

        }



        //DISPLAY DATA, REVIWS AND LIST FRIENDS
        private void displayDataReviews(int now, int jump, List<Reviews> listR)
        {

            DataGridReview.Rows.Clear();
            try
            {
                for (int i = now; i < jump; i++)
                {

                    string dateComm = LoginANDRegister.lastConnectDiff(listR[i].Date + "");
                    if (dateComm == "Active now")
                        dateComm = "Just now";
                    DataGridReview.Rows.Add(
                         Clients.ClipToCircle(listR[i].User.ProfilePic, new PointF(listR[i].User.ProfilePic.Width / 2, listR[i].User.ProfilePic.Height / 2), listR[i].User.ProfilePic.Width / 2, Color.FromArgb(51, 51, 76)),
                     listR[i].User.FirstName, listR[i].ReviewContent + " " + dateComm, listR[i].IdReviews);
                }
            }
            catch
            {

            }
        }
        private void displayDataListFriends(int now, int jump, Person[] arrP)
        {
            ListFriendsOfClassView.Rows.Clear();
            if (arrP != null)
            {
                try
                {

                    for (int i = now; i < now + jump; i++)
                    {

                        string lastConn = LoginANDRegister.lastConnectDiff(arrP[i].LastConnect);
                        Image statusUserAvctive = Clients.getActiveStatusPicture(lastConn);
                        ListFriendsOfClassView.Rows.Add(
                             Clients.ClipToCircle(arrP[i].ProfilePic, new PointF(arrP[i].ProfilePic.Width / 2, arrP[i].ProfilePic.Height / 2), arrP[i].ProfilePic.Width / 2, Color.FromArgb(51, 51, 76)),
                         statusUserAvctive, arrP[i].FirstName + " " + arrP[i].LastName, lastConn);

                    }
                }
                catch
                {
                    btnNext.Visible = false;
                }
            }
            else
            {
                panelNotFriends.Visible = true; btnPrev.Visible = false; btnNext.Visible = false;
            }

        }

        //SELECT REVIEW AND DELETE
        private void DataGridReview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DataGridReview.SelectedRows)
            {
                string idReview = row.Cells[3].Value.ToString();
                if (MessageBox.Show("You want delete this review?", "Delete Review", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string reviewDeleted = ConnectWithServer.callToServer(controller, "deleteReviewById#", idReview);
                    if (bool.Parse(reviewDeleted))
                    {
                        DataGridReview.Rows.Remove(row);
                    }
                    else
                    {
                        MessageBox.Show("Opps, somthing worng");
                    }
                }

            }
        }

        //UPDATE CLASS
        private void BtnSaveDatlis_Click(object sender, EventArgs e)
        {

            //if user make any chenge
            if (panelCavarPicClass.BackgroundImage != classSelected.Pic ||
                textBoxAbout.Text != classSelected.About || textBoxName.Text != classSelected.NameClass ||
                txtBoxPos.Text != classSelected.Place || SwitchActive.Checked != classSelected.Activity)
            {

                //if all feilds is proper and not empty
                if (Regex.IsMatch(textBoxName.Text, @"^[a-zA-Z ]+$") && textBoxAbout.Text != string.Empty &&
                     textBoxAbout.Text != string.Empty && txtBoxPos.Text != string.Empty)
                {
                    string datlisUpdate = ConnectWithServer.callToServer(controller, "editDatilsClass#", lblId.Text + "#" + textBoxName.Text + "#" +
                      txtBoxPos.Text + "#" + SwitchActive.Checked + "#" + textBoxAbout.Text);
                    bool picUpdated = true;
                    if (panelCavarPicClass.BackgroundImage != classSelected.Pic)
                    {
                        string command = "UPDATE classes SET pic = @image WHERE classId=@id";
                        picUpdated = ConnectWithServer.updatePic(panelCavarPicClass.BackgroundImage, lblId.Text, command);
                    }
                    if (bool.Parse(datlisUpdate) && picUpdated)
                    {
                        MessageBox.Show("Updating the class details has been completed successfully.");
                        comboBoxNameClasses.Items.Clear();
                        lblLengthOfAbout.Visible = false;
                        Classes_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Opps, somthing worng.");
                }
                else
                {
                    MessageBox.Show("Name not proprty, Try again.");
                }
            }
            else
            {
                panelEditData.Visible = false;
                textBoxAbout.Visible = false;
                lblLengthOfAbout.Visible = false;
            }



        }

        private void comboBoxNameClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

            classSelected = findClassByName(comboBoxNameClasses.SelectedItem.ToString());
            if (classSelected != null)
            {
                panelEditData.Visible = false;
                textBoxAbout.Visible = false; panelNotFriends.Visible = false; btnPrev.Visible = false;

                putDataOfClassInFeilds(classSelected);
                indicator = 0;
                if (classSelected.ArrayRegisteredUsersThisClass != null && jump < classSelected.ArrayRegisteredUsersThisClass.Length)
                {
                    btnNext.Visible = true;
                }

                fatchAndPutTheReviewsDataByClassId(classSelected.ClassId);

            }
        }

        private void textBoxAbout_TextChanged(object sender, EventArgs e)
        {
            lblLengthOfAbout.Text = $"{textBoxAbout.Text.Length}/{textBoxAbout.MaxLength}";
        }

        private void lblEditImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.FileName = "";
            od.Filter = "Supported Imeges|*.jpg;*.png";
            if (od.ShowDialog() == DialogResult.OK)
            {
                PictureBox PictureBox1 = new PictureBox();
                PictureBox1.Load(od.FileName);
                panelCavarPicClass.BackgroundImage = PictureBox1.Image; 
            }
        }
        private void picBoxEditPicPropfile_Click_1(object sender, EventArgs e)
        {
            if (!panelEditData.Visible)
            {
                panelEditData.Visible = true;
                textBoxAbout.Visible = true;
                lblLengthOfAbout.Visible = true;
            }
            else
            {
                panelEditData.Visible = false;
                textBoxAbout.Visible = false;
                lblLengthOfAbout.Visible = false;
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrev.Visible = true;
            if (indicator + jump < listP.Count)
            {
                indicator += jump;
                displayDataListFriends(indicator, jump,classSelected.ArrayRegisteredUsersThisClass);

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Visible = true;
            if (indicator - jump >= 0)
            {

                indicator -= jump;
                displayDataListFriends(indicator, jump, classSelected.ArrayRegisteredUsersThisClass);

            }
            else
            {
                btnPrev.Visible = false;
            }
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel(lblAbout, panelAbout);
            AdminScreen.inactivePanel(lblEditor, panelEditor);
            AdminScreen.inactivePanel(lblFriends, panelFriends);
            panelDataAbout.Visible = true;
            panelListFriends.Visible = false;
            panelReviews.Visible = false;
        }

        private void lblFriends_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel(lblFriends, panelFriends);
            AdminScreen.inactivePanel(lblEditor, panelEditor);
            AdminScreen.inactivePanel(lblAbout, panelAbout);
            panelListFriends.Visible = true; panelListFriends.Location = new Point(74, 346);
            panelDataAbout.Visible = false;
            panelReviews.Visible = false;

        }

        private void lblEditor_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel(lblEditor, panelEditor);
            AdminScreen.inactivePanel(lblAbout, panelAbout);
            AdminScreen.inactivePanel(lblFriends, panelFriends);
            panelDataAbout.Visible = false;
            panelListFriends.Visible = false;
            panelReviews.Visible = true; panelReviews.Location = new Point(74, 346);

        }


    }
}
