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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel(lblDashboard, panelDashboard);
            AdminScreen.inactivePanel(lblCalandar, panelCalendar);
            AdminScreen.inactivePanel(lblMenegment, panelMengment);
            AdminScreen.inactivePanel(lblMyAcc, panelMyAcc);
            AdminScreen.inactivePanel(lblSettings, panelSettings);
            fullLbl.Text = "This is the ultimate screen for the most professional manager." +
                " Get a statistical overview and data for users, managers (you are one of them) and also our classes in the fitness center. " +
                "If you are a person of data like of weights you will be able to enjoy what will be" +
                " presented to you there and draw conclusions to improve and optimize the fitness center.";

        }

        private void lblMyAcc_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel(lblMyAcc, panelMyAcc);
            AdminScreen.inactivePanel(lblCalandar, panelCalendar);
            AdminScreen.inactivePanel(lblMenegment, panelMengment);
            AdminScreen.inactivePanel(lblDashboard, panelDashboard);
            AdminScreen.inactivePanel(lblSettings, panelSettings);
            fullLbl.Text = "This is your personal space. You can update all your personal details such as name, " +
                "password and profile picture here. In addition, you will also receive information on when you last " +
                "updated your password and when it is necessary to refresh it. And of course the most important thing is " +
                "that you can see what is happening with your level and when juniors will stop yelling at you in the corridors" +
                " of the fitness center.";
        }

        private void lblCalandar_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel(lblCalandar, panelCalendar);
            AdminScreen.inactivePanel(lblMyAcc, panelMyAcc);
            AdminScreen.inactivePanel(lblMenegment, panelMengment);
            AdminScreen.inactivePanel(lblDashboard, panelDashboard);
            AdminScreen.inactivePanel(lblSettings, panelSettings);
            fullLbl.Text = "System administrators have quite a few tasks during the day, week and month." +
                " My calendar comes to make order for you in the mess. All you need is to enter the event" +
                "  into the calendar and we'll make sure to remind you, so saying I pulled out of the event because I forgot" +
                " is no longer an option for you.";
        }

        private void lblMenegment_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel( lblMenegment, panelMengment);
            AdminScreen.inactivePanel(lblMyAcc, panelMyAcc);
            AdminScreen.inactivePanel(lblCalandar, panelCalendar);
            AdminScreen.inactivePanel(lblDashboard, panelDashboard);
            AdminScreen.inactivePanel(lblSettings, panelSettings);
            fullLbl.Text = "What does a manager actually do? dictates the pace." +
" And this is exactly the place for it.Here you have many options in managing our fitness center. " +
"It starts with registering new customers in the system, updating management privileges for managers, " +
"a screen that is only for our classes in the fitness center where you can see all the ratings and experiences" +
" of our customers. In addition to everything at the fitness center, we advocate for unity and maintaining contact " +
"between the management team, so there is a tweeting room for you where you can share your feelings with the rest" +
" of the team. In the customer area you will see everything you need to know for customers such as the status " +
"of their payments and perform a wide variety of actions. ";
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            AdminScreen.activePanel(lblSettings, panelSettings);
            AdminScreen.inactivePanel(lblMyAcc, panelMyAcc);
            AdminScreen.inactivePanel(lblCalandar, panelCalendar);
            AdminScreen.inactivePanel(lblDashboard, panelDashboard);
            AdminScreen.inactivePanel(lblMenegment, panelMengment);
            fullLbl.Text = "And of course the most important thing for us is to adapt ourselves to" +
                " the needs of the system administrators, therefore in the settings screen you can " +
                "control everything related to your personal absences in a variety of fields.";
        }
    }
}
