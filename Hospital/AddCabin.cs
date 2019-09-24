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
    public partial class AddCabin : Form 
    {
        public AddCabin()
        {
            InitializeComponent();

        }

        private void AddCabin_Load(object sender, EventArgs e)
        {

            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
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
            else
            {
                CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
                CabinList c1 = new CabinList();
                c1.Cabin_No = int.Parse(textBox1.Text);
                c1.Type = textBox2.Text;
                c1.Price = int.Parse(textBox3.Text);
                c1.Doctor_Name = textBox4.Text;

                cb.CabinLists.InsertOnSubmit(c1);
                cb.SubmitChanges();
                updateGridView();
                MessageBox.Show("Succesfully Added");
                Form1 f2 = new Form1(this);
                this.Hide();
                f2.Show();
            }

        }

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        private void AddCabin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1(this);
            this.Hide();
            f2.Show();

        }
 
        
    }
}
