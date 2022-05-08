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
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsApplication
{
    public partial class Form6 : Form
    {
        FileStream fs;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                int price = Convert.ToInt32(txtprice.Text);
                string CatagaryName = txtcategory.Text;
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(price);
                bw.Write(CatagaryName);
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

        private void btnread_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtprice.Text = br.ReadString();
                txtcategory.Text = br.ReadString();

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

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            try
            {


                Department dept = new Department();
                dept.id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
               
                fs = new FileStream(@"D:\TestFolder1\Products", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Department)binary.Deserialize(fs);
                txtid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnbinaryread_Click(object sender, EventArgs e)
        {

        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {

        }
    }
    
    }


