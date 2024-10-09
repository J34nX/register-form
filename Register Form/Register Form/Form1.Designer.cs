namespace Register_Form
{
    partial class Form1
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
            this.MaleRB = new System.Windows.Forms.RadioButton();
            this.FemaleRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MiddleNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NotToSayRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.DayCB = new System.Windows.Forms.ComboBox();
            this.YearCB = new System.Windows.Forms.ComboBox();
            this.MonthCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaleRB
            // 
            this.MaleRB.AutoSize = true;
            this.MaleRB.Location = new System.Drawing.Point(87, 245);
            this.MaleRB.Name = "MaleRB";
            this.MaleRB.Size = new System.Drawing.Size(48, 17);
            this.MaleRB.TabIndex = 0;
            this.MaleRB.TabStop = true;
            this.MaleRB.Text = "Male";
            this.MaleRB.UseVisualStyleBackColor = true;
            this.MaleRB.CheckedChanged += new System.EventHandler(this.MaleRB_CheckedChanged);
            // 
            // FemaleRB
            // 
            this.FemaleRB.AutoSize = true;
            this.FemaleRB.Location = new System.Drawing.Point(141, 245);
            this.FemaleRB.Name = "FemaleRB";
            this.FemaleRB.Size = new System.Drawing.Size(59, 17);
            this.FemaleRB.TabIndex = 1;
            this.FemaleRB.TabStop = true;
            this.FemaleRB.Text = "Female";
            this.FemaleRB.UseVisualStyleBackColor = true;
            this.FemaleRB.CheckedChanged += new System.EventHandler(this.FemaleRB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name*";
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(17, 98);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(292, 20);
            this.LastNameTB.TabIndex = 8;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(16, 155);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(293, 20);
            this.FirstNameTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name*";
            // 
            // MiddleNameTB
            // 
            this.MiddleNameTB.Location = new System.Drawing.Point(16, 211);
            this.MiddleNameTB.Name = "MiddleNameTB";
            this.MiddleNameTB.Size = new System.Drawing.Size(293, 20);
            this.MiddleNameTB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Middle Name*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // NotToSayRB
            // 
            this.NotToSayRB.AutoSize = true;
            this.NotToSayRB.Location = new System.Drawing.Point(206, 245);
            this.NotToSayRB.Name = "NotToSayRB";
            this.NotToSayRB.Size = new System.Drawing.Size(104, 17);
            this.NotToSayRB.TabIndex = 14;
            this.NotToSayRB.TabStop = true;
            this.NotToSayRB.Text = "Prefer Not to say";
            this.NotToSayRB.UseVisualStyleBackColor = true;
            this.NotToSayRB.CheckedChanged += new System.EventHandler(this.NotToSayRB_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Date For Birth *";
            // 
            // DayCB
            // 
            this.DayCB.FormattingEnabled = true;
            this.DayCB.Location = new System.Drawing.Point(17, 301);
            this.DayCB.Name = "DayCB";
            this.DayCB.Size = new System.Drawing.Size(87, 21);
            this.DayCB.TabIndex = 16;
            this.DayCB.Text = "-Day-";
            this.DayCB.SelectedIndexChanged += new System.EventHandler(this.DayCB_SelectedIndexChanged);
            this.DayCB.SelectionChangeCommitted += new System.EventHandler(this.DayCB_SelectionChangeCommitted);
            // 
            // YearCB
            // 
            this.YearCB.FormattingEnabled = true;
            this.YearCB.Location = new System.Drawing.Point(206, 301);
            this.YearCB.Name = "YearCB";
            this.YearCB.Size = new System.Drawing.Size(103, 21);
            this.YearCB.TabIndex = 17;
            this.YearCB.Text = "-Year-";
            this.YearCB.SelectedIndexChanged += new System.EventHandler(this.YearCB_SelectedIndexChanged);
            this.YearCB.SelectionChangeCommitted += new System.EventHandler(this.YearCB_SelectionChangeCommitted);
            // 
            // MonthCB
            // 
            this.MonthCB.FormattingEnabled = true;
            this.MonthCB.Location = new System.Drawing.Point(110, 301);
            this.MonthCB.Name = "MonthCB";
            this.MonthCB.Size = new System.Drawing.Size(90, 21);
            this.MonthCB.TabIndex = 18;
            this.MonthCB.Text = "-Month-";
            this.MonthCB.SelectedIndexChanged += new System.EventHandler(this.MonthCB_SelectedIndexChanged);
            this.MonthCB.SelectionChangeCommitted += new System.EventHandler(this.MonthCB_SelectionChangeCommitted);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(17, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = "Register Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(344, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MonthCB);
            this.Controls.Add(this.YearCB);
            this.Controls.Add(this.DayCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NotToSayRB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MiddleNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FemaleRB);
            this.Controls.Add(this.MaleRB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MaleRB;
        private System.Windows.Forms.RadioButton FemaleRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MiddleNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton NotToSayRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DayCB;
        private System.Windows.Forms.ComboBox YearCB;
        private System.Windows.Forms.ComboBox MonthCB;
        private System.Windows.Forms.Button button1;
    }
}

