using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fitness_Club
{
    public partial class Calendar : Form
    {
        public static string controller = "Calandar#";
        int month,year;
        public static int static_month,static_year;
        
        public Calendar()
        {
            InitializeComponent();
           
        }

        private void Calandar_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            year = now.Year;
            month = now.Month;
            loadTheme();
            displayDays();                          
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

        public void displayDays()                           //display all useControlDays/Empty ralevente for month
        {
          
            static_month = month;
            static_year = year;
            dayContainer.Controls.Clear();
            timerTranslate.Start();
            DateTime startMounth = new DateTime(year, month, 1); //01/08/2022 00:00  
            int days = DateTime.DaysInMonth(year, month); //31       
            int dayOfTheWeek = Convert.ToInt32(startMounth.DayOfWeek) + 1;   //היום בשבוע שבו מתחיל החודש
            for (int i = 1; i < dayOfTheWeek; i++)    //Until you get to the day the month starts
            {
                UserControlEmpty emptySquare = new UserControlEmpty();
                dayContainer.Controls.Add(emptySquare);   //add empty squre to countiner.
            }
            for (int i = 1; i <= days; i++)
            {
                UserControlDays daySquare = new UserControlDays(i);
                daySquare.days(i);                  //print numbur day and counter events                                                
                daySquare.printCountEvent();
                dayContainer.Controls.Add(daySquare);        //add day squre with numnur day to countiner.
            }
        }                                                                 


        Dictionary<string, string> DicMonth =new Dictionary<string, string>(){
            {"ינואר", "January "},
            {"פברואר", "February"},
            {"מרץ", "March"},
            {"אפריל", "April"},
            {"מאי", "May"},
            {"יוני", "June"},
            {"יולי", "July"},
            {"אוגוסט", "August"},
            {"ספטמבר", "September"},
            {"אוקטובר", "October"},
            {"נובמבר", "November"},
            {"דצמבר", "December"}
        };     //dictionary hebrew-english months

        private void timerTranslate_Tick(object sender, EventArgs e)            //translate from hebrew
        {
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthNameAndYear.Text = DicMonth[monthName] + " " + year;
            timerTranslate.Stop();
        }


        //moving in calandar
        private void btnPrev_Click(object sender, EventArgs e)
        {          
            if (month == 1)
            {
                year--;
                month = 12;
            }else { month--; }
            static_month = month;
            static_year = year;
            displayDays();
        }           
        private void btnNext_Click(object sender, EventArgs e)
        {          
            if (month == 12)
            {
                year++;
                month = 1;
            }
            else { month++; }
            static_month = month;
            static_year = year;
            displayDays();
        }
    }
}
