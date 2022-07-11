using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox2.UseSystemPasswordChar = true;
            picBoxUser.Image = Properties.Resources.user2;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78,184,206);

            picBoxPass.Image = Properties.Resources.pass;
            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            picBoxPass.Image = Properties.Resources.pass1;
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            picBoxUser.Image = Properties.Resources.user;
            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }
    }
}
