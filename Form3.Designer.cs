
namespace WindowsApplication
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.writebtn = new System.Windows.Forms.Button();
            this.Readbtn = new System.Windows.Forms.Button();
            this.createbtn = new System.Windows.Forms.Button();
            this.filebtn = new System.Windows.Forms.Button();
            this.binarybtn = new System.Windows.Forms.Button();
            this.btnbinary2 = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.BtnJsonWrite = new System.Windows.Forms.Button();
            this.BtnJsonRead = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Department Name";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(237, 151);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(48, 13);
            this.Location.TabIndex = 2;
            this.Location.Text = "Location";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(336, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 3;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(336, 96);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 4;
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(336, 144);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(100, 20);
            this.txtlocation.TabIndex = 5;
            // 
            // writebtn
            // 
            this.writebtn.Location = new System.Drawing.Point(236, 204);
            this.writebtn.Name = "writebtn";
            this.writebtn.Size = new System.Drawing.Size(75, 23);
            this.writebtn.TabIndex = 6;
            this.writebtn.Text = "Write To Form";
            this.writebtn.UseVisualStyleBackColor = true;
            this.writebtn.Click += new System.EventHandler(this.writebtn_Click);
            // 
            // Readbtn
            // 
            this.Readbtn.Location = new System.Drawing.Point(390, 204);
            this.Readbtn.Name = "Readbtn";
            this.Readbtn.Size = new System.Drawing.Size(75, 23);
            this.Readbtn.TabIndex = 7;
            this.Readbtn.Text = "Read Form";
            this.Readbtn.UseVisualStyleBackColor = true;
            this.Readbtn.Click += new System.EventHandler(this.Readbtn_Click);
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(236, 270);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(75, 23);
            this.createbtn.TabIndex = 8;
            this.createbtn.Text = "Create Folder";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // filebtn
            // 
            this.filebtn.Location = new System.Drawing.Point(390, 270);
            this.filebtn.Name = "filebtn";
            this.filebtn.Size = new System.Drawing.Size(75, 23);
            this.filebtn.TabIndex = 9;
            this.filebtn.Text = "Create File";
            this.filebtn.UseVisualStyleBackColor = true;
            // 
            // binarybtn
            // 
            this.binarybtn.Location = new System.Drawing.Point(533, 39);
            this.binarybtn.Name = "binarybtn";
            this.binarybtn.Size = new System.Drawing.Size(75, 23);
            this.binarybtn.TabIndex = 10;
            this.binarybtn.Text = "Binary Write";
            this.binarybtn.UseVisualStyleBackColor = true;
            this.binarybtn.Click += new System.EventHandler(this.binarybtn_Click);
            // 
            // btnbinary2
            // 
            this.btnbinary2.Location = new System.Drawing.Point(533, 94);
            this.btnbinary2.Name = "btnbinary2";
            this.btnbinary2.Size = new System.Drawing.Size(75, 23);
            this.btnbinary2.TabIndex = 11;
            this.btnbinary2.Text = "Binary Read";
            this.btnbinary2.UseVisualStyleBackColor = true;
            this.btnbinary2.Click += new System.EventHandler(this.btnbinary2_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(533, 144);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlWrite.TabIndex = 13;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(533, 191);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(75, 23);
            this.btnXmlRead.TabIndex = 14;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // BtnJsonWrite
            // 
            this.BtnJsonWrite.Location = new System.Drawing.Point(533, 246);
            this.BtnJsonWrite.Name = "BtnJsonWrite";
            this.BtnJsonWrite.Size = new System.Drawing.Size(75, 23);
            this.BtnJsonWrite.TabIndex = 15;
            this.BtnJsonWrite.Text = "Json Write";
            this.BtnJsonWrite.UseVisualStyleBackColor = true;
            this.BtnJsonWrite.Click += new System.EventHandler(this.BtnJsonWrite_Click);
            // 
            // BtnJsonRead
            // 
            this.BtnJsonRead.Location = new System.Drawing.Point(533, 308);
            this.BtnJsonRead.Name = "BtnJsonRead";
            this.BtnJsonRead.Size = new System.Drawing.Size(75, 23);
            this.BtnJsonRead.TabIndex = 16;
            this.BtnJsonRead.Text = "Json Read";
            this.BtnJsonRead.UseVisualStyleBackColor = true;
            this.BtnJsonRead.Click += new System.EventHandler(this.BtnJsonRead_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Soap Write";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Soap Read";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnJsonRead);
            this.Controls.Add(this.BtnJsonWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnbinary2);
            this.Controls.Add(this.binarybtn);
            this.Controls.Add(this.filebtn);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.Readbtn);
            this.Controls.Add(this.writebtn);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Button writebtn;
        private System.Windows.Forms.Button Readbtn;
        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.Button filebtn;
        private System.Windows.Forms.Button binarybtn;
        private System.Windows.Forms.Button btnbinary2;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button BtnJsonWrite;
        private System.Windows.Forms.Button BtnJsonRead;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}