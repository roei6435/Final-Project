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
    public partial class addPayment : Form
    {
        private Person userPay;
        public static string paymentDone;
        public addPayment(Person userPay)
        {
            this.userPay = userPay;
            InitializeComponent();
         
        }

        private void addPayment_Load(object sender, EventArgs e)
        {
            paymentDone = "false";
            textBoxPerson.Text = userPay.FullName;
            txtBoxDate.Text = DateTime.Now.ToShortDateString();
            comboBoxClasses.Items.Clear();
            comboBoxClasses.Items.Add("None...");
            if (userPay.ClassesArray != null)
            {
                comboBoxClasses.Items.Clear();
                foreach (Classes c in userPay.ClassesArray)
                {
                    comboBoxClasses.Items.Add(c.NameClass);

                }

            }
            comboBoxClasses.SelectedIndex = 0;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxAmount.Text != string.Empty && textBoxAmount.Text.All(char.IsDigit)&&comboBoxClasses.SelectedItem.ToString()!="None...")
            {
                ClassesList CL = new ClassesList(userPay.ClassesArray.ToList());
                Classes classPaid = CL.findClassByName(comboBoxClasses.SelectedItem.ToString());
                //03/01/2023
                
                string [] fullDateInArray = txtBoxDate.Text.Split('/');
                string fullDate= $"{fullDateInArray[1]}/{fullDateInArray[0]}/{fullDateInArray[2]}";

                txtBoxDate.Text= DateTime.Now.ToShortDateString();

                string fullInputFromClient = userPay.UserId + "#" + classPaid.ClassId + "#" + fullDate + "#" + comboBoxPaidVia.SelectedItem + "#" + textBoxAmount.Text + "#";
                paymentDone = ConnectWithServer.callToServer(Clients.controller, "addPaymentByUserAndClassId#", fullInputFromClient);
                if (bool.Parse(paymentDone))
                {
                    MessageBox.Show("The payment was succesful.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Oops, somthing worng...");
                }
            }
            else if(comboBoxClasses.Items[0].ToString() == "None...")
            {
                MessageBox.Show("This user is not active in any classes.");
            }
            else
            {
                MessageBox.Show("Plese enter amount.");
            }

            
        }

    }
}
