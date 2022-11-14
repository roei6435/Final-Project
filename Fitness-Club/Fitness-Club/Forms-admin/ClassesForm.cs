using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Club.Forms_admin
{
    public partial class ClassesForm : Form
    {
        private static string controller = "MengementClasses#";
        private List <Classes> listC;
        private int indicator = 0;
        private int jump = 2;
        public ClassesForm()
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

        private void Classes_Load(object sender, EventArgs e)
        {
            string response = ConnectWithServer.callToServer(controller, "getAllDataClasses#", "");
            listC= ConnectWithServer.ConvartDataToListOfClasses(response);
         //   displayData(indicator, jump);
            loadTheme();

        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton10_Click(object sender, EventArgs e)
        {

        }
    }
}
