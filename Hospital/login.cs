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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "user" )
            {
                if (IsvalidUser(textBox1.Text, textBox2.Text))
                {

                    Receptionist r = new Receptionist();
                    this.Hide();
                    r.Show();

                }

                else
                {
                    MessageBox.Show("UserName and password do not match");

                }

            }

            else
            {
                if (IsvalidUser(textBox1.Text, textBox2.Text))
                {

                    Admin ad = new Admin();
                    this.Hide();
                    ad.Show();


                }

                else
                {

                    MessageBox.Show("UserName and password do not match");

                }
            }


            
          

        }

        bool IsvalidUser(string userName, string password)
       
        {

            dta d  Data()
            //CabinDBDataContext cb = new CabinDBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\AIUB\8th semester\C#\Project\Final\Hospital\HospitalManagementSystem.mdf;Integrated Security=True;Connect Timeout=30");
            var q = from p in cb.Logins
                    where p.Username == textBox1.Text
                    && p.Password == textBox2.Text
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
    

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          textBox2.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

