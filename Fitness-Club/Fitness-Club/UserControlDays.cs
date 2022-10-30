using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Club
{
    public partial class UserControlDays : UserControl
    {
        public static string controller = "Calandar#";
        public static string static_day;
        public static int _countUserEventsInDay;
        private string fullDate;
        public UserControlDays(int numDay)
        {
            fullDate = numDay + "/" + Calandar.static_month + "/" + Calandar.static_year;
            //get from server the count events of this date
            string response = ConnectWithServer.callToServer(controller, "countUserEventsInDay#",
                AdminScreen.static_userId+"#"+ fullDate);
            _countUserEventsInDay = int.Parse(response);
            InitializeComponent();           
        }
          
        private void UserControlDays_Load(object sender, EventArgs e)        //display where heve event
        {
            if (_countUserEventsInDay>0)
                ringPic.Visible = true;
        }
        public void days(int numDay)                                        //print day labal.
        {
            btnDay.Text = numDay +"";

        }

        public void printCountEvent()                                       //print Counter events.
        {
            if (_countUserEventsInDay > 1 )
            {
                CounterEvents.Text = _countUserEventsInDay+ "";
                CounterEvents.Visible = true;
            }
            else
            {
                CounterEvents.Visible = false;
            }
        }


        private void btnDay_Click(object sender, EventArgs e)               //open new form-add event and list of events.
        {
            static_day = btnDay.Text;
            EventForm ef = new EventForm();
            ef.FormClosed += EventForm_FormClosed;
            ef.Show();

        }

        //checked and updated the status of events in closed form.
        private void EventForm_FormClosed(object sender, FormClosedEventArgs e)     
        {

             string response =  ConnectWithServer.callToServer(controller, "countUserEventsInDay#",
              AdminScreen.static_userId + "#" + fullDate);
            _countUserEventsInDay = int.Parse(response);
            if (_countUserEventsInDay == 0)
                ringPic.Visible = false;
            else
                ringPic.Visible = true;
            printCountEvent();
        }

    }
}
