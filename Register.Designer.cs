
namespace WindowsApplication
{
    partial class Register
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
            this.showbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.eid = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Label();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(290, 223);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 0;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(389, 223);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 1;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(287, 61);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(54, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Full Name";
            // 
            // eid
            // 
            this.eid.AutoSize = true;
            this.eid.Location = new System.Drawing.Point(287, 97);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(44, 13);
            this.eid.TabIndex = 3;
            this.eid.Text = "Email Id";
            this.eid.Click += new System.EventHandler(this.label2_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(287, 129);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(61, 13);
            this.email.TabIndex = 4;
            this.email.Text = "Contact No";
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(287, 165);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 13);
            this.add.TabIndex = 5;
            this.add.Text = "Address";
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(347, 165);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(148, 20);
            this.txtadd.TabIndex = 6;
            this.txtadd.Text = "xcvbnm";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(347, 58);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(167, 20);
            this.txtname.TabIndex = 7;
            this.txtname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(347, 94);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 8;
            this.txtemail.Text = "pfhbxcvbnm";
            this.txtemail.TextChanged += new System.EventHandler(this.txtemail_TextChanged);
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(347, 126);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 9;
            this.txtno.Text = "cvbnm";
            this.txtno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.add);
            this.Controls.Add(this.email);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.showbtn);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label eid;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label add;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtno;
    }
}