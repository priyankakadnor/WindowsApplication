using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace WindowsApplication
{
    public partial class ProductForm6 : Form
    {
        FileStream fs;
        public ProductForm6()
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
                fs = new FileStream(@"F:\Project\product.txt", FileMode.Create, FileAccess.Write);
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
                fs = new FileStream(@"F:\Project\product.txt", FileMode.Open, FileAccess.Read);
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

                Product prod = new Product();
                prod.id = Convert.ToInt32(txtid.Text);
                prod.name = txtname.Text;
                prod.price = Convert.ToInt32(txtprice.Text);
                prod.categoryname = txtcategory.Text;

                fs = new FileStream(@"F:\TestFolder\product", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product)binary.Deserialize(fs);
                txtid.Text = prod.id.ToString();
                txtname.Text = prod.name;
                txtprice.Text = prod.price.ToString();
                txtcategory.Text = prod.categoryname;


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
            try
            {

                // dept details accepting from the textboxes & storing in the object
                Product prod = new Product();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"F:\TestFolder\product", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                prod = (Product)binary.Deserialize(fs);
                txtid.Text = prod.id.ToString();
                txtname.Text = prod.name;
                txtprice.Text = prod.price.ToString();
                txtcategory.Text = prod.categoryname;



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

        private void btnXmlwrite_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                prod.id = Convert.ToInt32(txtid.Text);
                prod.name = txtname.Text;
                prod.price = Convert.ToInt32(txtprice.Text);
                prod.categoryname = txtcategory.Text;
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"F:\Project\DeptXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, prod);
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

        private void btnXmlread_Click(object sender, EventArgs e)
        {

            try
            {

                // dept details accepting from the textboxes & storing in the object
                Product prod = new Product();
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"F:\TestFolder1\DeptXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                prod = (Product)xml.Deserialize(fs);
                txtid.Text = prod.id.ToString();
                txtname.Text = prod.name;
                txtprice.Text = prod.ToString();
                txtcategory.Text = prod.categoryname;
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

        private void btnJsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.id = Convert.ToInt32(txtid.Text);
                prod.name = txtname.Text;
                prod.price = Convert.ToInt32(txtprice.Text);
                prod.categoryname = txtname.Text;

                fs = new FileStream(@"F:\TestFolder1\prodJson", FileMode.Open, FileAccess.Read);
                JsonSerializer.Serialize(fs, prod);


                txtid.Text = prod.id.ToString();
                txtname.Text = prod.name;
                txtprice.Text = prod.price.ToString();
                txtcategory.Text = prod.categoryname;
                MessageBox.Show("Done");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void btnJsonread_Click(object sender, EventArgs e)
        {
            try
            {
                Product prod = new Product();
                prod.id = Convert.ToInt32(txtid.Text);
                prod.name = txtname.Text;
                prod.price = Convert.ToInt32(txtprice.Text);
                prod.categoryname = txtcategory.Text;

                fs = new FileStream(@"F:\TestFolder\prodJson", FileMode.Open, FileAccess.Read);
                JsonSerializer.Deserialize<Product>(fs);


                txtid.Text = prod.id.ToString();
                txtname.Text = prod.name;
                txtprice.Text = prod.price.ToString();
                txtcategory.Text = prod.categoryname;
                MessageBox.Show("Done");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void btnsoapwrite_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                prod.id = Convert.ToInt32(txtid.Text);
                prod.name = txtname.Text;
                prod.price = Convert.ToInt32(txtprice.Text);
                prod.categoryname = txtcategory.Text;
               // dept.location = txtlocation.Text;
                fs = new FileStream(@"F:\DemoFolder\Deptsoap", FileMode.Create, FileAccess.Write);
                SoapFormatter so = new SoapFormatter();
                so.Serialize(fs,prod);
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnsoapread_Click(object sender, EventArgs e)
        {

            try
            {
                Product prod = new Product();
                fs = new FileStream(@"F:\TestFolder\prodsoap", FileMode.Open, FileAccess.Read);
                SoapFormatter so = new SoapFormatter();
                prod= (Product)so.Deserialize(fs);
                txtid.Text = prod.id.ToString();
                txtname.Text =prod.name;
                txtprice.Text = prod.price.ToString();
                txtcategory.Text = prod.categoryname;

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
    }
}
   
