using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    internal class Person
    {
        private string userId;
        private string fName;
        private string lName;
        private string email;
        private string phone;
        // private string password;
        private string dateBorn;
        private string dateRegistion;
        private bool gender;
        private bool admin;
        private bool isAuth;
        private bool isBlocked;
        //  private int calId;
        // private var profilePic;



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
            bool isAuth, bool isBlocked)
        {
            this.userId = userId;
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.phone = phone;
            //  this.password = password;   
            this.dateBorn = dateBorn;
            this.dateRegistion = dateRegistion;
            this.gender = gender;
            this.admin = admin;
            this.isAuth = isAuth;
            this.isBlocked = isBlocked;
            //  this.calId = calId;

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

    }
}
