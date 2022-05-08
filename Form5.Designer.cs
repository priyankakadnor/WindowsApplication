
namespace WindowsApplication
{
    partial class Form5
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
            this.Write = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.txteid = new System.Windows.Forms.TextBox();
            this.txtename = new System.Windows.Forms.TextBox();
            this.txtdesig = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtdept = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employe Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employe Nsme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Department";
            // 
            // Write
            // 
            this.Write.Location = new System.Drawing.Point(328, 280);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(104, 23);
            this.Write.TabIndex = 12;
            this.Write.Text = "Write To Form";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(472, 280);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(75, 23);
            this.Read.TabIndex = 13;
            this.Read.Text = "Read Form";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // txteid
            // 
            this.txteid.Location = new System.Drawing.Point(409, 63);
            this.txteid.Name = "txteid";
            this.txteid.Size = new System.Drawing.Size(100, 20);
            this.txteid.TabIndex = 14;
            // 
            // txtename
            // 
            this.txtename.Location = new System.Drawing.Point(409, 103);
            this.txtename.Name = "txtename";
            this.txtename.Size = new System.Drawing.Size(100, 20);
            this.txtename.TabIndex = 15;
            // 
            // txtdesig
            // 
            this.txtdesig.Location = new System.Drawing.Point(409, 154);
            this.txtdesig.Name = "txtdesig";
            this.txtdesig.Size = new System.Drawing.Size(100, 20);
            this.txtdesig.TabIndex = 16;
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(409, 189);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(100, 20);
            this.txtsalary.TabIndex = 17;
            // 
            // txtdept
            // 
            this.txtdept.Location = new System.Drawing.Point(409, 228);
            this.txtdept.Name = "txtdept";
            this.txtdept.Size = new System.Drawing.Size(100, 20);
            this.txtdept.TabIndex = 18;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtdept);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txtdesig);
            this.Controls.Add(this.txtename);
            this.Controls.Add(this.txteid);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Employe Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.TextBox txteid;
        private System.Windows.Forms.TextBox txtename;
        private System.Windows.Forms.TextBox txtdesig;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtdept;
    }
}