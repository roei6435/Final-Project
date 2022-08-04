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

namespace Fitness_Club
{
    public partial class manuAadmin : Form
    {

        private Button currentButton;
        private Random random;
        private int tmp;
        private Form activeForm;
        private bool sideBarExpand;
        private bool membersCollapse;


        public manuAadmin()
        {
            InitializeComponent();
            random = new Random();
            btnReturnToHomeForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
 
        }
        string str = "Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()  //function return color
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

        private void ActiveButton(object btnSender)
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
                    btnReturnToHomeForm.Visible = true;
                }
            }   
        }
        private void DisableButton()
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
          
        protected virtual void openChildForm(Form childFrom,object btnSender)       //open the form selected
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

        private void btnMemers_Click(object sender, EventArgs e)
        {
            openChildForm(new addMember(),sender);    
            
        }

        private void btnAddMembers_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMembers(), sender);
        }

        private void btnUpdateMem_Click(object sender, EventArgs e)
        {
            openChildForm(new DeleteAndUpdateFrom(), sender);
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            openChildForm(new paymentsFrom(), sender);
        }

        private void btnReturnToHomeForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            //panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnReturnToHomeForm.Visible = false;
        }



        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

 
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //home
        private void picBoxEdit_Click(object sender, EventArgs e)
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

        private void btnSaveChenge_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = con.CreateCommand();   
            var image =new ImageConverter().ConvertTo(profilePic.Image,typeof(Byte[]));
            cmd.Parameters.AddWithValue("@image", image);
            cmd.CommandText = "INSERT INTO images (img) VALUES(@image)";
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("imge added");
            else
                MessageBox.Show("not");
            con.Close();
        }


        private void btnManuClose_Click(object sender, EventArgs e)
        {
            timerSideManu.Start();
        }

        private void timerSideManu_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                panelManu.Width -= 10;
                if (panelManu.Width == panelManu.MinimumSize.Width)
                {
                    sideBarExpand = false;
                    timerSideManu.Stop();
                }
            }
            else
            {
                panelManu.Width += 10;
                if (panelManu.Width == panelManu.MaximumSize.Width)
                {
                    sideBarExpand = true;
                    timerSideManu.Stop();
                }
            }
        }

        private void manuAadmin_Load(object sender, EventArgs e)
        {

        }

        private void MembersTimer_Tick(object sender, EventArgs e)
        {
            if (membersCollapse)
            {
                btnUserMengement.Text = " User Management  ▲";
                membersContiener.Height += 10;
                if (membersContiener.Height == membersContiener.MaximumSize.Height)
                {
                    membersCollapse = false;
                    MembersTimer.Stop();
                }
            }
            else
            {
                btnUserMengement.Text = " User Management  ▼";
                membersContiener.Height -= 10;  
                if(membersContiener.Height== membersContiener.MinimumSize.Height)
                {
                    membersCollapse=true;
                    MembersTimer.Stop();
                }
            }
        }

 



        private void btnAddUser_Click(object sender, EventArgs e)
        {
            openChildForm(new FormMembers(), sender);
        }

        private void btnUserMengement_Click(object sender, EventArgs e)
        {
   
            MembersTimer.Start();


        }

        private void btnDsasboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void picBoxHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
    }
}
