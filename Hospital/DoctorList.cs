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
    public partial class DoctorList : Form
    {
        AddDoctor f2;
        public DoctorList()
        {
            InitializeComponent();
        }

        public DoctorList(AddDoctor f2)
        {
            InitializeComponent();
            this.f2 = f2;
        }

        private void DoctorList_Load(object sender, EventArgs e)
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.Doctors;
        }

        private void DoctorList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoctor A1 = new AddDoctor();
            this.Hide();
            A1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin A2 = new Admin();
            this.Hide();
            A2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDoctor u = new updateDoctor();
            this.Hide();
            u.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteDoctor d = new DeleteDoctor();
            this.Hide();
            d.Show();
        }
    }
}
