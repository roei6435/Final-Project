using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    internal class Classes
    {
        private string classId;
        private string nameClass;
        private string place;
        // private Image pic;

        public Classes(string classId, string nameClass, string place)
        {
            this.classId = classId;
            this.nameClass = nameClass;
            this.place = place;
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

    }
}
