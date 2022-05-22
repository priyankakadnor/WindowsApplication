using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class BATCHINFORMATION : Form
    {
        FileStream fs;
        public BATCHINFORMATION()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try { 
            fs = new FileStream(@"F:\Project\book.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            txtid.Text = br.ReadInt32().ToString();
            txtname.Text = br.ReadString();
            txtstart.Text = br.ReadInt32().ToString();
            txtend.Text = br.ReadInt32().ToString();
            txtlocation.Text = br.ReadString();
            txttrainer.Text = br.ReadString();
          


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


        

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                int startdate = Convert.ToInt32(txtstart.Text);
                int enddate = Convert.ToInt32(txtend.Text);
                string location = txtlocation.Text;
                string trainername = txttrainer.Text;
                
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(startdate); ;
                bw.Write(enddate);
                bw.Write(location);
                bw.Write(trainername);
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

    }
}

