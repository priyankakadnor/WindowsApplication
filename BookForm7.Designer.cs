
namespace WindowsApplication
{
    partial class BookForm7
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
            this.bookid = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.Label();
            this.authorname = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtbook = new System.Windows.Forms.TextBox();
            this.txtauthornm = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnread = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.btnXmlwrite = new System.Windows.Forms.Button();
            this.btnXmlread = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapead = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookid
            // 
            this.bookid.AutoSize = true;
            this.bookid.Location = new System.Drawing.Point(208, 33);
            this.bookid.Name = "bookid";
            this.bookid.Size = new System.Drawing.Size(44, 13);
            this.bookid.TabIndex = 0;
            this.bookid.Text = "Book Id";
            // 
            // bookname
            // 
            this.bookname.AutoSize = true;
            this.bookname.Location = new System.Drawing.Point(208, 93);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(63, 13);
            this.bookname.TabIndex = 1;
            this.bookname.Text = "Book Name";
            // 
            // authorname
            // 
            this.authorname.AutoSize = true;
            this.authorname.Location = new System.Drawing.Point(208, 149);
            this.authorname.Name = "authorname";
            this.authorname.Size = new System.Drawing.Size(69, 13);
            this.authorname.TabIndex = 2;
            this.authorname.Text = "Author Name";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(208, 211);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 13);
            this.price.TabIndex = 3;
            this.price.Text = "Price";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(277, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtbook
            // 
            this.txtbook.Location = new System.Drawing.Point(277, 90);
            this.txtbook.Name = "txtbook";
            this.txtbook.Size = new System.Drawing.Size(100, 20);
            this.txtbook.TabIndex = 5;
            // 
            // txtauthornm
            // 
            this.txtauthornm.Location = new System.Drawing.Point(277, 149);
            this.txtauthornm.Name = "txtauthornm";
            this.txtauthornm.Size = new System.Drawing.Size(100, 20);
            this.txtauthornm.TabIndex = 6;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(277, 208);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 20);
            this.txtprice.TabIndex = 7;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(220, 287);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 8;
            this.btnWrite.Text = "Write Form";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnread
            // 
            this.btnread.Location = new System.Drawing.Point(336, 287);
            this.btnread.Name = "btnread";
            this.btnread.Size = new System.Drawing.Size(75, 23);
            this.btnread.TabIndex = 9;
            this.btnread.Text = "Read Form";
            this.btnread.UseVisualStyleBackColor = true;
            this.btnread.Click += new System.EventHandler(this.btnread_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(336, 342);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(75, 23);
            this.btnbinaryread.TabIndex = 10;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(220, 342);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(75, 23);
            this.btnbinarywrite.TabIndex = 11;
            this.btnbinarywrite.Text = "Binary Write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // btnXmlwrite
            // 
            this.btnXmlwrite.Location = new System.Drawing.Point(424, 49);
            this.btnXmlwrite.Name = "btnXmlwrite";
            this.btnXmlwrite.Size = new System.Drawing.Size(75, 23);
            this.btnXmlwrite.TabIndex = 12;
            this.btnXmlwrite.Text = "Xml Write";
            this.btnXmlwrite.UseVisualStyleBackColor = true;
            this.btnXmlwrite.Click += new System.EventHandler(this.btnXmlwrite_Click);
            // 
            // btnXmlread
            // 
            this.btnXmlread.Location = new System.Drawing.Point(549, 49);
            this.btnXmlread.Name = "btnXmlread";
            this.btnXmlread.Size = new System.Drawing.Size(75, 23);
            this.btnXmlread.TabIndex = 13;
            this.btnXmlread.Text = "Xml Read";
            this.btnXmlread.UseVisualStyleBackColor = true;
            this.btnXmlread.Click += new System.EventHandler(this.btnXmlread_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(424, 126);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(75, 23);
            this.btnSoapWrite.TabIndex = 14;
            this.btnSoapWrite.Text = "Soap Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapead
            // 
            this.btnSoapead.Location = new System.Drawing.Point(541, 126);
            this.btnSoapead.Name = "btnSoapead";
            this.btnSoapead.Size = new System.Drawing.Size(75, 23);
            this.btnSoapead.TabIndex = 15;
            this.btnSoapead.Text = "Soap Read";
            this.btnSoapead.UseVisualStyleBackColor = true;
            this.btnSoapead.Click += new System.EventHandler(this.btnSoapead_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(424, 206);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(75, 23);
            this.btnjsonwrite.TabIndex = 16;
            this.btnjsonwrite.Text = "Json Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(549, 208);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(75, 23);
            this.btnjsonread.TabIndex = 17;
            this.btnjsonread.Text = "Json Read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // BookForm7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnSoapead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnXmlread);
            this.Controls.Add(this.btnXmlwrite);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnread);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtauthornm);
            this.Controls.Add(this.txtbook);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.price);
            this.Controls.Add(this.authorname);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.bookid);
            this.Name = "BookForm7";
            this.Text = "BOOK DETAILS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookid;
        private System.Windows.Forms.Label bookname;
        private System.Windows.Forms.Label authorname;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtbook;
        private System.Windows.Forms.TextBox txtauthornm;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnread;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Button btnXmlwrite;
        private System.Windows.Forms.Button btnXmlread;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapead;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
    }
}