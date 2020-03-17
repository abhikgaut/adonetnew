namespace adonetnew
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.texteno = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textmgr = new System.Windows.Forms.TextBox();
            this.textjob = new System.Windows.Forms.TextBox();
            this.textsalary = new System.Windows.Forms.TextBox();
            this.textcomm = new System.Windows.Forms.TextBox();
            this.combodno = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "empno";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "mgr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "hiredate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "salary";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "commision";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "deptno";
            // 
            // texteno
            // 
            this.texteno.Location = new System.Drawing.Point(470, 13);
            this.texteno.Name = "texteno";
            this.texteno.Size = new System.Drawing.Size(100, 20);
            this.texteno.TabIndex = 8;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(470, 50);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 20);
            this.textname.TabIndex = 9;
            // 
            // textmgr
            // 
            this.textmgr.Location = new System.Drawing.Point(470, 129);
            this.textmgr.Name = "textmgr";
            this.textmgr.Size = new System.Drawing.Size(100, 20);
            this.textmgr.TabIndex = 10;
            this.textmgr.TextChanged += new System.EventHandler(this.textmgr_TextChanged);
            // 
            // textjob
            // 
            this.textjob.Location = new System.Drawing.Point(470, 88);
            this.textjob.Name = "textjob";
            this.textjob.Size = new System.Drawing.Size(100, 20);
            this.textjob.TabIndex = 11;
            // 
            // textsalary
            // 
            this.textsalary.Location = new System.Drawing.Point(470, 223);
            this.textsalary.Name = "textsalary";
            this.textsalary.Size = new System.Drawing.Size(100, 20);
            this.textsalary.TabIndex = 12;
            // 
            // textcomm
            // 
            this.textcomm.Location = new System.Drawing.Point(470, 258);
            this.textcomm.Name = "textcomm";
            this.textcomm.Size = new System.Drawing.Size(100, 20);
            this.textcomm.TabIndex = 13;
            // 
            // combodno
            // 
            this.combodno.FormattingEnabled = true;
            this.combodno.Location = new System.Drawing.Point(470, 306);
            this.combodno.Name = "combodno";
            this.combodno.Size = new System.Drawing.Size(99, 21);
            this.combodno.TabIndex = 14;
            this.combodno.SelectedIndexChanged += new System.EventHandler(this.combodno_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(317, 357);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(131, 56);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "do the thang";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.combodno);
            this.Controls.Add(this.textcomm);
            this.Controls.Add(this.textsalary);
            this.Controls.Add(this.textjob);
            this.Controls.Add(this.textmgr);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.texteno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox texteno;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textmgr;
        private System.Windows.Forms.TextBox textjob;
        private System.Windows.Forms.TextBox textsalary;
        private System.Windows.Forms.TextBox textcomm;
        private System.Windows.Forms.ComboBox combodno;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnInsert;
    }
}