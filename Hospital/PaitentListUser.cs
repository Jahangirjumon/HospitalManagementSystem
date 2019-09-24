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
    public partial class PaitentListUser : Form
    {
        public PaitentListUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptionist r = new Receptionist();
            this.Hide();
            r.Show();
        }

        private void PaitentListUser_Load(object sender, EventArgs e)
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.Paitents;
        }

        private void PaitentListUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
