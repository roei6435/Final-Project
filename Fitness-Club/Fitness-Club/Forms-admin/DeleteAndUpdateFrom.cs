using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Fitness_Club
{
    public partial class DeleteAndUpdateFrom : Form
    {
        public int secounds = 0;
        public string data = null;
        public DeleteAndUpdateFrom()
        {
            InitializeComponent();



        }
        public void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            secounds++; 
            if(secounds == 1)
            {
                data = "data";
            }
            if (data == null)
            {
                panelLoading.Visible = true;
            }
            else
            {
                panelLoading.Visible = false;
            }
        }

        private void DeleteAndUpdateFrom_Load(object sender, EventArgs e)
        {
            panelLoading.Size = new Size(1399, 658);
            circleLoading.Location = new Point(522, 224);
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            loadTheme();
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
            lblTitle.ForeColor = ThemColor.secondColor;

        }


        private void btnSendMess_Click(object sender, EventArgs e)
        {


            
        }
    }
}
