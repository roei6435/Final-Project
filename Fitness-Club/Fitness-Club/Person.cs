using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class Person
    {
        private string userId;
        private string fName;
        private string lName;
        private string email;
        private string phone;
        private string dateBorn;
        private string dateRegistion;
        private string lastConnect;
        private Image profilePic;
        private bool gender;
        private bool admin;
        private bool isAuth;
        private bool isBlocked;
        private Classes[] classArray = null;
        private Payments[] paymentsArray = null;




        public Person()
        {
            Console.WriteLine("ok");
        }
        public Person(string userId, string email, string fName)
        {
            this.userId = userId;
            this.email = email;
            this.fName = fName;
        }
        public Person(string userId, string fName, string lName, string email, string phone,
            string dateBorn, string dateRegistion, bool gender, bool admin,
            bool isAuth, bool isBlocked,Image profilePic,string lastConnect)
        {
            this.userId = userId;
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.phone = phone;  
            this.dateBorn = dateBorn;
            this.dateRegistion = dateRegistion;
            this.lastConnect = lastConnect;
            this.profilePic = profilePic;
            this.gender = gender;
            this.admin = admin;
            this.isAuth = isAuth;
            this.isBlocked = isBlocked;
        }


        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string FullName
        {
            get { return fName+" "+lName; }
            set { fName = value; }
        }
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string DateBorn
        {
            get { return dateBorn; }
            set { dateBorn = value; }
        }
        public string DateRegistion
        {
            get { return dateRegistion; }
            set { dateRegistion = value; }
        }
        public string LastConnect
        {
            get { return lastConnect; }
            set { lastConnect = value; }
        }
        public Image ProfilePic
       { 
            get { return profilePic; }
            set { profilePic = value; }
        }
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public bool IsAdmin
        {
            get { return admin; }
            set { admin = value; }
        }
        public bool IsAuth
        {
            get { return isAuth; }
            set { isAuth = value; }
        }

        public bool IsBlocked
        {
            get { return isBlocked; }
            set { isBlocked = value; }
        }
        public Classes[] ClassesArray
        {
            get { return classArray; }
            set { classArray = value; }
        }
        public Payments[] PaymentsArray
        {
            get { return paymentsArray; }
            set { paymentsArray = value; }
        }

        public int getSumOfPaidInTheLastMonth()
        {
           if(paymentsArray is null) return 0;
            int monthNow = DateTime.Now.Month, sum = 0;
           foreach (Payments payments in paymentsArray)
            {
                if (payments.Date.Month == monthNow)
                {
                    sum += int.Parse(payments.Sum);
                }
            }
           return sum;
        }

    }
}
