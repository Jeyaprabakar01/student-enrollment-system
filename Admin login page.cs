using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ditec
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string email = txtemail.Text;
            string pass = txtpassword.Text;

            if ((email == "jasy2k19@gmail.com") && (pass == "jasy2019"))

            {
                MessageBox.Show("Login Success ! ");
                this.Hide();
                new Form9().Show();


            }
            else
            {
                MessageBox.Show("Login not Success !");
            }

            
        
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
