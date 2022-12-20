using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class Classes
    {
        private string classId;
        private string nameClass;
        private string place;
        private bool activity;
        private string about;
        private Image pic;
        private Person[] arrayRegisteredUsersThisClass = null;
        private Reviews[] arrayReviews = null;

        public Classes(string classId, string nameClass, string place, bool activity, string about, Image pic)
        {
            this.classId = classId;
            this.nameClass = nameClass;
            this.place = place;
            this.activity = activity;
            this.about = about;
            this.pic = pic;
        }

        public string ClassId
        {
            get { return classId; }
            set { classId = value; }
        }
        public string NameClass
        {
            get { return nameClass; }
            set { nameClass = value; }
        }
        public string Place
        {
            get { return place; }
            set { place = value; }
        }
        public bool Activity
        {
            get { return activity; }
            set { activity = value; }
        }
        public string About
        {
            get { return about; }
            set { about = value; }
        }
        public Image Pic
        {
            get { return pic; }
            set { pic = value; }
        }
        public Person[] ArrayRegisteredUsersThisClass
        {
            get { return arrayRegisteredUsersThisClass; }
            set { arrayRegisteredUsersThisClass = value; }
        }
        public Reviews [] ArrayReviews
        {
            get { return arrayReviews; }
            set { arrayReviews = value; }
        }


    }
}
