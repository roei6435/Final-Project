using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class Reviews
    {
        private string idReviews;
        private Person user;
        private Classes classR;
        private string reviewContent;
        private string rating;
        private DateTime date;


        public Reviews(string idReviews,Person user, Classes classR,string reviewContent,string rating,DateTime date)
        {
            this.idReviews = idReviews;
            this.user = user;
            this.classR = classR;
            this.reviewContent = reviewContent;
            this.rating= rating;
            this.date = date;
        }

        public string IdReviews
        {
            get { return idReviews; }
            set { idReviews = value; }
        }
        public Person User
        {
            get { return user; }
            set { user = value; }
        }
        public Classes ClassR
        {
            get { return classR; }
            set { classR = value; }
        }
        public string ReviewContent
        {
            get { return reviewContent; }
            set { reviewContent = value; }
        }
        public string Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }









    }
}
