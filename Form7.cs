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
namespace WindowsApplication
{
    public partial class Form7 : Form
    {
        FileStream fs;
        public Form7()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtid.Text);
                string name = txtbook.Text;
                string authorname = txtauthornm.Text;
                int price = Convert.ToInt32(txtprice.Text);
                fs = new FileStream(@"F:\Project\Priyanka.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(authorname);
                bw.Write(price);
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

        private void btnbinarywrite_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.id = Convert.ToInt32(txtid.Text);
            b.name = txtbook.Text;
            b.price = Convert.ToInt32(txtprice.Text);
         

            fs = new FileStream(@"D:\TestFolder1\product", FileMode.Open, FileAccess.Read);
            BinaryFormatter binary = new BinaryFormatter();
            b = (Book)binary.Deserialize(fs);
            txtid.Text = b.id.ToString();
         
            txtprice.Text = b.price.ToString();
            


        }

        private void btnXmlwrite_Click(object sender, EventArgs e)
        {

            try
            {
                Book b = new Book();
                b.id = Convert.ToInt32(txtid.Text);
                b.name = txtbook.Text;
                b.authorname = txtauthornm.Text;
                b.price = Convert.ToInt32(txtprice.Text);
      
                // default file extension is .dat file (data file) / binary file
                fs = new FileStream(@"F:\Project\bookXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs,b);
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

            private void btnjsonwrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book b = new Book();
                b.id = Convert.ToInt32(txtid.Text);
                b.name = txtbook.Text;
                b.authorname = txtauthornm.Text;
               b.price = Convert.ToInt32(txtprice.Text);
                

                fs = new FileStream(@"F:\TestFolder\bookJson", FileMode.Open, FileAccess.Read);
                JsonSerializer.Serialize(fs,b);


                txtid.Text = b.id.ToString();
                txtbook.Text =b.name;
               
                MessageBox.Show("Done");
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try 
            { 

            fs = new FileStream(@"F:\Project\product.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            txtid.Text = br.ReadInt32().ToString();
            txtbook.Text = br.ReadString();
            txtauthornm.Text = br.ReadString();
            txtprice.Text = br.ReadString();
         

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

        private void btnbinaryread_Click(object sender, EventArgs e)
        {

            try
            {

            
            Book b = new Book();
            fs = new FileStream(@"D:\TestFolder1\product", FileMode.Open, FileAccess.Read);
            BinaryFormatter binary = new BinaryFormatter();
             b = (Book)binary.Deserialize(fs);
            txtid.Text = b.id.ToString();
            txtbook.Text = b.name;
            txtauthornm.Text = b.authorname;
            txtprice.Text = b.price.ToString();


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
 
