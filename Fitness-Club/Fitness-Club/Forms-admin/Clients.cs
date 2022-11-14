using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club
{
    public partial class Clients : Form
    {
        public static string controller = "MengementUsers#";
        private List<Person> listP;
        private int indicator=0;
        private int jump = 8;

        public Clients()
        {
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
        public Image ClipToCircle(Image srcImage, PointF center, float radius, Color backGround)
        {
            Image dstImage = new Bitmap(srcImage.Width, srcImage.Height, srcImage.PixelFormat);

            using (Graphics g = Graphics.FromImage(dstImage))
            {
                RectangleF r = new RectangleF(center.X - radius, center.Y - radius,
                                                         radius * 2, radius * 2);

                // enables smoothing of the edge of the circle (less pixelated)
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // fills background color
                using (Brush br = new SolidBrush(backGround))
                {
                    g.FillRectangle(br, 0, 0, dstImage.Width, dstImage.Height);
                }

                // adds the new ellipse & draws the image again 
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(r);
                g.SetClip(path);
                g.DrawImage(srcImage, 0, 0);

                return dstImage;
            }
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            string responseFromServer = ConnectWithServer.callToServer(AdminScreen.controller, "getAllDataForAdminScreenInDahsboard#", "");
            listP = ConnectWithServer.ConvartDataToListOfPersons(responseFromServer);
            displayData(indicator, jump);
            loadTheme();
            
        }
        private Image getActiveStatusPicture(string lastConn)
        {
            Image nonActive = (Image)(new Bitmap(Properties.Resources.nonActive, 13, 13));
            Image active = (Image)(new Bitmap(Properties.Resources.active, 13, 13));
            if (lastConn == "Active now")
                return active;
            return nonActive;
        }


        private void displayData(int now,int jump)
        {
            
            DataUsersView.Rows.Clear();
            try
            {

                for (int i = now; i < now + jump; i++)
                {
                   
                    string lastConn = lastConnectDiff(listP[i].LastConnect);
                    Image statusUserAvctive= getActiveStatusPicture(lastConn);
                    DataUsersView.Rows.Add(
                         ClipToCircle(listP[i].ProfilePic, new PointF(listP[i].ProfilePic.Width / 2, listP[i].ProfilePic.Height / 2), listP[i].ProfilePic.Width / 2, Color.FromArgb(51, 51, 76)),
                         statusUserAvctive, listP[i].FirstName + " " + listP[i].LastName, listP[i].UserId, lastConn
                           );
                }
            }
            catch
            {
                btnNext.Visible = false;
            }               
        }
        private void sharchAlguritem()
        {
            
            if (textBoxFind.Text != "")
            {
                string str = uppercaseFirstLetter(textBoxFind.Text);
                DataUsersView.Rows.Clear();
                for (int i = 0; i < listP.Count; i++)
                {                 
                    string lastConn = lastConnectDiff(listP[i].LastConnect);
                    Image statusUserAvctive = getActiveStatusPicture(lastConn);
                    string fullName = listP[i].FirstName + " " + listP[i].LastName;
                    if (fullName.Contains(str))
                    {
                        DataUsersView.Rows.Add(
                        ClipToCircle(listP[i].ProfilePic, new PointF(listP[i].ProfilePic.Width / 2, listP[i].ProfilePic.Height / 2), listP[i].ProfilePic.Width / 2, Color.FromArgb(51, 51, 76)),
                        statusUserAvctive, listP[i].FirstName + " " + listP[i].LastName, listP[i].UserId, lastConnectDiff(listP[i].LastConnect)
                        );
                    }
                }
                btnPrev.Visible = false;
                btnNext.Visible = false;
            }
            else
            {
                btnPrev.Visible = true;
                btnNext.Visible = true;
                indicator = 0;
                displayData(indicator, jump);
            }
        }

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
                    if (diffOfDates.Days > 6)
                        return "1w";
                    return diffOfDates.Days + "d";
                }

            }
            return "";

        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            btnPrev.Visible = true;
            if (indicator + jump < listP.Count)
            {
                indicator += jump;
                displayData(indicator, jump);

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Visible = true;
            if (indicator - jump >= 0)
            {

                indicator -= jump;
                displayData(indicator, jump);

            }
            else
            {
                btnPrev.Visible = false;
            }

        }



        private void dataEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DataUsersView.SelectedRows)
            {
                
                panelSTAM.Visible = true;
                panelAllPerons.Visible = false;
                panelUserData.Visible = true;
                btnSendMess.BackColor=btnNext.BackColor;
                PersonList PL = new PersonList(listP);
                Person person=PL.findPersonById((row.Cells[3].Value).ToString());
                btnBloked.Tag = person.UserId;
                lblFullName.Text = person.FirstName + " " + person.LastName;
                lblDateBornAndAge.Text = person.DateBorn + ", " + PersonList.GetAge(person.DateBorn).ToString("0");
                lblEmail.Text=person.Email; 
                lblPhone.Text=person.Phone;
                profilePic.Image = person.ProfilePic;
                if (!person.IsBlocked)
                {
                    isBlockStatus.Visible = false;
                    btnBloked.Text = "Blocked now";
                    btnBloked.Image = Properties.Resources._9110980_circle_block_icon;
                }
                else
                {
                    isBlockStatus.Visible = true;
                    btnBloked.Text = "Unblock now";
                    btnBloked.Image = Properties.Resources.unlock_icon;
                }               
               
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelSTAM.Visible = false;
            panelUserData.Visible = false;
            panelAllPerons.Visible = true;

        }

        private void btnBloked_Click(object sender, EventArgs e)
        {
            string userIsBlock = "", userIdSelected =btnBloked.Tag.ToString();
            if (btnBloked.Text == "Blocked")
                userIsBlock = "true";       //לא חוסום
            else
                userIsBlock = "false";       //חסום

          string isUpdate=ConnectWithServer.callToServer(controller, "blockOrUnblockUser#", userIdSelected + "#"+ userIsBlock + "#");
            if (bool.Parse(isUpdate))
            {                
                if(userIsBlock == "true")
                {
                    MessageBox.Show("User blocked now.");
                    isBlockStatus.Visible = true;
                    btnBloked.Text = "Unblock";
                    btnBloked.Image = Properties.Resources.unlock_icon;
                }
                else
                {
                    MessageBox.Show("User unblocked now.");
                    isBlockStatus.Visible = false;
                    btnBloked.Text = "Blocked";
                    btnBloked.Image = Properties.Resources._9110980_circle_block_icon;
                }
                Clients_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Somthing worng...");
            }
                
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
        

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
           
            sharchAlguritem();
            if(DataUsersView.RowCount==0)
                panelNotFound.Visible = true;
            else
                panelNotFound.Visible = false;
        }

        private void btnSendMess_Click(object sender, EventArgs e)
        {
          //  panelSendMail.Visible = true;
        }
    }
}
