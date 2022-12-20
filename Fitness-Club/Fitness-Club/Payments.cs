using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class Payments
    {
        private string idPayment;
        private Person user;
        private Classes classP;
        private string paidVia;
        private string sum;
        private DateTime date;


        public Payments(string idPayment, Person user, Classes classP, string paidVia, string sum, DateTime date)
        {
            this.idPayment = idPayment;
            this.user = user;
            this.classP = classP;
            this.paidVia = paidVia;
            this.sum = sum;
            this.date = date;
        }

        public string IdPayment
        {
            get { return idPayment; }
            set { idPayment = value; }
        }
        public Person User
        {
            get { return user; }
            set { user = value; }
        }
        public Classes ClassP
        {
            get { return classP; }
            set { classP = value; }
        }
        public string PaidVia
        {
            get { return paidVia; }
            set { paidVia = value; }
        }
        public string Sum
        {
            get { return sum; }
            set { sum = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }







    }
}
