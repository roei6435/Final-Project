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
    public partial class ClientsStatistics : Form
    {
        private List<Person> listUsers = null;
        private PersonList PLActiveNow = null;
        public ClientsStatistics(List<Person>listUsers)
        {
            this.listUsers = listUsers;
            InitializeComponent();
        }

        private void ClientsStatistics_Load(object sender, EventArgs e)
        {
            putUsersData();
        }
        private void putUsersData()
        {
            PLActiveNow =new PersonList(listUsers);

            //COUNT OF CLIENTS IN SYSTEM
            lblCountUsers.Text = listUsers.Count.ToString();

            //AVGRAGE AGES CLIENTS
            LblAVGUsers.Text = PLActiveNow.getAvgForList().ToString("0.#");

            //COUNT OF ACTIVE IN LAST WEEK
            lblActiveClasses.Text = PLActiveNow.getCountConnectInLastWeek().ToString();

            //PERCENT OF GENDER 
            int percent;
            percent = PLActiveNow.getPercentageGender();
            lblGenderUsers.Text = $"Men {percent}% Women {100 - percent}%";
            circularGenderAdmins.Value = percent;

            //PERCENT OF IS BLOCKED
            percent = PLActiveNow.getPercentageIsBlocked();
            lblIsBlocked.Text = $"Blocked {percent}% Not blocked {100 - percent}%";
            circularProgressBarIsBlocled.Value = percent;

            //GET MOST ACTIVE CLIENT
            Person nowPerson = PLActiveNow.getMostActiveClientByClasses();
            if (nowPerson != null)
            {
                picMostActive.Image = nowPerson.ProfilePic;
                lblMostActive.Text = $"{nowPerson.FullName} with attendance in {nowPerson.ClassesArray.Length} classes.";
            }

            ////GET USER PAID MAX ON THIS MONTH
            nowPerson = PLActiveNow.getTheUserPaidMax();
            if (nowPerson != null)
            {
                lblIncome.Text = nowPerson.Email+"$";
                DateTime date = DateTime.Now;        
                lblIcomeData.Text = $"The client who paid the most for the month of { Calandar.DicMonth[date.ToString("MMMM")]} is {nowPerson.FullName} ";
            }



            //AGE ---MOST HIGH AND LOW
            nowPerson = PLActiveNow.getMostOlderOrMostYounger("high");
            if (nowPerson != null)
            {
                picOlderAdminstor.Image = nowPerson.ProfilePic;
                lblOldestUser.Text = $"{nowPerson.FullName} - {PersonList.GetAge(nowPerson.DateBorn).ToString("0.#")} years old";
            }

            nowPerson = PLActiveNow.getMostOlderOrMostYounger("low");
            if (nowPerson != null)
            {
                picYoungerAdminstor.Image = nowPerson.ProfilePic;
                lblYoungerUser.Text = $"{nowPerson.FullName} - {PersonList.GetAge(nowPerson.DateBorn).ToString("0.#")} years old";
            }

            //EXPRINCE ---MOST HIGH AND LOW
            nowPerson = PLActiveNow.getMostAndLeastExperiencedAdmins("high");
            if (nowPerson != null)
            {
                lblMostExprinceUser.Text = $"{nowPerson.FullName}, before {LoginANDRegister.lastConnectDiff(nowPerson.DateRegistion)} ";
                picExprinceAdmin.Image = nowPerson.ProfilePic;
            }

            nowPerson = PLActiveNow.getMostAndLeastExperiencedAdmins("low");
            if (nowPerson != null)
            {
                lblLeastExprinceUser.Text = $"{nowPerson.FullName}, before {LoginANDRegister.lastConnectDiff(nowPerson.DateRegistion)} ";
                picLeastExprinceAdmin.Image = nowPerson.ProfilePic;
            }


        }
    }
}
