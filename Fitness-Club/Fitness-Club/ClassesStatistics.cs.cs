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
    public partial class ClassesStatistics : Form
    {
        private List<Classes> listC;
        private List<Person> listUsers;
        private ClassesList CL;
        private PersonList PL;
        public ClassesStatistics(List<Classes>listC,List<Person>listUsers)
        {
            this.listUsers = listUsers;
            this.listC = listC;
            InitializeComponent();
        }

        private void ClassesStatistics_Load(object sender, EventArgs e)
        {
            putClassesData();
        }                                       
        private void putClassesData()
        {
            CL = new ClassesList(listC);
            PL = new PersonList(listUsers); 

            lblCountClasses.Text = listC.Count.ToString();

            lblActiveClassesNow.Text=CL.getCountActiveClasses().ToString();


            Classes cla = CL.theLowestAndHighstAvgGrade("high");
            picHighRaiting.Image = cla.Pic;
            lblHighRaiting.Text = $"{cla.NameClass} the class with the highest rating, {cla.Pic.Tag}!";

            int percent;
            percent = CL.getActiveClassesPercent();
            lblActiveCircule.Text = $"Active {percent}% inactive {100 - percent}%";
            circularActivity.Value = percent;

            LblAVGRaitings.Text = CL.getAvgRaitingAllClasses()+"/5.0";


            cla = PL.getTheMostIncomeClassInLastMonth();
            DateTime date = DateTime.Now;
            lblIncome.Text = cla.About + "$";
            lblIcomeData.Text = $"The monthly income from the most profitable class for the month of {Calandar.DicMonth[date.ToString("MMMM")]}, {cla.NameClass}.";

            cla=CL.getMostOrLeastFriendsClass("high");
            lblMostFriends.Text =$"{cla.NameClass} class, with {cla.ArrayRegisteredUsersThisClass.Length} active members";
            picMustFriends.Image = cla.Pic;

            cla= CL.getMostOrLeastFriendsClass("low");
            picLeastFriends.Image = cla.Pic;
            lblLeastFriends.Text = $"{cla.NameClass} class, with {cla.ArrayRegisteredUsersThisClass.Length} active members";


            cla = CL.getLowestAndHighstReviews(ClassesList.highKey);
            lblMostReviews.Text = $"{cla.NameClass}, with {cla.ArrayReviews.Length} reviews.";
            picMostRev.Image = cla.Pic;

            cla = CL.getLowestAndHighstReviews(ClassesList.lowKey);
            int len= 0;
            if(cla.ArrayReviews!=null)
                len= cla.ArrayReviews.Length;
            lblLeastReviews.Text = $"{cla.NameClass}, with {len} reviews.";
            picLeastRev.Image = cla.Pic;






        }

    }
}
