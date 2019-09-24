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
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else if (textBox2.Text == "")
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

            else if (textBox6.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }

            else
            {
                CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                Doctor c1 = new Doctor();
                c1.Doctor_Name = textBox1.Text;
                c1.Cabin_No = textBox2.Text;
                c1.Phone = textBox3.Text;
                c1.Address = textBox4.Text;
                c1.Working_Hour = int.Parse(textBox5.Text);
                c1.Salary = int.Parse(textBox6.Text);

                cb.Doctors.InsertOnSubmit(c1);
                cb.SubmitChanges();
                updateGridView();
                MessageBox.Show("Succesfully Added");

                DoctorList f2 = new DoctorList(this);
                this.Hide();
                f2.Show();
            }

        }

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        private void AddDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorList d1 = new DoctorList();
            this.Hide();
            d1.Show();

        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
