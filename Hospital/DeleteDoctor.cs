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
    public partial class DeleteDoctor : Form
    {
        public DeleteDoctor()
        {
            InitializeComponent();
        }

        bool IsvalidDoctor(string name)
        {

            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            var q = from p in cb.Doctors
                    where p.Doctor_Name == textBox1.Text
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

        private void button1_Click(object sender, EventArgs e)
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

                    foreach (Doctor p in x)
                    {
                        cb.Doctors.DeleteOnSubmit(p);
                    }

                    cb.SubmitChanges();
                    MessageBox.Show("SUCCESFULLY DELETED");
                }
                else
                {
                    MessageBox.Show("Invalid Name");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoctorList d = new DoctorList();
            this.Hide();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.Doctors;

        }

        private void DeleteDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
