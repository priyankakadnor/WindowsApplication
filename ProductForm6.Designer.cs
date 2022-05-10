
namespace WindowsApplication
{
    partial class ProductForm6
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.btnwrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnXmlwrite = new System.Windows.Forms.Button();
            this.btnXmlread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnJsonwrite = new System.Windows.Forms.Button();
            this.btnJsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Category";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(330, 79);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(330, 127);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 5;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(330, 181);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 6;
            // 
            // txtcategory
            // 
            this.txtcategory.Location = new System.Drawing.Point(330, 232);
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(100, 20);
            this.txtcategory.TabIndex = 7;
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(264, 298);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(75, 23);
            this.btnwrite.TabIndex = 8;
            this.btnwrite.Text = "Write Form";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.btnwrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(431, 298);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 9;
            this.btnread.Text = "Read Form";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(264, 357);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(75, 23);
            this.btnbinarywrite.TabIndex = 10;
            this.btnbinarywrite.Text = "Binary Write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(431, 357);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryread.TabIndex = 11;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnXmlwrite
            // 
            this.btnXmlwrite.Location = new System.Drawing.Point(471, 97);
            this.btnXmlwrite.Name = "btnXmlwrite";
            this.btnXmlwrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlwrite.TabIndex = 12;
            this.btnXmlwrite.Text = "Xml Write";
            this.btnXmlwrite.UseVisualStyleBackColor = true;
            this.btnXmlwrite.Click += new System.EventHandler(this.btnXmlwrite_Click);
            // 
            // btnXmlread
            // 
            this.btnXmlread.Location = new System.Drawing.Point(592, 97);
            this.btnXmlread.Name = "btnXmlread";
            this.btnXmlread.Size = new System.Drawing.Size(75, 23);
            this.btnXmlread.TabIndex = 13;
            this.btnXmlread.Text = "Xml Read";
            this.btnXmlread.UseVisualStyleBackColor = true;
            this.btnXmlread.Click += new System.EventHandler(this.btnXmlread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Location = new System.Drawing.Point(471, 160);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(75, 23);
            this.btnsoapwrite.TabIndex = 14;
            this.btnsoapwrite.Text = "Soap Write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Location = new System.Drawing.Point(592, 160);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(75, 23);
            this.btnsoapread.TabIndex = 15;
            this.btnsoapread.Text = "Soap Read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnJsonwrite
            // 
            this.btnJsonwrite.Location = new System.Drawing.Point(471, 211);
            this.btnJsonwrite.Name = "btnJsonwrite";
            this.btnJsonwrite.Size = new System.Drawing.Size(75, 23);
            this.btnJsonwrite.TabIndex = 16;
            this.btnJsonwrite.Text = "Json Write";
            this.btnJsonwrite.UseVisualStyleBackColor = true;
            this.btnJsonwrite.Click += new System.EventHandler(this.btnJsonwrite_Click);
            // 
            // btnJsonread
            // 
            this.btnJsonread.Location = new System.Drawing.Point(592, 211);
            this.btnJsonread.Name = "btnJsonread";
            this.btnJsonread.Size = new System.Drawing.Size(75, 23);
            this.btnJsonread.TabIndex = 17;
            this.btnJsonread.Text = "Json Read";
            this.btnJsonread.UseVisualStyleBackColor = true;
            this.btnJsonread.Click += new System.EventHandler(this.btnJsonread_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonread);
            this.Controls.Add(this.btnJsonwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnXmlread);
            this.Controls.Add(this.btnXmlwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.txtcategory);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtcategory;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnXmlwrite;
        private System.Windows.Forms.Button btnXmlread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnJsonwrite;
        private System.Windows.Forms.Button btnJsonread;
    }
}