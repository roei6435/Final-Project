using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class profilePicture
    {
        private Image img;
        private string userIdImg;
        
        public profilePicture(Image img, string userIdImg)
        {
            this.img = img;
            this.userIdImg = userIdImg;
        }
        public profilePicture( string userIdImg)
        {
            this.img = Properties.Resources.defult_pro_pic2;
            this.userIdImg = userIdImg;
        }
        public string UserId
        {
            get { return userIdImg; }
            set { userIdImg = value; }
        }
        public Image Img
        {
            get { return img; }
            set { img = value; }
        }






    }
}
