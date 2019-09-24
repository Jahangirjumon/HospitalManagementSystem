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
    public partial class PaitentList : Form
    {
        public PaitentList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin f3 = new Admin();
            this.Hide();
            f3.Show();
        }

        private void PaitentList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PaitentList_Load(object sender, EventArgs e)
        {
            CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            dataGridView1.DataSource = cb.Paitents;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
