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
    public partial class personsList : UserControl
    {
        private List<Person> persons=new List<Person>();
        public static bool needRefresh=false;
        public personsList()
        {
            InitializeComponent();
        }

        private void personsList_Load(object sender, EventArgs e)
        {
        }
        //DISPLAYING
        public void newPerson(Person p)
        {
            lblFullName.Text = p.FullName;
            lblDateRegistion.Text = "Activity adminstor from: "+p.DateRegistion;
            string[] fullDataOfLevelExprince = MyAccount.getLevelExprinceAndCountDays(p.DateRegistion).Split(' ');        
            lblLevel.Text = fullDataOfLevelExprince[0];
            lblLevel.ForeColor = Color.FromName(fullDataOfLevelExprince[1]);
            profilePic.Image = p.ProfilePic;
            this.Tag = p.UserId;
            persons.Add(p);

        }
        //UPDATE THE HIDDEN LIST IN THE FORM ADMINSTOR CENTER
        public void showOrHideTweetsFromThisAdmin_CheckedChanged(object sender, EventArgs e)
        {
            PersonList PL = new PersonList(persons);
            Person hidden= PL.findPersonById(this.Tag.ToString());
            if (!showOrHideTweetsFromThisAdmin.Checked)
            {
                Forms_admin.AdministratorCenter.hideList.Add(hidden);                
            }
            else
            {
                Forms_admin.AdministratorCenter.hideList.Remove(hidden);
            }
            needRefresh = true;


        }

        private void showOrHideTweetsFromThisAdmin_MouseHover(object sender, EventArgs e)
        {
            lblTweet.Visible = true;
        }

        private void showOrHideTweetsFromThisAdmin_MouseLeave(object sender, EventArgs e)
        {
            lblTweet.Visible = false;
        }
    }
}
