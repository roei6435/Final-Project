using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using ServiceStack;

namespace Fitness_Club
{
    public partial class AdminScreen : Form
    {

        private Button currentButton;
        private Random random;
        private int tmp;
        private Form activeForm;
        private bool sideBarExpand=false;
        private bool membersCollapse=true;
        public static string static_userId;
        public static string controller = "Dashboard#";
        private Person userLogged = null;
        private List<Person> listP = null;


        public AdminScreen(string userId)
        {
            static_userId = userId; 
            InitializeComponent();
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
 
        }
       


        //------------------------------------------------------------------------------------------------------------------------------
        //------------------------------------------------------------------------------------------------------------------------------



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

        public static void activePanel(Label lblActive, Panel panelActive)
        {
            lblActive.ForeColor = Color.DodgerBlue;
            lblActive.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
            panelActive.Height = 3;
            panelActive.BackColor = Color.DodgerBlue;
        }
        public static void inactivePanel(Label lblActive, Panel panelActive)
        {
            lblActive.ForeColor = Color.Gainsboro;
            lblActive.Font = new Font("Segoe UI", 14f, FontStyle.Regular);
            panelActive.Height = 2;
            panelActive.BackColor = Color.Gainsboro;
        }
        private Color SelectThemeColor()          //function return color theme
        {
            int index = random.Next(ThemColor.ColorList.Count);  //next in list
            while (tmp == index)      //if color has alredy,again choose.
            {
              index= random.Next(ThemColor.ColorList.Count);
            }
            tmp = index;            //tmp get index color in list
            string color = ThemColor.ColorList[index];  //the color from list-string
            return ColorTranslator.FromHtml(color);       //return color with class colorTranslator.

        }

        private void ActiveButton(object btnSender)             //Activity button
        {
            if(btnSender != null)               
            {
                if(currentButton != (Button)btnSender)           //if currrent button is not button gettin in function
                {
                    DisableButton();                          
                    Color color=SelectThemeColor();                  //get color from function(from list)
                    currentButton=(Button)btnSender;       //set current button
                    currentButton.BackColor=color;                  //change backcolor,font.
                    currentButton.ForeColor = Color.White;
                    currentButton.Font=new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                    panelTitle.BackColor=color;
                    panelLogo.BackColor = ThemColor.ChangeColorBrightness(color, -0.3f);
                    ThemColor.primaryColor=color;   
                    ThemColor.secondColor= ThemColor.ChangeColorBrightness(color, -0.3f);
                    
                }
            }   
        }

        private void DisableButton()                            //nonActivity button
        {
            foreach(Control prvBtn in panelManu.Controls)
            {
                if(prvBtn.GetType() == typeof(Button))        //if btn prv is button
                {
                    prvBtn.BackColor = Color.FromArgb(51, 51, 76);   
                    prvBtn.ForeColor = Color.Gainsboro; 
                    prvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                }
            }
        }
          
        protected virtual void openChildForm(Form childFrom,object btnSender)       //open child form in manu screen
        {
            if(activeForm!=null)
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
            lblTitle.Text = childFrom.Text;                         //change title 
            

        }


        private void Reset()                              //back to start mode
        {
            DisableButton();
            lblTitle.Text = "Dashboard";
            panelTitle.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;

        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            if (btnUserMengement.BackColor != Color.FromArgb(51, 51, 76))
            {
                MembersTimer.Start();
                timerSideManu.Start();
                btnUserMengement.BackColor = Color.FromArgb(51, 51, 76);
            }              
            AdminScreen_Load(sender, e);    
            Reset();
        }         //return to dashboard


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

        //buttons options

        private void btnSideManu_Click(object sender, EventArgs e)              //open/close side menu
        {
            timerSideManu.Start();
        }

        private void btnMyAcc_Click(object sender, EventArgs e)
        {
            if (!membersCollapse)
            {
                MembersTimer.Start();
                btnUserMengement.BackColor = btnSideManu.BackColor;
                openChildForm(new MyAccount(userLogged), sender);
            }
            else
                openChildForm(new MyAccount(userLogged), sender);

        }         //open form my-account

        private void btnCalandar_Click(object sender, EventArgs e)
        {
            if (!membersCollapse)
            {
                MembersTimer.Start();
                btnUserMengement.BackColor = btnSideManu.BackColor;
                openChildForm(new Calandar(), sender);
            }
            else
                openChildForm(new Calandar(), sender);
        }     //open form calandar

        private void btnUserMengement_Click(object sender, EventArgs e)
        {

            if (btnUserMengement.BackColor == Color.FromArgb(51, 51, 76))
            {
                ActiveButton(btnAddUser);
                openChildForm(new FormMembers(), sender);
                MembersTimer.Start();
            }
            if (!sideBarExpand)
            {
                panelManu.Width = panelManu.MaximumSize.Width;
                sideBarExpand = true;
            }
        }     //open child manu-menegment users

        private void btnAddUser_Click(object sender, EventArgs e)             //open form add member(registion)
        {
            if(btnAddUser.BackColor == Color.FromArgb(34, 36, 49))
            {
                openChildForm(new FormMembers(), sender);
                btnClients.BackColor = Color.FromArgb(34, 36, 49);
                btnAdmins.BackColor = Color.FromArgb(34, 36, 49);
                btnTraning.BackColor = Color.FromArgb(34, 36, 49);
            }
                

        }
        private void btnClients_Click_1(object sender, EventArgs e)
        {
            if (btnClients.BackColor == Color.FromArgb(34, 36, 49))
            {
                openChildForm(new Clients(), sender);
                btnAddUser.BackColor = Color.FromArgb(34, 36, 49);
                btnAdmins.BackColor=Color.FromArgb(34, 36, 49);
                btnTraning.BackColor = Color.FromArgb(34, 36, 49);
            }
               
        }
        private void btnAdmins_Click(object sender, EventArgs e)
        {
            if (btnAdmins.BackColor == Color.FromArgb(34, 36, 49))
            {
                openChildForm(new DeleteAndUpdateFrom(), sender);
                btnAddUser.BackColor = Color.FromArgb(34, 36, 49);
                btnClients.BackColor = Color.FromArgb(34, 36, 49);
                btnTraning.BackColor = Color.FromArgb(34, 36, 49);
            }
        }

        private void btnTraning_Click(object sender, EventArgs e)
        {
            if (btnTraning.BackColor == Color.FromArgb(34, 36, 49))
            { 
                openChildForm(new Forms_admin.ClassesForm(listP), sender);
                btnAddUser.BackColor = Color.FromArgb(34, 36, 49);
                btnClients.BackColor = Color.FromArgb(34, 36, 49);
                btnAdmins.BackColor = Color.FromArgb(34, 36, 49);
            }


        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (!membersCollapse)
            {
                MembersTimer.Start();
                btnUserMengement.BackColor = btnSideManu.BackColor;
                openChildForm(new DeleteAndUpdateFrom(), sender);
            }
            else
                openChildForm(new DeleteAndUpdateFrom(), sender);
        }        //open form settings

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (!membersCollapse)
            {
                MembersTimer.Start();
                btnUserMengement.BackColor = btnSideManu.BackColor;
                openChildForm(new DeleteAndUpdateFrom(), sender);
            }
            else
                openChildForm(new DeleteAndUpdateFrom(), sender);
        }           //open form about



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
            if (membersCollapse)
            {

                membersContiener.Height += 10;
                btnAbout.Location = new Point(-6, 567);
                btnSettings.Location = new Point(-6, 629);
                btnUserMengement.Text = "     Management  ▲";
                if (membersContiener.Height == membersContiener.MaximumSize.Height)
                {
                    membersCollapse = false;
                    MembersTimer.Stop();
                }
            }
            else
            {
                btnTraning.BackColor = Color.FromArgb(34, 36, 49);
                btnAddUser.BackColor = Color.FromArgb(34, 36, 49);
                btnClients.BackColor = Color.FromArgb(34, 36, 49);
                btnAdmins.BackColor = Color.FromArgb(34, 36, 49);
                btnAbout.Location = new Point(5, 360);
                btnSettings.Location = new Point(5, 423);
                membersContiener.Height -= 10;
                btnUserMengement.Text = "     Management  ▼";
                if (membersContiener.Height== membersContiener.MinimumSize.Height)
                {
                    membersCollapse=true;
                    MembersTimer.Stop();
                }
            }
        }    //open/close mengment members menu

   


  
        //Requasts to the server.
        private void FetchUsersDataAndPutInDashboard(List<Person> listP)
        {

            //3.CREATE OF PERSON LIST OBJECT, WITH ALL FUNCTIONS..
            PersonList PL = new PersonList(listP);


            lblTitleStatics.Text = "Registered users statistics ";
            lblUsers.Text = "Users  "+PL.CountAdminsANDUsersInSystem(PL.adminKey);
            lblAdmins.Text = "Administrators  " + PL.CountAdminsANDUsersInSystem(PL.userKey);

            //PUTTING THE INFORMATION IN THE APPROPRIATE PLACES ON THE SCREEN


            //circule gender
            circleGender.Value = PL.PercentageGenderForUserORAdmins(PL.userKey);
            circleGender.Text = circleGender.Value + "%";
            LblGenderData.Text = $"{circleGender.Value}% of the users is men,\n{100 - circleGender.Value}% is women.";


            //circule isBlocked
            circularIsBlocked.Value = PL.PercentageIsBlockedForUser();
            circularIsBlocked.Text = circularIsBlocked.Value + "%";

            //circule email favorite users
            string[] str = null;
            str = PL.GetFavoriteEmailAndHowMatchPercent(PL.userKey).Split(' ');
            circuleEmailPpoular.Value = int.Parse(str[1]);   //put percent.
            circuleEmailPpoular.Text = str[1] + "%";
            LblEmailFavData.Text = str[0] + " is the most popular email for users.";    //put name of most populer email.

            //circule AVG ages users.
            LblAVG.Text = PL.getAvgForListOfAdminsOrUsers(PL.userKey).ToString("0.#");
            lblAvgData.Text = $"Average ages of\n {PL.userKey} system.";

            //The most experienced userAndAdmin
            lblMostExprinceTitle.Text = "The most experienced user";
            lblLeastExprinceTitle.Text = "The least experienced user";
            listP = PL.theMostAndLeastExperiencedUserOrAdmins(PL.userKey);
            lblLeastExprince.Text = $"{listP[1].FirstName + " " + listP[1].LastName}, registed to system in {listP[1].DateRegistion}.";
            lblMostExprince.Text = $"{listP[0].FirstName + " " + listP[0].LastName}, registed to system in {listP[0].DateRegistion}.";

            //The most younger and older userAndAdmin
            LblMostOlderTitle.Text = " The oldest user";
            lblMostYoungerTitle.Text = " The younger user";
            listP = PL.theMostOlderAndMostYoungerUserOrAdmin(PL.userKey);
            lblMostYounger.Text = $"{listP[1].FirstName + " " + listP[1].LastName}, is {PersonList.GetAge(listP[1].DateBorn).ToString("0")} years old. ";
            LblMostOlder.Text = $"{listP[0].FirstName + " " + listP[0].LastName}, is {PersonList.GetAge(listP[0].DateBorn).ToString("0")} years old.";
        }

        private void FetchAdminsDataAndPutInDashboard(List<Person> listP)
        {


            PersonList PL = new PersonList(listP);

            lblTitleStatics.Text = "Administrators statistics ";
            lblUsers.Text = "Users  " + PL.CountAdminsANDUsersInSystem(PL.adminKey);
            lblAdmins.Text = "Administrators  " + PL.CountAdminsANDUsersInSystem(PL.userKey);

            circleGender.Value = PL.PercentageGenderForUserORAdmins(PL.adminKey);
            circleGender.Text = circleGender.Value + "%";
            LblGenderData.Text = $"{circleGender.Value}% of the administrators is men, {100 - circleGender.Value}% is women.";

            //circule email favorite administrators

            string[] str = null;
            str = PL.GetFavoriteEmailAndHowMatchPercent(PL.adminKey).Split(' ');
            circuleEmailPpoular.Value = int.Parse(str[1]);   //put percent.
            circuleEmailPpoular.Text = str[1] + "%";
            LblEmailFavData.Text = str[0] + " is the most popular email for administrators.";    //put name of most populer email.

            //circule AVG ages administrators.
            LblAVG.Text = PL.getAvgForListOfAdminsOrUsers(PL.adminKey).ToString("0.#");
            lblAvgData.Text = $"Average ages of administrator system.";

            //The most experienced userAndAdmin
            lblMostExprinceTitle.Text = "The most experienced administrator";
            lblLeastExprinceTitle.Text = "The least experienced administrator";
            listP = PL.theMostAndLeastExperiencedUserOrAdmins(PL.adminKey);
            lblLeastExprince.Text = $"{listP[1].FirstName + " " + listP[1].LastName}, registed to system in {listP[1].DateRegistion}.";
            lblMostExprince.Text = $"{listP[0].FirstName + " " + listP[0].LastName}, registed to system in {listP[0].DateRegistion}.";

            //The most younger and older userAndAdmin
            LblMostOlderTitle.Text = " The oldest administrator";
            lblMostYoungerTitle.Text = " The younger administrator";
            listP = PL.theMostOlderAndMostYoungerUserOrAdmin(PL.adminKey);
            lblMostYounger.Text = $"{listP[1].FirstName + " " + listP[1].LastName}, is {PersonList.GetAge(listP[1].DateBorn).ToString("0")} years old. ";
            LblMostOlder.Text = $"{listP[0].FirstName + " " + listP[0].LastName}, is {PersonList.GetAge(listP[0].DateBorn).ToString("0")} years old.";
        }

        private Person FetchDataUserById(string id,List<Person>listP)
        {

            PersonList PL = new PersonList(listP);

            Person loggedUser = PL.findPersonById(id);
            if (loggedUser.IsAdmin)
                lblUserNameAndStatus.Text = loggedUser.FirstName + " " + loggedUser.LastName + "\n" + "administrator.";
            else lblUserNameAndStatus.Text = loggedUser.FirstName + " " + loggedUser.LastName + "\n" + "user.";
            profilePic.Image = loggedUser.ProfilePic;
            return loggedUser;
        }

        //loading the data and putting on dashboard. 
        private void AdminScreen_Load(object sender, EventArgs e)
        {
            string responseFromServer = ConnectWithServer.callToServer(controller, "getAllDataForAdminScreenInDahsboard#", "");
            panelStaticsCircule.Size = new Size(778, 523);
            listP = ConnectWithServer.ConvartDataToListOfPersons(responseFromServer);

            userLogged =FetchDataUserById(static_userId,listP);        
            FetchUsersDataAndPutInDashboard(listP);
                

        }

        private void lblUsers_Click(object sender, EventArgs e)
        {
            activePanel(lblUsers,panelUsers);
            inactivePanel(lblAdmins,panelAdmins);
            inactivePanel(lblClasses,panelClasses);
            FetchUsersDataAndPutInDashboard(listP);
        }

        private void lblAdmins_Click(object sender, EventArgs e)
        {
            activePanel(lblAdmins, panelAdmins);
            inactivePanel(lblUsers, panelUsers);
            inactivePanel(lblClasses, panelClasses);
            FetchAdminsDataAndPutInDashboard(listP);
        }

        private void lblClasses_Click(object sender, EventArgs e)
        {
            activePanel(lblClasses, panelClasses);
            inactivePanel(lblUsers, panelUsers);
            inactivePanel(lblAdmins, panelAdmins);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }

        private void penelHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
