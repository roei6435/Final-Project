using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Fitness_Club.Forms_admin
{
    public partial class Feed : Form
    {
        private List<Person> listP;
        private List<Tweets> fullOfTweets;
        private List<Tweets> listActivityNow;
        public static List<Person> hideList=new List<Person>();
        public static string controller = "TweetAdministrators#";
        private int start = 0;
        private int jump = 7;
        private bool showThelastTeweet = true;
        private DateTime dateSelected;
        public static bool refrhshOn = true;
        public bool firstLoad = true;
        private DispatcherTimer dispatcherTimer;

        public Feed(List<Person>listP)
        {   
            InitializeComponent();
            this.listP = listP;
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
        private void AdministratorCenter_Load(object sender, EventArgs e)
        {

            dispatcherTimer = new DispatcherTimer();                //CREATE TIMER
            dispatcherTimer.Tick += new EventHandler(dispatcherTimerLoading_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            //LOAD DATA FROM DB
            loadTheme();
            string responseFromServer= ConnectWithServer.callToServer(controller, "getAllDataAboutTweet#", "");
            if (responseFromServer != string.Empty)
            {
                fullOfTweets = ConnectWithServer.convartDataToListOfTweets(responseFromServer, listP);
            }
            //PUT DATE AND DATA TWEETS
            dateSelected = DateTime.Now;
            comboBoxDay.SelectedIndex = dateSelected.Day - 1;
            comboBoxMonth.SelectedIndex = dateSelected.Month - 1;
            ComboBoxYear.SelectedIndex = ComboBoxYear.Items.Count - 1;
            listActivityNow = getAllTweetsByDate(dateSelected);
            if (listActivityNow is null)
            {
                listActivityNow = fullOfTweets;               
            }
            dispalyLastTweets(listActivityNow, start);
            loadListAdmins();             //ONLY IN FIRST LOAD.
            profilePic.Image = AdminScreen.userLogged.ProfilePic;

            dispatcherTimer.Start();
        }
        public void dispatcherTimerLoading_Tick(object sender, EventArgs e)
        {
            panelLoading.Visible = true;
            Thread.Sleep(2000);
            panelLoading.Visible = false;
            dispatcherTimer.Stop();
        }

        //FUNCTION FOR DISPALYING THE LAST TWEETS.
        private void dispalyLastTweets(List<Tweets> list, int start)
        {
            tweetsContainer1.Controls.Clear();
            try
            {
                if (!more.Visible) more.Visible = true;
                for (int i = start; i < start + jump; i++)
                {
                    if (!hideList.Contains(list[i].FromPerson))
                    {
                        BubbleOfTweet tweet = new BubbleOfTweet(listP);
                        tweet.newBubble(list[i]);
                        tweetsContainer1.Controls.Add(tweet);
                    }

                }
                tweetsContainer1.Controls.Add(more);
            }
            catch
            {
                more.Visible = false;
            }


        }

        //GET THE ADMINS LIST.
        private void loadListAdmins()
        {
            if (firstLoad)
            {
                PersonList PL = new PersonList(listP);
                List<Person> listOfAdmins = PL.getOnlyUsersOrAdminsFromListPerson("admins");
                for (int i = 0; i < listOfAdmins.Count; i++)
                {
                    personsList newP = new personsList();
                    newP.newPerson(listOfAdmins[i]);
                    PanelOfAdminsList.Controls.Add(newP);
                }
                tweetsContainer1.Controls.Add(more);
            }
        }

        //GET THE ALL TWEETS BY DATE SELECTED BY USER.
        private List<Tweets> getAllTweetsByDate(DateTime date)
        {
            List<Tweets> result = new List<Tweets>();
            foreach(Tweets tweet in fullOfTweets)
            {
                if (tweet.Date.ToShortDateString() == date.ToShortDateString()) 
                {
                    result.Add(tweet);
                }
            }
            if (result.Count > 0)
                return result;
            return null;
        }

        //CHECK IF HIDDENLIST CONTAINS ALL FROM THE LIST ACTIVITY NOW TWEETS
        private bool containList()
        {
            for(int i = 0; i < listActivityNow.Count; i++)
            {
                if (!hideList.Contains(listActivityNow[i].FromPerson))
                {
                    return false;
                }
            }
            return true;
        }

        //UPDATES THE ACTIVE LIST OF TWEETS
        private void displayByDateOnChanged()
        {
            try
            {
                showThelastTeweet = false;
                string day = comboBoxDay.Text, month = (comboBoxMonth.SelectedIndex + 1).ToString(), year = ComboBoxYear.Text;
                dateSelected = Convert.ToDateTime($"{day}/{month}/{year}");
                listActivityNow = getAllTweetsByDate(dateSelected);
                if (listActivityNow is null || containList())
                {
                    tweetsContainer1.Controls.Clear();
                    tweetsContainer1.Controls.Add(panelEmpty);
                    panelEmpty.Visible = true;
                }
                else
                {
                    start = 0;
                    dispalyLastTweets(listActivityNow, start);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //NEW TWEET BY USER, UPDATE THE DATA AND DISPLAYING TWEETS
        private void btnTweet_Click(object sender, EventArgs e)
        {
            if(txtBoxContent.Text != string.Empty)
            {
                string fullInput = AdminScreen.static_userId + "#" + txtBoxContent.Text + "#";
                string addNewTweet = ConnectWithServer.callToServer(controller, "addNewTweet#", fullInput);
                if (bool.Parse(addNewTweet))
                {
                    tweetsContainer1.Controls.Clear();
                    start = 0;
                    ComboBoxRelAndUpd.SelectedIndex = 1;
                    firstLoad = false;
                    AdministratorCenter_Load(sender, e);
                    this.Refresh();
                    displayByDateOnChanged();
                }
                else
                {
                    MessageBox.Show("Opps somthing worng...\nTty again.");
                }
                txtBoxContent.Text = string.Empty;
            }

        }


        //IN EACH VIEW 8 TWEETS ARE SHOWN, THE FUNCTION LOADS THE NEXT 8
        private void more_Click(object sender, EventArgs e)
        {
            start += jump;
            if (showThelastTeweet)
            {

                dispalyLastTweets(listActivityNow, start);
                if (start + jump == listActivityNow.Count)
                {
                    more.Visible = false;
                    start = 0;
                }
            }
            else
            {
                dispalyLastTweets(listActivityNow, start);
                if (start + jump == listActivityNow.Count)
                {
                    more.Visible = false;
                    start = 0;
                }
            }

                

        }

        //A FUNCTION SORTS THE LIST BY POPULARITY, TWEETS - LIKES
        private List<Tweets> returnListOrganizedByRelevance(List<Tweets> list)
        {

            List<Tweets> notLikes = new List<Tweets>();
            List<Tweets> withLikes = new List<Tweets>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ArrLikesThisTweet is null)
                {
                    notLikes.Add(list[i]);
                }
                else
                {
                    withLikes.Add(list[i]);
                }
            }
            for (int i = 0; i < withLikes.Count - 1; i++)
            {
                for (int j = i + 1; j < withLikes.Count; j++)
                {
                    if (withLikes[i].ArrLikesThisTweet.Length < withLikes[j].ArrLikesThisTweet.Length)
                    {
                        Tweets tmp = withLikes[i];
                        withLikes[i] = withLikes[j];
                        withLikes[j] = tmp;
                    }

                }
            }
            return withLikes.Concat(notLikes).ToList();
        }

        //CHOOSING WHETHER TO DISPLAY ACCORDING TO POPULARITY OR RECENTNESS
        private void ComboBoxRelAndUpd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxRelAndUpd.SelectedIndex == 0)    //BY POPULARY 
            {
                if (listActivityNow != null)
                {
                    listActivityNow = returnListOrganizedByRelevance(listActivityNow);
                    start = 0;
                    dispalyLastTweets(listActivityNow, start);
                }
                else
                {
                    panelEmpty.Visible=true;
                }
            }
            else                                 //BY RECENTNES
            {
                if (getAllTweetsByDate(dateSelected) != null)
                {
                    listActivityNow = getAllTweetsByDate(dateSelected);
                    start = 0;
                    dispalyLastTweets(listActivityNow, start);
                }
                else
                {
                    panelEmpty.Visible = true;
                }

            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (personsList.needRefresh)
            {
                displayByDateOnChanged();
                personsList.needRefresh = false;

            }

        }

        //private void btnCalander_Click(object sender, EventArgs e)
        //{
        //    if (!paneDate.Visible)
        //    {
        //        paneDate.Visible = true;
        //    }
        //    else
        //    {
        //        paneDate.Visible = false;
        //    }
        //}
        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMonth.Text != string.Empty && ComboBoxYear.Text != string.Empty)
            {
                displayByDateOnChanged();
            }
        }

        private void comboBoxYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDay.Text != string.Empty && ComboBoxYear.Text != string.Empty)
            {
                displayByDateOnChanged();
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDay.Text != string.Empty && comboBoxMonth.Text != string.Empty)
            {
                displayByDateOnChanged();

            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxContent.Text = string.Empty;
        }


        private void txtBoxContent_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtBoxContent.Text == "What do you want to tweet?")
            {
                txtBoxContent.Text=string.Empty;
            }
        }
    }
}
