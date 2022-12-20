using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class Tweets
    {
        private string tweetsId; 
        private Person fromPerson;
        private DateTime date;
        private string content;
        private Person[] arrLikesThisTweet = null;

        public Tweets(string tweetsId, Person person,DateTime date ,string content)
        {
            this.tweetsId = tweetsId;
            this.fromPerson = person;   
            this.date = date;   
            this.content = content; 
        }
        public string MessageId
        {
            get { return tweetsId; }
            set { tweetsId = value; }
        }
        public Person FromPerson
        {
            get { return fromPerson; }
            set { fromPerson = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public Person [] ArrLikesThisTweet
        {
            get { return arrLikesThisTweet; }
            set { arrLikesThisTweet = value;}
        }




    }
}
