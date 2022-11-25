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
        private string fullEventsOnThisDay;
        private string eventCreted;

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
                }
            }

        }

        //Get all data events from server and putting in dataGrridView.
        private void putAllEventsDataOnScreen(string fullEventsOnThisDay)
        {
            lblNotEvents.Visible = false;
            List<EventCalandarcs> listEvent = ConnectWithServer.ConvartDataToListOfEvent(fullEventsOnThisDay);
            for (int i = 0; i < listEvent.Count; i++)
            {
                dataEvents.Rows.Add(listEvent[i].EventName, listEvent[i].FromHour + " : " + listEvent[i].ToHour, listEvent[i].Location,listEvent[i].EventID);
            }
           

        }



        private void EventForm_Load(object sender, EventArgs e)
        {
            loadTheme();
            txtBoxDate.Text = fullDate;
            fullEventsOnThisDay = ConnectWithServer.callToServer(Calandar.controller, "allEventsForThisDay#",
            AdminScreen.static_userId + "#" + fullDate);          //get all data events for this day
            lblTitle.Text += " - " + fullDate + ", " + Convert.ToDateTime(fullDate).DayOfWeek + ".";
            if (fullEventsOnThisDay != string.Empty && fullEventsOnThisDay != "false")  
            {                                       
                panelAllEvent.Visible = true;
                putAllEventsDataOnScreen(fullEventsOnThisDay);
                fullEventsOnThisDay = null;
            }
            else
            {
                btnDeleteEvent.Visible = false;
            }

        }

        //Deleted selected row.
        private void btnTrhash_Click_1(object sender, EventArgs e)  
        {
            foreach (DataGridViewRow row in dataEvents.SelectedRows)
            {

                string deleted = ConnectWithServer.callToServer(Calandar.controller, "deleteEventByEventId#",
                     AdminScreen.static_userId + "#" + row.Cells[3].Value + "#");  //send userId and eventId
                if (bool.Parse(deleted))
                {
                    MessageBox.Show(row.Cells[0].Value + " deleted.");
                    dataEvents.Rows.RemoveAt(row.Index);
                    if(dataEvents.Rows.Count == 0)  
                        this.Close();
                }
            }
        }

        //added new event.
        private void btnSave_Click(object sender, EventArgs e)          
        {
            if (txtBoxEvent.Text != "" && comboBoxHourFrom.SelectedIndex < comboBoxHourTo.SelectedIndex
                && txtLocation.Text != "")          //if all feilds is proper
            {
                //Ask the server to add a new event
                 eventCreted =ConnectWithServer.callToServer(Calandar.controller, "insertNewEvent#",
                    AdminScreen.static_userId+"#"+txtBoxEvent.Text+"#"+txtBoxDate.Text+"#"+
                    comboBoxHourFrom.Text+"#"+comboBoxHourTo.Text+"#"+txtLocation.Text);
                if (bool.Parse(eventCreted))
                {
                    MessageBox.Show("The event has been successfully added");
                    this.Close();
                }
                else MessageBox.Show("You already have another event at this time....");             
            }
            else 
                MessageBox.Show("Plese enter name, loacation and normal hours. ");
          
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            panelAllEvent.Visible = false;
        }


        private void btnMyEvents_Click(object sender, EventArgs e)
        {
            panelAllEvent.Visible = true;
        }


    }
}
