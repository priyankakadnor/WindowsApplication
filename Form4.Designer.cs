
namespace WindowsApplication
{
    partial class Form4
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
            this.label5 = new System.Windows.Forms.Label();
            this.rno = new System.Windows.Forms.TextBox();
            this.nm = new System.Windows.Forms.TextBox();
            this.per = new System.Windows.Forms.TextBox();
            this.str = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Percentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stream";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "City";
            // 
            // rno
            // 
            this.rno.Location = new System.Drawing.Point(366, 87);
            this.rno.Name = "rno";
            this.rno.Size = new System.Drawing.Size(100, 20);
            this.rno.TabIndex = 5;
            // 
            // nm
            // 
            this.nm.Location = new System.Drawing.Point(366, 119);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(100, 20);
            this.nm.TabIndex = 6;
            // 
            // per
            // 
            this.per.Location = new System.Drawing.Point(366, 157);
            this.per.Name = "per";
            this.per.Size = new System.Drawing.Size(100, 20);
            this.per.TabIndex = 7;
            // 
            // str
            // 
            this.str.Location = new System.Drawing.Point(366, 185);
            this.str.Name = "str";
            this.str.Size = new System.Drawing.Size(100, 20);
            this.str.TabIndex = 8;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(366, 219);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 9;
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(301, 276);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(85, 23);
            this.write.TabIndex = 10;
            this.write.Text = "Write To From";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(418, 276);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 11;
            this.read.Text = "Read From";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.read);
            this.Controls.Add(this.write);
            this.Controls.Add(this.city);
            this.Controls.Add(this.str);
            this.Controls.Add(this.per);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.rno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rno;
        private System.Windows.Forms.TextBox nm;
        private System.Windows.Forms.TextBox per;
        private System.Windows.Forms.TextBox str;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button read;
    }
}