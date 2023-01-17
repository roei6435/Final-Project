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
    public partial class AdminsStaticts : Form
    {
        private List<Person> listAdmins = null;
        private PersonList PLActiveNow = null;
        public static string controller = "Dashboard#";
        public AdminsStaticts(List<Person> listAdmins)
        {
            this.listAdmins = listAdmins;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            putAdminsData();

        }
         private void putAdminsData()
        {
            PLActiveNow = new PersonList(listAdmins);


            //COUNT OF ADMINISTRATORS IN SYSTEM
            lblCountAdmins.Text = listAdmins.Count.ToString();

            //AVGRAGE AGES ADMINISTRATORS
            LblAVGAdmins.Text= PLActiveNow.getAvgForList().ToString("0.#");

            //COUNT OF ACTIVE IN LAST WEEK
            lblActiveAdminsWeek.Text = PLActiveNow.getCountConnectInLastWeek().ToString();

            //PERCENT OF GENDER 
            int percent;   
            percent = PLActiveNow.getPercentageGender();
            lblGenderAdmins.Text = $"Men {percent}% Women {100- percent}%";
            circularGenderAdmins.Value = percent;

            //GET MOST ACTIVE ADMIN
            Person nowPerson = PLActiveNow.getMostActiveAdminByTweets();
            if (nowPerson != null)
            {
                picMostActive.Image = nowPerson.ProfilePic;
                lblMostActive.Text = $"{nowPerson.FullName} with {nowPerson.Email} tweets in the last week.";
            }

            //GET SUM OF PAYMENTS OF THIS MONTH
            string sum = Payments.getSumOfPaymentsOfLastMonth();
            if(sum != null)
            {
                lblIncome.Text = sum;
                DateTime date = DateTime.Now;
                lblIcomeData.Text = $"The monthly income at the fitness center for the month of {Calandar.DicMonth[date.ToString("MMMM")]}";
            }



            //AGE ---MOST HIGH AND LOW
            nowPerson = PLActiveNow.getMostOlderOrMostYounger("high");
            if (nowPerson != null)
            {
                picOlderAdminstor.Image = nowPerson.ProfilePic;
                lblOldestAdmin.Text = $"{nowPerson.FullName} - {PersonList.GetAge(nowPerson.DateBorn).ToString("0.#")} years old";
            }

            nowPerson = PLActiveNow.getMostOlderOrMostYounger("low");
            if (nowPerson != null)
            {
                picYoungerAdminstor.Image = nowPerson.ProfilePic;
                lblYoungerAdmin.Text = $"{nowPerson.FullName} - {PersonList.GetAge(nowPerson.DateBorn).ToString("0.#")} years old";
            }

            //EXPRINCE ---MOST HIGH AND LOW
            nowPerson = PLActiveNow.getMostAndLeastExperiencedAdmins("high");
            if (nowPerson != null)
            {
                lblMostExprinceAdmin.Text = $"{nowPerson.FullName}, before {LoginANDRegister.lastConnectDiff(nowPerson.DateRegistion)} ";
                picExprinceAdmin.Image = nowPerson.ProfilePic;
            }

            nowPerson = PLActiveNow.getMostAndLeastExperiencedAdmins("low");
            if (nowPerson != null)
            {
                lblLeastExprinceAdminsteror.Text = $"{nowPerson.FullName}, before {LoginANDRegister.lastConnectDiff(nowPerson.DateRegistion)} ";
                picLeastExprinceAdmin.Image = nowPerson.ProfilePic;
            }














        }

    }
}
