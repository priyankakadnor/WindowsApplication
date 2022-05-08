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
    public partial class Form4 : Form
    {
        FileStream fs;
        public Form4()
        {
            InitializeComponent();
        }

        private void write_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(rno.Text);
                string name = nm.Text;
                float percentage = Convert.ToInt64(per.Text);
                string stream = str.Text;
                string City = city.Text;
                fs = new FileStream(@"E:\TestFolder1\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(percentage);
                bw.Write(stream);
                bw.Write(City);
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

        private void read_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"D:\TestFolder1\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                rno.Text = br.ReadInt32().ToString();
                nm.Text = br.ReadString();
                per.Text = br.ReadInt64().ToString();
                str.Text = br.ReadString();
                city.Text = br.ReadString();
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

