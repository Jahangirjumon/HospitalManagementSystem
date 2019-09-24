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
    public partial class DeleteCabin : Form
    {
        public DeleteCabin()
        {
            InitializeComponent();
        }

        private void DeleteCabin_Load(object sender, EventArgs e)
        {

        }

        bool IsvalidCabinNo(int cabinNo)
        {

            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            var q = from p in cb.CabinLists
                    where p.Cabin_No == int.Parse(textBox1.Text)
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
                if (IsvalidCabinNo(int.Parse(textBox1.Text)))
                {
                    CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            
                    var x = from a in cb.CabinLists
                            where a.Cabin_No == int.Parse(textBox1.Text)
                            select a;

                    foreach (CabinList p in x)
                    {
                        cb.CabinLists.DeleteOnSubmit(p);
                    }

                    cb.SubmitChanges();
                    MessageBox.Show("SUCCESFULLY DELETED");
                }

                else
                {
                    MessageBox.Show("Inavlid Cabin No");
                }
            }

        }

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.CabinLists;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void DeleteCabin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }
    }
}
