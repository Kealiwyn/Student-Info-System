
namespace StudentInfoSystem
{
    partial class FrmStudentInfoSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbForeign = new System.Windows.Forms.RadioButton();
            this.rbDomestic = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudSemester = new System.Windows.Forms.NumericUpDown();
            this.cb07 = new System.Windows.Forms.CheckBox();
            this.cb06 = new System.Windows.Forms.CheckBox();
            this.cb03 = new System.Windows.Forms.CheckBox();
            this.cb02 = new System.Windows.Forms.CheckBox();
            this.cb05 = new System.Windows.Forms.CheckBox();
            this.cb04 = new System.Windows.Forms.CheckBox();
            this.cb01 = new System.Windows.Forms.CheckBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbForeign);
            this.groupBox1.Controls.Add(this.rbDomestic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(67, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbForeign
            // 
            this.rbForeign.AutoSize = true;
            this.rbForeign.Location = new System.Drawing.Point(431, 93);
            this.rbForeign.Name = "rbForeign";
            this.rbForeign.Size = new System.Drawing.Size(65, 19);
            this.rbForeign.TabIndex = 8;
            this.rbForeign.Text = "Foreign";
            this.rbForeign.UseVisualStyleBackColor = true;
            // 
            // rbDomestic
            // 
            this.rbDomestic.AutoSize = true;
            this.rbDomestic.Location = new System.Drawing.Point(431, 68);
            this.rbDomestic.Name = "rbDomestic";
            this.rbDomestic.Size = new System.Drawing.Size(75, 19);
            this.rbDomestic.TabIndex = 7;
            this.rbDomestic.Text = "Domestic";
            this.rbDomestic.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Residence:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(431, 27);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(184, 23);
            this.txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(92, 82);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(184, 23);
            this.txtCity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(92, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(184, 23);
            this.txtFirstName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudSemester);
            this.groupBox2.Controls.Add(this.cb07);
            this.groupBox2.Controls.Add(this.cb06);
            this.groupBox2.Controls.Add(this.cb03);
            this.groupBox2.Controls.Add(this.cb02);
            this.groupBox2.Controls.Add(this.cb05);
            this.groupBox2.Controls.Add(this.cb04);
            this.groupBox2.Controls.Add(this.cb01);
            this.groupBox2.Controls.Add(this.cbProgram);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGpa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(67, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 189);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Academic Information";
            // 
            // nudSemester
            // 
            this.nudSemester.Location = new System.Drawing.Point(93, 83);
            this.nudSemester.Name = "nudSemester";
            this.nudSemester.Size = new System.Drawing.Size(183, 23);
            this.nudSemester.TabIndex = 17;
            // 
            // cb07
            // 
            this.cb07.AutoSize = true;
            this.cb07.Location = new System.Drawing.Point(493, 134);
            this.cb07.Name = "cb07";
            this.cb07.Size = new System.Drawing.Size(79, 19);
            this.cb07.TabIndex = 16;
            this.cb07.Text = "COMP100";
            this.cb07.UseVisualStyleBackColor = true;
            // 
            // cb06
            // 
            this.cb06.AutoSize = true;
            this.cb06.Location = new System.Drawing.Point(493, 109);
            this.cb06.Name = "cb06";
            this.cb06.Size = new System.Drawing.Size(77, 19);
            this.cb06.TabIndex = 15;
            this.cb06.Text = "MATH185";
            this.cb06.UseVisualStyleBackColor = true;
            // 
            // cb03
            // 
            this.cb03.AutoSize = true;
            this.cb03.Location = new System.Drawing.Point(404, 134);
            this.cb03.Name = "cb03";
            this.cb03.Size = new System.Drawing.Size(79, 19);
            this.cb03.TabIndex = 12;
            this.cb03.Text = "COMP213";
            this.cb03.UseVisualStyleBackColor = true;
            // 
            // cb02
            // 
            this.cb02.AutoSize = true;
            this.cb02.Location = new System.Drawing.Point(404, 109);
            this.cb02.Name = "cb02";
            this.cb02.Size = new System.Drawing.Size(79, 19);
            this.cb02.TabIndex = 11;
            this.cb02.Text = "COMP225";
            this.cb02.UseVisualStyleBackColor = true;
            // 
            // cb05
            // 
            this.cb05.AutoSize = true;
            this.cb05.Location = new System.Drawing.Point(493, 84);
            this.cb05.Name = "cb05";
            this.cb05.Size = new System.Drawing.Size(79, 19);
            this.cb05.TabIndex = 14;
            this.cb05.Text = "COMP391";
            this.cb05.UseVisualStyleBackColor = true;
            // 
            // cb04
            // 
            this.cb04.AutoSize = true;
            this.cb04.Location = new System.Drawing.Point(404, 159);
            this.cb04.Name = "cb04";
            this.cb04.Size = new System.Drawing.Size(79, 19);
            this.cb04.TabIndex = 13;
            this.cb04.Text = "COMP301";
            this.cb04.UseVisualStyleBackColor = true;
            this.cb04.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cb01
            // 
            this.cb01.AutoSize = true;
            this.cb01.Location = new System.Drawing.Point(404, 84);
            this.cb01.Name = "cb01";
            this.cb01.Size = new System.Drawing.Size(79, 19);
            this.cb01.TabIndex = 10;
            this.cb01.Text = "COMP123";
            this.cb01.UseVisualStyleBackColor = true;
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(93, 30);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(445, 23);
            this.cbProgram.TabIndex = 9;
            this.cbProgram.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Residence:";
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(92, 129);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(184, 23);
            this.txtGpa.TabIndex = 5;
            this.txtGpa.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Semester:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gpa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Program:";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(498, 415);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 10;
            this.btClear.Text = "&Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(579, 415);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "&OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // FrmStudentInfoSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStudentInfoSystem";
            this.Text = "Student Info System";
            this.Load += new System.EventHandler(this.FrmStudentInfoSystem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSemester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbForeign;
        private System.Windows.Forms.RadioButton rbDomestic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.CheckBox cb07;
        private System.Windows.Forms.CheckBox cb06;
        private System.Windows.Forms.CheckBox cb05;
        private System.Windows.Forms.CheckBox cb04;
        private System.Windows.Forms.CheckBox cb03;
        private System.Windows.Forms.CheckBox cb02;
        private System.Windows.Forms.CheckBox cb01;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.NumericUpDown nudSemester;
    }
}

