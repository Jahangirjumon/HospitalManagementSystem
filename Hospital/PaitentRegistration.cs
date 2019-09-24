using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class PaitentRegistration : Form
    {
        public PaitentRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else if (textBox2.Text=="")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }


            else
            {
                CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                Paitent p1 = new Paitent();
            p1.Paitent_Name = textBox1.Text;
            p1.Cabin_No = int.Parse(textBox2.Text);
            p1.Phone = textBox3.Text;
            p1.Room_Type = textBox4.Text;
            p1.Price = int.Parse(textBox5.Text);
            p1.Date = textBox6.Text;

            cb.Paitents.InsertOnSubmit(p1);
            cb.SubmitChanges();
            updateGridView();
            MessageBox.Show("Succesfully Registerd");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            this.Hide();
            r.Show();
        }

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        private void PaitentRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PaitentRegistration_Load(object sender, EventArgs e)
        {

        }

    }
}
