using System;
using System.Collections.Generic;

using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using System.Windows.Threading;
using System.Drawing.Drawing2D;


namespace Fitness_Club
{
    public partial class AdminScreen : Form
    {

        private Button currentButton;
        private Random random;
        private int tmp;
        private Form activeForm;
        private bool sideBarExpand=false;
        private bool DataAnalysisCollapse = true;
        public static string static_userId;
        public static string controller = "Dashboard#";
        public static Person userLogged = null;
        private List<Person> listP = null;
        private List<Person> listUsers = null;
        private List<Person> listAdmins = null;
        private List<Classes> listC;
        public string data = null;
        public int tenSecound = 5;
        private DispatcherTimer dispatcherTimer;
        private bool firstLoad = true;

        public AdminScreen(string userId)
        {
            if (firstLoad)
            {
                DispatcherTimer dispatcherTimer = new DispatcherTimer();
                dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
                dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
                dispatcherTimer.Start();
            }
            static_userId = userId; 
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
 
        }



        private void AdminScreen_Load(object sender, EventArgs e)
        {

            btnAddUser.BackColor = panelTitle.BackColor;
            dispatcherTimer = new DispatcherTimer();                //CREATE TIMER
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);

            string responseFromServer = ConnectWithServer.callToServer(controller, "getAllDataAboutPersonsInSystem#", "");

            listP = ConnectWithServer.ConvartDataToListOfPersons(responseFromServer);



            responseFromServer = ConnectWithServer.callToServer(controller, "getAllDataClasses#", "");
            listC = ConnectWithServer.ConvartDataToListOfClasses(responseFromServer, listP);

            PersonList PL = new PersonList(listP);
            listUsers = PL.getOnlyUsersOrAdminsFromListPerson("users");
            listAdmins = PL.getOnlyUsersOrAdminsFromListPerson("admins");

            listUsers = ConnectWithServer.addArraysClassesAndPaymentsToPersonList(listUsers, listC);


            userLogged = getLoggedUserNowByPersonId(static_userId, listAdmins,true);
            lblTitleWellcome.Text = $"Wellcome {userLogged.FirstName}!";
            try
            {
                pictureInidcation.Image = Properties.Resources._8401;
            }
            catch
            {

                pictureInidcation.Image = Properties.Resources.testD2;
            }


            dispatcherTimer.Start();
        }
        //------------------------------------------------------------------------------------------------------------------------------

        //manu intarective functiouns



        //mouse moving functions

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); //send position window

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)             //moving from panel title
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------


        //manu activity functions


        private Color SelectThemeColor()          //function return color theme
        {
            int index = random.Next(ThemColor.ColorList.Count);  //next in list
            while (tmp == index)      //if color has alredy,again choose.
            {
                index = random.Next(ThemColor.ColorList.Count);
            }
            tmp = index;            //tmp get index color in list
            string color = ThemColor.ColorList[index];  //the color from list-string
            return ColorTranslator.FromHtml(color);       //return color with class colorTranslator.

        }

        private void ActiveButton(object btnSender)             //Activity button
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)           //if currrent button is not button gettin in function
                {
                    DisableButton();
                    Color color = SelectThemeColor();                  //get color from function(from list)
                    currentButton = (Button)btnSender;       //set current button
                    currentButton.BackColor = color;                  //change backcolor,font.
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                    panelTitle.BackColor = color; btnMinimize.BackColor = color;
                    panelSearch.FillColor = color; panelSearch.FillColor2 = color; panelSearch.FillColor3 = color; panelSearch.FillColor4 = color;
                    picBoxSharch.BackColor = color;
                    panelNotFound.FillColor = color; panelNotFound.FillColor2 = color; panelNotFound.FillColor3 = color; panelNotFound.FillColor4 = color;
                    textBoxFind.BackColor = color; DataViewPersons.BackgroundColor = color;
                    DataViewPersons.AlternatingRowsDefaultCellStyle.BackColor = color;
                    DataViewPersons.RowsDefaultCellStyle.BackColor = color;
                    DataViewPersons.ColumnHeadersDefaultCellStyle.BackColor = color;
                    DataViewPersons.DefaultCellStyle.BackColor = color;
                    DataViewPersons.RowHeadersDefaultCellStyle.BackColor = color;
                    DataViewPersons.DefaultCellStyle.BackColor = color;
                    btnAddUser.BackColor = color;
                    panelLogo.BackColor = ThemColor.ChangeColorBrightness(color, -0.3f);
                    ThemColor.primaryColor = color;
                    ThemColor.secondColor = ThemColor.ChangeColorBrightness(color, -0.3f);

                }
            }
        }

        private void DisableButton()                            //nonActivity button
        {
            foreach (Control prvBtn in panelManu.Controls)
            {
                if (prvBtn.GetType() == typeof(Button))        //if btn prv is button
                {
                    prvBtn.BackColor = Color.FromArgb(51, 51, 76);
                    prvBtn.ForeColor = Color.Gainsboro;
                    prvBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                }
            }
        }

        protected virtual void openChildForm(Form childFrom, object btnSender)       //open child form in manu screen
        {
            if (activeForm != null)
                activeForm.Close();
            ActiveButton(btnSender);                                     //apply function activity button
            activeForm = childFrom;                                         //set activity
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;             //chenge ralevante proprty for form
            childFrom.Dock = DockStyle.Fill;
            this.penelHome.Controls.Add(childFrom);
            this.penelHome.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
            //lblTitle.Text = childFrom.Text;                         //change title 


        }


        private void Reset()                              //back to start mode
        {

            DisableButton();
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            Color color = Color.FromArgb(51, 51, 76);
            panelTitle.BackColor = color;
            panelSearch.FillColor = color; panelSearch.FillColor2 = color; panelSearch.FillColor3 = color; panelSearch.FillColor4 = color;
            picBoxSharch.BackColor = color;
            panelNotFound.FillColor = color; panelNotFound.FillColor2 = color; panelNotFound.FillColor3 = color; panelNotFound.FillColor4 = color;
            textBoxFind.BackColor = color; DataViewPersons.BackgroundColor = color;
            DataViewPersons.AlternatingRowsDefaultCellStyle.BackColor = color;
            DataViewPersons.RowsDefaultCellStyle.BackColor = color;
            DataViewPersons.ColumnHeadersDefaultCellStyle.BackColor = color;
            DataViewPersons.DefaultCellStyle.BackColor = color;
            DataViewPersons.RowHeadersDefaultCellStyle.BackColor = color;
            DataViewPersons.DefaultCellStyle.BackColor = color;
            currentButton = null;
            openChildForm(new Forms_admin.Feed(listAdmins), btnSenderObject);

        }

        private void btnClose_Click(object sender, EventArgs e)                 //close
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)           //minimize
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------



        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------

        //slide menu functions

        private void timerSideMenu_Tick(object sender, EventArgs e)       //open/close Main Menu
        {
            if (sideBarExpand)
            {

                panelManu.Width -= 10;
                btnSideManu.Image = Fitness_Club.Properties.Resources.manu2;

                if (panelManu.Width == panelManu.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    timerSideManu.Stop();
                }
            }
            else
            {


                panelManu.Width += 10;
                btnSideManu.Image = Fitness_Club.Properties.Resources.previous_arrow;
                if (panelManu.Width == panelManu.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timerSideManu.Stop();
                }
            }
        }

        private void MembersTimer_Tick(object sender, EventArgs e)
        {
            if (DataAnalysisCollapse)
            {

                membersContiener.Height += 10;
                btnAreaClasses.Location = new Point(-4, 558);
                btnAbout.Location = new Point(-1, 632);
                btnDataAnalysis.Text = "     Data analysis ▲";
                if (membersContiener.Height == membersContiener.MaximumSize.Height)
                {
                    DataAnalysisCollapse = false;
                    MembersTimer.Stop();
                }
            }
            else
            {
                btnClassesStat.BackColor = Color.FromArgb(34, 36, 49);
                btnClientsStat.BackColor = Color.FromArgb(34, 36, 49);
                btnAdminStatistics.BackColor = Color.FromArgb(34, 36, 49);
                btnAreaClasses.Location = new Point(-4, 343);
                btnAbout.Location = new Point(-1, 420);
                membersContiener.Height -= 10;
                btnDataAnalysis.Text = "     Data analysis ▼";
                if (membersContiener.Height == membersContiener.MinimumSize.Height)
                {
                    DataAnalysisCollapse = true;
                    MembersTimer.Stop();
                }
            }
        }    //open/close mengment members menu

        //buttons options


        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            if (btnDataAnalysis.BackColor != Color.FromArgb(51, 51, 76))
            {
                MembersTimer.Start();
                timerSideManu.Start();
                Color color = Color.FromArgb(51, 51, 76);
                btnDataAnalysis.BackColor = color;

            }
            AdminScreen_Load(sender, e);
            Reset();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            openChildForm(new Rregistration(), sender);
        }
        private void btnSideManu_Click(object sender, EventArgs e)              //open/close side menu
        {
            timerSideManu.Start();
        }

        private void btnMyAcc_Click(object sender, EventArgs e)
        {
            if (!DataAnalysisCollapse)
            {
                MembersTimer.Start();
                btnDataAnalysis.BackColor = btnSideManu.BackColor;
                openChildForm(new MyAccount(userLogged), sender);
            }
            else
                openChildForm(new MyAccount(userLogged), sender);

        }

        private void btnCalandar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataAnalysisCollapse)
                {
                    MembersTimer.Start();
                    btnDataAnalysis.BackColor = btnSideManu.BackColor;
                    openChildForm(new Calandar(), sender);
                }
                else
                    openChildForm(new Calandar(), sender);
            }
            catch
            {
                openChildForm(new Error(), sender);
            }

        }

        private void btnUserMengement_Click(object sender, EventArgs e)
        {

            if (btnDataAnalysis.BackColor == Color.FromArgb(51, 51, 76))
            {
                ActiveButton(btnAdminStatistics);
                openChildForm(new AdminsStaticts(listAdmins), sender);
                MembersTimer.Start();
            }
            if (!sideBarExpand)
            {
                panelManu.Width = panelManu.MaximumSize.Width;
                sideBarExpand = true;
            }
        }

        private void btnAdminStatistics_Click(object sender, EventArgs e)
        {
            if (btnAdminStatistics.BackColor == Color.FromArgb(34, 36, 49))
            {
                openChildForm(new AdminsStaticts(listAdmins), sender);
                btnClientsStat.BackColor = Color.FromArgb(34, 36, 49);
                btnClassesStat.BackColor = Color.FromArgb(34, 36, 49);

            }
        }

        private void btnClientsStat_Click(object sender, EventArgs e)
        {
            if (btnClientsStat.BackColor == Color.FromArgb(34, 36, 49))
            {
                openChildForm(new ClientsStatistics(listUsers), sender);
                btnAdminStatistics.BackColor = Color.FromArgb(34, 36, 49);
                btnClassesStat.BackColor = Color.FromArgb(34, 36, 49);

            }
        }

        private void btnClassesStat_Click(object sender, EventArgs e)
        {
            if (btnClassesStat.BackColor == Color.FromArgb(34, 36, 49))
            {
                openChildForm(new ClassesStatistics(listC, listUsers), sender);
                btnClientsStat.BackColor = Color.FromArgb(34, 36, 49);
                btnAdminStatistics.BackColor = Color.FromArgb(34, 36, 49);
            }
        }

        private void btnAreaClasses_Click(object sender, EventArgs e)
        {
            if (!DataAnalysisCollapse)
            {
                MembersTimer.Start();
                btnDataAnalysis.BackColor = btnSideManu.BackColor;
                openChildForm(new Forms_admin.AreaClasses(listP, listC), sender);
            }
            else
                openChildForm(new Forms_admin.AreaClasses(listP, listC), sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (!DataAnalysisCollapse)
            {
                MembersTimer.Start();
                btnDataAnalysis.BackColor = btnSideManu.BackColor;
                openChildForm(new About(), sender);
            }
            else
                openChildForm(new About(), sender);
        }
        //------------------------------------------------------------------------------------------------------------------------------

        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                if (tenSecound > 0)
                {
                    //TIMER WORK
                    tenSecound--;
                    int minutes = tenSecound / 60, sec = tenSecound - (minutes * 60);
                    float percent = ((minutes * 60 + sec) / 300f) * 100;
                    circleTimer.Value = Convert.ToInt32(percent);
                }
                else
                {                          //RESET TIMER
                                           //tenSecound = 10;
                    firstLoad = false;
                    openChildForm(new Forms_admin.Feed(listAdmins), btnSenderObject);
                    dispatcherTimer.Stop();
                }
            }


        }


        //getDataPersonLoggedNow
        private Person getLoggedUserNowByPersonId(string id, List<Person> listP,bool flag)
        {

            PersonList PL = new PersonList(listP);
            Person loggedUser = PL.findPersonById(id);
            if (flag)
            {
                if (loggedUser.IsAdmin)
                    lblUserNameAndStatus.Text = loggedUser.FirstName + " " + loggedUser.LastName + "\n" + "administrator.";
                profilePic.Image = loggedUser.ProfilePic;
            }
            return loggedUser;
        }




        ///================================================================================================

        ///================================================================================================
        ///TXT BOX SEARCH FUNCTIONS

        private void SearchAlguritem()
        {

            if (textBoxFind.Text != "")
            {
                string str = LoginANDRegister.uppercaseFirstLetter(textBoxFind.Text);
                DataViewPersons.Rows.Clear();
                for (int i = 0; i < listUsers.Count; i++)
                {
                    string lastConn = LoginANDRegister.lastConnectDiff(listUsers[i].LastConnect);
                    string fullName = listUsers[i].FullName;
                    if (fullName.Contains(str))
                    {
                        DataViewPersons.Rows.Add(
                        clipToCircle(listUsers[i].ProfilePic, new PointF(listUsers[i].ProfilePic.Width / 2, listUsers[i].ProfilePic.Height / 2), listUsers[i].ProfilePic.Width / 2, panelTitle.BackColor),
                         listUsers[i].FirstName + " " + listUsers[i].LastName+"       ", listUsers[i].UserId, LoginANDRegister.lastConnectDiff(listUsers[i].LastConnect)
                        );
                    }
                }
            }
        }
        public static Image clipToCircle(Image srcImage, PointF center, float radius, Color backGround)
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

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            if (panelSearch.Height == 62)
            {
                panelSearch.Height = 490;
                panelSearch.BorderThickness = 1;
            }
            else
            {
                if (textBoxFind.Text == string.Empty)
                {
                    panelSearch.Height = 62;
                    panelSearch.BorderThickness = 0;
                }

            }
            SearchAlguritem();
            if (DataViewPersons.RowCount == 0)
                panelNotFound.Visible = true;
            else
                panelNotFound.Visible = false;
        }

        private void DataViewPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DataViewPersons.SelectedRows)
            {

                string userId = row.Cells[2].Value.ToString();
                openChildForm(new Clients(listUsers,listC,userId), btnSenderObject);

            }
        }

        private void textBoxFind_Click(object sender, EventArgs e)
        {
            if(textBoxFind.Text == "Search")
            {
                textBoxFind.Text = "";
            }
        }

    }












}
