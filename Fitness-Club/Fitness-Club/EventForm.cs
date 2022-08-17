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
    public partial class EventForm : Form
    {
        string fullDate = UserControlDays.static_day + "/" + Calandar.static_month + "/" + Calandar.static_year;
        public static bool eventCreted;


        public EventForm()
        {
            InitializeComponent();
        }
       
        private void EventForm_Load(object sender, EventArgs e)
        {
            eventCreted = false;
            txtBoxDate.Text = fullDate;
            for (int i = 0;i< FatchAllEventsForThisDayInList().Count;i++)             
                lblEventslist.Text += FatchAllEventsForThisDayInList()[i]+'\n';
        }
        private List<string> FatchAllEventsForThisDayInList()            //RETURN ALL EVENTS FOR THIS DAY IN LIST
        {
            List<string> eventsList = new List<string> { };
            try
            {

                LogIn.static_conn.Open();
                String sql = "SELECT * FROM events where date = @date AND userId=@userId";
                SqlCommand cmd = LogIn.static_conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@date", fullDate);
                cmd.Parameters.AddWithValue("@userId", AdminScreen.static_userId);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    eventsList.Add(dr.GetValue(2)+"");  
                }
                dr.Dispose();
                cmd.Dispose();
                LogIn.static_conn.Close();
                return eventsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        private bool InsertNewEventToDataBase()                       //ADD EVENT TO LIST
        {
            try
            {
                LogIn.static_conn.Open();
                String sql = "INSERT INTO events(userId,eventName,date)values(@userId,@eventName,@date)";
                SqlCommand cmd = LogIn.static_conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@userId", AdminScreen.static_userId);
                cmd.Parameters.AddWithValue("@eventName", txtBoxEvent.Text);
                cmd.Parameters.AddWithValue("@date", txtBoxDate.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                LogIn.static_conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

    
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxEvent.Text != "")
            {
                eventCreted = InsertNewEventToDataBase();          //inserting event to database and chenge flag
                this.Close();
            }
            else
                MessageBox.Show("Plese enter name for event");

        }

    }
}
