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
    public partial class updateDoctor : Form
    {
        public updateDoctor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsvalidDoctor(textBox1.Text))
            {
                CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                var x = from a in cb.Doctors
                        where a.Doctor_Name == textBox1.Text
                        select a;
                x.First().Cabin_No = textBox2.Text;
                x.First().Phone = textBox3.Text;
                x.First().Address = textBox4.Text;
                x.First().Working_Hour = int.Parse(textBox5.Text);
                x.First().Salary = int.Parse(textBox6.Text);

                cb.SubmitChanges();
                dataGridView1.DataSource = x.ToList();
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.Doctors;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        bool IsvalidDoctor(string name)
        {

            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            var q = from p in cb.Doctors
                    where p.Doctor_Name== textBox1.Text
                    select p;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }

            else
            {
                if (IsvalidDoctor(textBox1.Text))
                {

                    CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                    var x = from a in cb.Doctors
                            where a.Doctor_Name == textBox1.Text
                            select a;
                    textBox2.Text = x.FirstOrDefault().Cabin_No;
                    textBox3.Text = x.First().Phone;
                    textBox4.Text = x.First().Address;
                    textBox5.Text = x.First().Working_Hour.ToString();
                    textBox6.Text = x.First().Salary.ToString();

                    cb.SubmitChanges();
                    dataGridView1.DataSource = x.ToList();
                }
                else
                {
                    MessageBox.Show("No match Found");
                }
            }
        }

        private void updateDoctor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoctorList d = new DoctorList();
            this.Hide();
            d.Show();
        }

        private void updateDoctor_Load(object sender, EventArgs e)
        {

        }

    }
}
