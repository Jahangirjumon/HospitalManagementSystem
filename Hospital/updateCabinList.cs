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
    public partial class updateCabinList : Form
    {
        public updateCabinList()
        {
            InitializeComponent();
        }

        private void updateCabinList_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
                    textBox2.Text = x.FirstOrDefault().Type;
                    textBox3.Text = x.First().Price.ToString();
                    textBox4.Text = x.First().Doctor_Name;


                    cb.SubmitChanges();
                    dataGridView1.DataSource = x.ToList();

                }

                else
                {
                    MessageBox.Show("Invalid Cabin No");

                }

            }
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

        void updateGridView()
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.CabinLists;

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
                    if (textBox2.Text == "")
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
                        var x = from a in cb.CabinLists
                                where a.Cabin_No == int.Parse(textBox1.Text)
                                select a;

                        x.FirstOrDefault().Type = textBox2.Text;
                        x.First().Price = int.Parse(textBox3.Text);
                        x.First().Doctor_Name = textBox4.Text;

                        cb.SubmitChanges();
                        dataGridView1.DataSource = x.ToList();
                        MessageBox.Show("Updated");
                    }
                }

                else
                {
                    MessageBox.Show("Invalid Cabin No");

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void updateCabinList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateGridView();
        }
    }
}
