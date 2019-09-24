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
    public partial class BloodNeed : Form
    {
        public BloodNeed()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Receptionist bl = new Receptionist();
            this.Hide();
            bl.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

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

            else
            {
                CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                Blood bl = new Blood
                {
                    Blood_Group = textBox1.Text,
                    Available = int.Parse(textBox2.Text),
                };

                cb.Bloods.InsertOnSubmit(bl);
                cb.SubmitChanges();
                UpdateGridView();
            }
           
           }

        void UpdateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.Bloods;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fillup Information Correctly");
            }
            else
            {
                CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
                var x = from a in cb.Bloods
                        where a.Blood_Group == textBox1.Text
                        select a;

                textBox2.Text = x.FirstOrDefault().Available.ToString();

                dataGridView1.DataSource = x.ToList();
            }
        }

      
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = string.Empty;
        }

        private void BloodNeed_Load(object sender, EventArgs e)
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
            dataGridView1.DataSource = cb.Bloods;
        }

        private void BloodNeed_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        }

    }
