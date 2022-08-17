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
        public static string static_day;
        public UserControlDays()
        {
            InitializeComponent();           
        }
          
        private void UserControlDays_Load(object sender, EventArgs e)        //display where heve event
        {
            if (CountEventsInDay()>0)
                ringPic.Visible = true;
        }
        public void days(int numDay)                                        //print day labal.
        {
            btnDay.Text = numDay +"";
        }

        public void ptintCountEvent()                                       //print Counter events.
        {
            if (CountEventsInDay() > 1 )
            {
                CounterEvents.Text = CountEventsInDay()+"";
                CounterEvents.Visible = true;
            }
        }


        private void btnDay_Click(object sender, EventArgs e)               //open create form
        {
            static_day = btnDay.Text;
            EventForm ef = new EventForm();
            ef.FormClosed += EventForm_FormClosed;
            ef.Show();

        }

        private void EventForm_FormClosed(object sender, FormClosedEventArgs e)      //Checked if was created event
        {
            if (EventForm.eventCreted)                              
            {
                ringPic.Visible = true;
                ptintCountEvent();
            }   
        }

        private int CountEventsInDay()                          //Fatch count events from dataBase
        {
            try
            {
              
                string date = btnDay.Text + "/" + Calandar.static_month + "/" + Calandar.static_year;
                string querry = " SELECT * FROM events WHERE date = '"+date+"' and userId="+ AdminScreen.static_userId + "";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, LogIn.static_conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt.Rows.Count;  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }

        }         



    }
}
