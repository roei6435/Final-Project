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
    public partial class BubbleOfTweet : UserControl
    {
        private Tweets nowSelectdTweet = null;
        private bool needRefrhsh=true;
        private List<Person> listP;
        public BubbleOfTweet(List<Person>listP)
        {
            InitializeComponent();
            this.listP = listP;
        }

        private void UserControlBubbleSmall_Load(object sender, EventArgs e)
        {

        }

       // UPDATE THE SIZE OF THE BUBBLE ACCORDING TO THE LENGTH OF THE TWEET
        private void bubbleSize(int routine)
        {
            this.Size = new Size(630, 115);
            int line;
            if (routine < 3) line = 36;
            else line = 20;
            for (int i = 0; i < routine; i++)
            {
                this.Height += line;
                panelBubbleData.Height += line;
                int x = panelButtons.Location.X, y = panelButtons.Location.Y;
                lblContent.Height += line;
                panelButtons.Location = new Point(x, y + line);
            }
        }
        public void newBubble(Tweets tweet)
        {
            int routine = tweet.Content.Length / 55;
            bubbleSize(routine);
            displayDataTweet(tweet);
        }
        private void displayDataTweet(Tweets tweet)
        {
            nowSelectdTweet = tweet;
            if (tweet.ArrLikesThisTweet != null)            //if have likes to this message
            {
                lblCounter.Text = tweet.ArrLikesThisTweet.Length.ToString();       //show count likes
                lblCounter.Visible = true;

                List<Person> listP = tweet.ArrLikesThisTweet.ToList();
                Person iLikeIt = listP.Find(p => p == AdminScreen.userLogged);         //if the logged user has already given a like
                if (iLikeIt != null)
                {
                    picLikeOn.Visible = true;
                }
                else
                {
                    picLikeOn.Visible = false;
                }
            }
            lblFname.Text =  " "+tweet.FromPerson.FirstName;                         //if it's my message=>write 'me'
            if (tweet.FromPerson == AdminScreen.userLogged)
            {
                lblFname.Text = "  Me";
            }
            profilePic.Image = tweet.FromPerson.ProfilePic;
            if(tweet.Date.Date== DateTime.Now.Date)
            {
                lblTime.Text = tweet.Date.ToString("HH:mm");
            }
            else
            {         
                string tweetedBefore = LoginANDRegister.lastConnectDiff(tweet.Date.ToString().Split(' ')[0]);
                lblTime.Text = tweetedBefore;
            }
            lblContent.Text = tweet.Content;
        }
        private void like()
        {
            string likeToTweet = ConnectWithServer.callToServer(Forms_admin.AdministratorCenter.controller, "likeToTweet#", AdminScreen.static_userId + "#" + nowSelectdTweet.MessageId);
            if (bool.Parse(likeToTweet))
            {
                picLikeOn.Visible = true;
                picLikeOf.Visible = false;
                nowSelectdTweet.ArrLikesThisTweet = ConnectWithServer.getPersonArrayLikeMessageByMessageId(nowSelectdTweet.MessageId, listP);
                lblCounter.Text = nowSelectdTweet.ArrLikesThisTweet.Length.ToString();
                lblCounter.Visible = true;
            }
            else
            {
                MessageBox.Show("Opps, somthing worng...");
            }
            
        }
        private void unlike()
        {
            string unlikeToTweet = ConnectWithServer.callToServer(Forms_admin.AdministratorCenter.controller, "unlikeToTweet#", AdminScreen.static_userId + "#" + nowSelectdTweet.MessageId);
            if (bool.Parse(unlikeToTweet))
            {
               
                picLikeOn.Visible = false;
                picLikeOf.Visible = true;
                nowSelectdTweet.ArrLikesThisTweet = ConnectWithServer.getPersonArrayLikeMessageByMessageId(nowSelectdTweet.MessageId, listP);
                int counter = 0;lblCounter.Visible = false;
                if (nowSelectdTweet.ArrLikesThisTweet != null)
                {
                    counter = nowSelectdTweet.ArrLikesThisTweet.Length;
                    lblCounter.Visible = true;
                    lblCounter.Text = counter.ToString();
                }

            }
            else
            {
                MessageBox.Show("Opps, somthing worng...");
            }

        }

        private void picLikeOf_Click(object sender, EventArgs e)     //click for like
        {
            try
            {
                like();
                needRefrhsh = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void picLikeOn_Click(object sender, EventArgs e)        //click for unlike
        {
            try
            {
                unlike();
                needRefrhsh = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblCounter_Click(object sender, EventArgs e)
        {
            lblTitleListOfLikes.Text = $"Liked this tweet by {nowSelectdTweet.FromPerson.FirstName}";
            panelLikes.Visible = true; panelPersonData.Visible = false;
            int y = panelBubbleData.Location.Y;
            panelLikes.Location = new Point(-3, y);
            panelLikes.Size = panelBubbleData.Size;
            if (needRefrhsh)
            {
                panelLikes.Controls.Clear();
                panelLikes.Controls.Add(btnBack);
                panelLikes.Controls.Add(lblTitleListOfLikes);
                panelLikes.Controls.Add(panelLine);
                for (int i = 0; i < nowSelectdTweet.ArrLikesThisTweet.Length; i++)
                {
                    likeList like = new likeList();
                    like.newLike(nowSelectdTweet.ArrLikesThisTweet[i]);
                    panelLikes.Controls.Add(like);

                }
                needRefrhsh = false;
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            panelLikes.Visible = false;
            panelPersonData.Visible = true;
        }

        private void hidePic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You want hide this tweet?");
            this.Hide();
        }

    }
}
