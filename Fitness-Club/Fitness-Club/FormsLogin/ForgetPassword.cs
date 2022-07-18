using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club.Resources.FormsLogin
{
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            panelFields.Visible = false;
            panelVer.Location = new Point(570, 180);
            panelVer.Visible = true; 
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFields_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            panelVer.Visible = false;
            panelCnfirm.Location = new Point(570, 180);
            panelCnfirm.Visible = true;
        }
    }
}
