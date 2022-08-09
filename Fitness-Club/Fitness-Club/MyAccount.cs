using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Fitness_Club
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        string str = "Data Source=LAPTOPRBD\\SQLEXPRESS02;Initial Catalog=RoeiDB;Integrated Security=True";

        private void picBoxEditPicPropfile_Click(object sender, EventArgs e)
        {
   
                OpenFileDialog od = new OpenFileDialog();
                od.FileName = "";
                od.Filter = "Supported Imeges|*.jpg;*.png";
                if (od.ShowDialog() == DialogResult.OK)
                {
                    profilePic.Load(od.FileName);
                    btnSaveChenge.Visible = true;
                }

        }

        private void btnSaveChenge_Click(object sender, EventArgs e)
        {
         
            
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                var image = new ImageConverter().ConvertTo(profilePic.Image, typeof(Byte[]));
                cmd.Parameters.AddWithValue("@image", image);
                cmd.CommandText = "INSERT INTO images (img) VALUES(@image)";
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("imge added");
                else
                    MessageBox.Show("not");
                con.Close();
            
        }
    }
}
