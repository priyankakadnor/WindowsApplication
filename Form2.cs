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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog od = new OpenFileDialog();
                DialogResult result = od.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamReader sr = new StreamReader(od.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  richTextBox1.SaveFile();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void fontlb_Click(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sd = new SaveFileDialog();
                sd.DefaultExt = ".txt";
                sd.Filter = "Text Document(*.txt)|*.txt|Word(*.docts)|*.docx";
                DialogResult result = sd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sd.FileName);
                    sw.WriteLine(richTextBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ep)
            {
                MessageBox.Show(ep.Message);
            }
        }
    }
}
