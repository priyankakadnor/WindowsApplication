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
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace WindowsApplication
{
    public partial class Form3 : Form
    {
        FileStream fs;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = Location.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"F:\Project\DeptXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                MessageBox.Show("Done");
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"F:\TestFolder1\DeptXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept = (Department)xml.Deserialize(fs);
                txtid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                Location.Text = dept.location;
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

        private void btnbinary2_Click(object sender, EventArgs e)
        {
            try
            {
                //read form contain

                // dept details accepting from the textboxes & storing in the object
                Department dept = new Department();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"F:\TestFolder1\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Department)binary.Deserialize(fs);
                txtid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                Location.Text = dept.location;
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

        private void binarybtn_Click(object sender, EventArgs e)
        {
            //Write Binary
            try
            {


                Department dept = new Department();
                dept.id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = Location.Text;

                fs = new FileStream(@"F:\TestFolder1\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Department)binary.Deserialize(fs);
                txtid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                Location.Text = dept.location;
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

        private void BtnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = Location.Text;

                fs = new FileStream(@"F:\TestFolder1\DeptJson", FileMode.Open, FileAccess.Read);
                JsonSerializer.Serialize(fs, dept);


                txtid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                Location.Text = dept.location;
                MessageBox.Show("Done");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void BtnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = Location.Text;

                fs = new FileStream(@"F:\TestFolder1\DeptJson", FileMode.Open, FileAccess.Read);
                JsonSerializer.Deserialize<Department>(fs);


                txtid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                Location.Text = dept.location;
                MessageBox.Show("Done");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void writebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                string name = txtname.Text;
                string Location = txtlocation.Text;
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(Location);
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

        private void Readbtn_Click(object sender, EventArgs e)
        {

            try
            {
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtid.Text = br.ReadInt32().ToString();
                txtname.Text = br.ReadString();
                txtlocation.Text = br.ReadString();
               
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

        private void createbtn_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnSoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                dept.id = Convert.ToInt32(txtid.Text);
                dept.name = txtname.Text;
                dept.location = txtlocation.Text;
                fs = new FileStream(@"F:\DemoFolder\Deptsoap", FileMode.Create, FileAccess.Write);
                SoapFormatter so = new SoapFormatter();
                so.Serialize(fs, dept);
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

        private void btnsoapread_Click(object sender, EventArgs e)
        {
            try
            {
                Department dept = new Department();
                fs = new FileStream(@"F:\TestFolder1\Deptsoap", FileMode.Open, FileAccess.Read);
                SoapFormatter so = new SoapFormatter();
                dept = (Department)so.Deserialize(fs);
                txtid.Text = dept.id.ToString();
                txtname.Text = dept.name;
                txtlocation.Text = dept.location;

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

        private void filebtn_Click(object sender, EventArgs e)
        {

        }
    }
}




