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
    public partial class likeList : UserControl
    {
        public likeList()
        {
            InitializeComponent();
        }

        public void newLike(Person p)
        {
            profilePic.Image = p.ProfilePic;
            lblFullName.Text = p.FullName;
        }
    }
}
