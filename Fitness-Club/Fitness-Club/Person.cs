using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class Person
    {
        private int id;
        private string email;
        private string password;
        private string fname;
        private string lname;
        private string phoneN;
        private DateTime bornDate;
        private string gender;
        private bool admin;
        public string pic;


        public Person(int id,string em,string pass,string fname,string lname,
            string phone,DateTime date,string gender,bool admin,string pic)
        {
            this.id = id;
            this.email = em;
            this.password = pass;
            this.fname = fname; 
            this.lname = lname;
            this.phoneN = phone;
            this.bornDate = date;
            this.gender = gender;   
            this.admin = admin;
            this.pic = pic;
        }
       
        //add-peson
            

        //delete-person
        //edited-data person
        

        
      




    }
}
