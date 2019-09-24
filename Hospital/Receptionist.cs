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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaitentRegistration p = new PaitentRegistration();
            this.Hide();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaitentListUser p1 = new PaitentListUser();
            this.Hide();
            p1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientCheckOut p2 = new PatientCheckOut();
            this.Hide();
            p2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            paitentCabinList p4 = new paitentCabinList();
            this.Hide();
            p4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PaitentDoctorList p = new PaitentDoctorList();
            this.Hide();
            p.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login l = new login();
            this.Hide();
            l.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Receptionist_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BloodBtn_Click(object sender, EventArgs e)
        {
            BloodNeed p = new BloodNeed();
            this.Hide();
            p.Show();
        }
    }
}
