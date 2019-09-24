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
    public partial class PatientCheckOut : Form
    {
        public PatientCheckOut()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else
            {
                CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
                var x = from a in cb.Paitents
                        where a.Cabin_No == int.Parse(textBox2.Text)
                        && a.Paitent_Name == textBox1.Text
                        select a;

                foreach (Paitent p in x)
                {
                    cb.Paitents.DeleteOnSubmit(p);
                }

                cb.SubmitChanges();
                MessageBox.Show("SUCCESFULLY DELETED");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            this.Hide();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateGridView();

        }

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.Paitents;

        }

        private void PatientCheckOut_Load(object sender, EventArgs e)
        {

        }
    }
}
