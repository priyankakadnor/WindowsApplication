using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsApplication
{
    public partial class Form5 : Form
    {
        FileStream fs;
        public Form5()
        {
            InitializeComponent();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txteid.Text);
                string name = txtename.Text;
                string Designation =txtdesig.Text;
                int Salary= Convert.ToInt32(txtsalary.Text);
                string Department = txtdept.Text;
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(Designation);
                bw.Write(Salary);
                bw.Write(Department);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                fs.Close(); // free the resouce 
            }
        }

        private void Read_Click(object sender, EventArgs e)

        {
            try
            {
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txteid.Text = br.ReadInt32().ToString();
                txtename.Text = br.ReadString();
                txtdesig.Text = br.ReadString();
                txtsalary.Text = br.ReadInt32().ToString();
                txtdept.Text = br.ReadString();
                br.Close();  // close the opeation reader
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close(); // free the resouce 
            }
        }

    }
}

