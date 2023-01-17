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
        private List<Classes> listC;
        private PersonList PL;
        private int indicator=0;
        private int jump = 8;
        private Person personSelected=null;
        private bool needRefresh = false;
        private string idUser;

        public Clients(List<Person>listP,List<Classes>listC,string idUser)
        {
            this.idUser = idUser;
            this.listP = listP;
            this.listC = listC;
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
        public static Image ClipToCircle(Image srcImage, PointF center, float radius, Color backGround)
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
            if (needRefresh)
            {
                string responseFromServer = ConnectWithServer.callToServer(AdminScreen.controller, "getAllDataAboutPersonsInSystem#", "");
                listP = ConnectWithServer.ConvartDataToListOfPersons(responseFromServer);
            }
          //  displayDataListOfPayments(listP[0].PaymentsArray);
            PL = new PersonList(listP);
            displayDataListOfUser(indicator, jump);
            openProfilePanel(idUser);
            loadTheme();
            
        }
        public static Image getActiveStatusPicture(string lastConn)
        {
            Image nonActive = (Image)(new Bitmap(Properties.Resources.nonActive, 13, 13));
            Image active = (Image)(new Bitmap(Properties.Resources.active, 13, 13));
            if (lastConn == "Active now")
                return active;
            return nonActive;
        }
        private string getAvgOfClass(Reviews [] arr)
        {
            float sum = 0;
            foreach (Reviews review in arr)
            {
                sum += float.Parse(review.Rating);
            }
            return ((int)(sum / arr.Length) + "");
        }
        private void displayDataListOfClasses(Classes[] arr)
        {
            try
            {

                for (int i = 0; i < 5; i++)
                {
                    int friends = 0;
                    if (arr[i].ArrayRegisteredUsersThisClass != null)
                        friends = arr[i].ArrayRegisteredUsersThisClass.Length;
                    string raiting = "Not reviews...";
                    if (arr[i].ArrayReviews != null)
                    {
                        raiting = getAvgOfClass(arr[i].ArrayReviews) + " Stars";
                    }
                    DataGridViewClassMember.Rows.Add(
                               arr[i].NameClass,friends+ " Friends", raiting
                           ) ;
                }
            }
            catch
            {
               
            }
        }

        private void displayDataListOfPayments(Payments [] arr)
        {
            try
            {

                for (int i = 0; i < 5 ; i++)
                {

                    DataPaymentsView.Rows.Add(
                               arr[i].Date.ToShortDateString(),arr[i].Sum,arr[i].PaidVia,arr[i].ClassP.NameClass     
                           );
                }
            }
            catch
            {
               
            }
        }
        private void displayDataListOfUser(int now,int jump)
        {
            
            DataUsersView.Rows.Clear();
            try
            {

                for (int i = now; i < now + jump; i++)
                {
                   
                    string lastConn = LoginANDRegister.lastConnectDiff(listP[i].LastConnect);
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
        private void SearchAlguritem()
        {
            
            if (textBoxFind.Text != "")
            {
                string str = LoginANDRegister.uppercaseFirstLetter(textBoxFind.Text);
                DataUsersView.Rows.Clear();
                for (int i = 0; i < listP.Count; i++)
                {                 
                    string lastConn = LoginANDRegister.lastConnectDiff(listP[i].LastConnect);
                    Image statusUserAvctive = getActiveStatusPicture(lastConn);
                    string fullName = listP[i].FirstName + " " + listP[i].LastName;
                    if (fullName.Contains(str))
                    {
                        DataUsersView.Rows.Add(
                        ClipToCircle(listP[i].ProfilePic, new PointF(listP[i].ProfilePic.Width / 2, listP[i].ProfilePic.Height / 2), listP[i].ProfilePic.Width / 2, Color.FromArgb(51, 51, 76)),
                        statusUserAvctive, listP[i].FirstName + " " + listP[i].LastName, listP[i].UserId, LoginANDRegister.lastConnectDiff(listP[i].LastConnect)
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
                displayDataListOfUser(indicator, jump);
            }
        }

      
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            btnPrev.Visible = true;
            if (indicator + jump < listP.Count)
            {
                indicator += jump;
                displayDataListOfUser(indicator, jump);

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Visible = true;
            if (indicator - jump >= 0)
            {

                indicator -= jump;
                displayDataListOfUser(indicator, jump);

            }
            else
            {
                btnPrev.Visible = false;
            }

        }

        private void openProfilePanel(string userId)
        {
            DataPaymentsView.Rows.Clear();
            DataGridViewClassMember.Rows.Clear();
            panelAllPerons.Visible = false;
            panelUserData.Visible = true;
            btnSendMess.BackColor = btnNext.BackColor;
            personSelected = PL.findPersonById((userId).ToString());
            btnBloked.Tag = personSelected.UserId;
            lblFullName.Text = personSelected.FullName;
            lblFullName.Tag = personSelected.UserId;
            lblDateBornAndAge.Text = personSelected.DateBorn + ", " + PersonList.GetAge(personSelected.DateBorn).ToString("0");
            lblEmail.Text = personSelected.Email;
            lblPhone.Text = personSelected.Phone;
            profilePic.Image = personSelected.ProfilePic;
            if (!personSelected.IsBlocked)
            {
                isBlockStatus.Visible = false;
                btnBloked.Text = "Blocked";
                btnBloked.Image = Properties.Resources._9110980_circle_block_icon;
            }
            else
            {
                isBlockStatus.Visible = true;
                btnBloked.Text = "Unblock";
                btnBloked.Image = Properties.Resources.unlock_icon;
            }
            if (personSelected.PaymentsArray != null)
            {
                btnAddPaymentTwo.Visible = true;
                DataPaymentsView.Visible = true;
                displayDataListOfPayments(personSelected.PaymentsArray);
            }
            else
            {
                btnAddPaymentTwo.Visible = false;
                DataPaymentsView.Visible = false;
            }
            if (personSelected.ClassesArray != null)
            {
                displayDataListOfClasses(personSelected.ClassesArray);
                DataGridViewClassMember.Visible = true;
            }
            else
            {
                DataGridViewClassMember.Visible = false;
            }
        }

        private void dataEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DataUsersView.SelectedRows)
            {
                openProfilePanel(row.Cells[3].Value + "");           
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
          
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



        

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {

            SearchAlguritem();
            if(DataUsersView.RowCount==0)
                panelNotFound.Visible = true;
            else
                panelNotFound.Visible = false;
        }

        private void btnSendMess_Click(object sender, EventArgs e)
        {
        
        }

        private void lblPayments_Click(object sender, EventArgs e)
        {
            LoginANDRegister.activePanel(lblPayments, panelPayments);
            LoginANDRegister.inactivePanel(lblMemberOfClass, panelMember);
            panelLastPayments.Visible = true;
            panelMemberOfClass.Visible = false;
        }

        private void lblMemberOfClass_Click(object sender, EventArgs e)
        {
            LoginANDRegister.activePanel( lblMemberOfClass, panelMember);
            LoginANDRegister.inactivePanel(lblPayments, panelPayments);
            panelLastPayments.Visible = false;
            panelMemberOfClass.Visible = true;
        }


        private void btnAddPayment_Click_1(object sender, EventArgs e)
        {
            personSelected = PL.findPersonById(lblFullName.Tag + "");
            addPayment ap = new addPayment(personSelected);
            ap.FormClosed += addPayment_FormClosed;
            ap.Show();
        }

        private void btnAddPaymentTwo_Click(object sender, EventArgs e)
        {
            personSelected = PL.findPersonById(lblFullName.Tag+"");
            addPayment ap = new addPayment(personSelected);
            ap.FormClosed += addPayment_FormClosed;
            ap.Show();
        }
        private void addPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (bool.Parse(addPayment.paymentDone))
            {
                if(personSelected.PaymentsArray is null)
                {
                     btnAddPaymentTwo.Visible = true;
                    DataPaymentsView.Visible = true;
                   
                }              
                personSelected.PaymentsArray=ConnectWithServer.getPaymentsArrayByUserId(personSelected.UserId, listP, listC);
                DataPaymentsView.Rows.Clear();
                List<Payments>list=personSelected.PaymentsArray.ToList();
                list.Reverse();
                displayDataListOfPayments(list.ToArray());
                this.Refresh();
               
            }
        }
    }
}
