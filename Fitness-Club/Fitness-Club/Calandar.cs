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

namespace Fitness_Club
{
    public partial class Calandar : Form
    {

        int month,year;
   
        public Calandar()
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
        };


        private void timerTranslate_Tick(object sender, EventArgs e)
        {
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblMonthNameAndYear.Text = DicMonth[monthName] + " " + year;
            timerTranslate.Stop();
        }
        private void displayDays()
        {
            dayContainer.Controls.Clear();
            timerTranslate.Start();
            DateTime startMounth = new DateTime(year, month, 1); //01/08/2022 00:00  
            int days =DateTime.DaysInMonth(year, month); //31       
            int dayOfTheWeek=Convert.ToInt32(startMounth.DayOfWeek) +1;   //היום בשבוע שבו מתחיל החודש
            for (int i = 1; i < dayOfTheWeek; i++)    //Until you get to the day the month starts
            {
               UserControlEmpty emptySquare = new UserControlEmpty();  
                dayContainer.Controls.Add(emptySquare);   //add empty squre to countiner.
            }
            for(int i = 1; i <= days; i++)
            {
                UserControlDays daySquare = new UserControlDays();
                daySquare.days(i);                  //print numbur day
                dayContainer.Controls.Add(daySquare);        //add day squre with numnur day to countiner.
            }
            

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
           
            if (month == 1)
            {
                year--;
                month = 12;
            }else { month--; }
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
            displayDays();
        }
    }
}
