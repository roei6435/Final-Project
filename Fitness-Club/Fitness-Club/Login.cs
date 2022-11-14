using Fitness_Club.Resources.FormsLogin;
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
//using System.Data;
using System.Data.SqlClient;

using System.Net;
using System.Net.Sockets;
using System.IO;


namespace Fitness_Club
{
    public partial class LogIn : Form

    {
        
        public static string controller = "login#";

        public static SqlConnection static_conn=new SqlConnection("Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True");
        public LogIn()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = true;
            picBoxUser.Image = Properties.Resources.email1;
            panel1.BackColor = Color.FromArgb(30, 144, 255);
            textBox1.ForeColor = Color.FromArgb(30, 144, 255);

            picBoxPass.Image = Properties.Resources.pass;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;


        }

     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            picBoxPass.Image = Properties.Resources.pass3;
            panel2.BackColor = Color.FromArgb(30, 144, 255);
            textBox2.ForeColor = Color.FromArgb(30, 144, 255);

            picBoxUser.Image = Properties.Resources.email;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void LogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picBoxPass_Click(object sender, EventArgs e)
        {

        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ForgetPassword fg = new ForgetPassword();
            this.Hide();
            fg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string admin = guna2ToggleSwitch1.Checked.ToString();
            string response = ConnectWithServer.callToServer(controller, "tryLogIn#", 
                textBox1.Text + "#" + textBox2.Text +'#'+ admin);
            string [] splitResponse=response.Split(' ');    //[0]--login successfully?  //[1]-userId logged 


            if (splitResponse[0] == "true" && admin== "True")
            {
                ConnectWithServer.callToServer(controller, "updateLastConn#",splitResponse[1]);
                AdminScreen adsc = new AdminScreen(splitResponse[1]);
                adsc.Show();
                this.Hide();
            }
            else if(splitResponse[0] == "true" && admin == "False")
            {
                DeleteAndUpdateFrom pf=new DeleteAndUpdateFrom();
                pf.Show();
                this.Hide();
            }
            else if (splitResponse[0] == "false")
            {
                lblLoginFeild.Text = "Incorrect email or password plese try again.";
                lblLoginFeild.Visible = true;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }
    }
}
