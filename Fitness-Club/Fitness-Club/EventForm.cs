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
                    lblAddEv.ForeColor = ThemColor.primaryColor;
                    lblMyEvents.ForeColor = ThemColor.primaryColor;
                }
            }

        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            loadTheme();
            txtBoxDate.Text = fullDate;
            eventCreted = false;
            List<List<string>> eventsList =FatchAllEventsForThisDayInList();
            if (eventsList.Count > 0) {
                lblMyEvents.Text+= fullDate;
                lblEventslist.Text = "";
                for (int i = 0; i < eventsList.Count; i++)
                {
                    string name=eventsList[i][0],time=eventsList[i][1]+"-"+eventsList[i][2],location=eventsList[i][3];
                    name= char.ToUpper(name[0])+name.Substring(1);
                    lblEventslist.Text += String.Format("{0,-12}{1,8}{2,12}\n\n", name, time,location);
                }                
                panelAllEvents.Visible = true;
                panelAddEvent.Visible = false;
            }
          
         
        }
        private List<List<string>> FatchAllEventsForThisDayInList()            //RETURN ALL EVENTS FOR THIS DAY IN LIST
        {
            //List<string>  = new List<string> { };
            List<List<string>> allEventsForThisDay = new List<List<string>>();
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
                    allEventsForThisDay.Add(new List<string> { dr.GetValue(2) + "", dr.GetValue(4) + "", dr.GetValue(5) + "",dr.GetValue(6)+"" });  
                }
                dr.Dispose();
                cmd.Dispose();
                LogIn.static_conn.Close();
                return allEventsForThisDay;
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
            if (txtBoxEvent.Text != ""&& comboBoxHourFrom.SelectedIndex < comboBoxHourTo.SelectedIndex) //PROPER HOURS AND NAME
            {
                eventCreted = InsertNewEventToDataBase();          //inserting event to database and chenge flag
                this.Close();
            }
            else 
                MessageBox.Show("Plese enter name and normal hours ");
           

        }


    }
}
