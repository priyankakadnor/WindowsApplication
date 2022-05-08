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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text=="priyanka"||txtpass.Text=="priya123")
            {
                MessageBox.Show("Successfully Login....");
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
        }
    }
}
