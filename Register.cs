using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name={txtname.Text}\nEmail id ={txtemail.Text}\nContact Number={txtno.Text}\nAdddress={txtadd}");
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
