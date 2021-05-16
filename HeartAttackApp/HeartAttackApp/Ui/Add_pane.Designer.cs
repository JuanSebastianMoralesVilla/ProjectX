﻿
namespace HeartAttackApp.Ui
{
    partial class Add_pane
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
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_bloodPressure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.cb_painType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_colesterol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_bloodSugar = new System.Windows.Forms.ComboBox();
            this.txt_maxHeart = new System.Windows.Forms.TextBox();
            this.cb_angina = new System.Windows.Forms.ComboBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbResultElectro = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gender of the person:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age of the person:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chest Pain type chest pain type:";
            // 
            // txt_age
            // 
            this.txt_age.AccessibleName = "";
            this.txt_age.Location = new System.Drawing.Point(263, 70);
            this.txt_age.MaxLength = 3;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(100, 20);
            this.txt_age.TabIndex = 3;
            this.txt_age.Tag = "";
            // 
            // txt_bloodPressure
            // 
            this.txt_bloodPressure.Location = new System.Drawing.Point(263, 178);
            this.txt_bloodPressure.Name = "txt_bloodPressure";
            this.txt_bloodPressure.Size = new System.Drawing.Size(100, 20);
            this.txt_bloodPressure.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resting blood pressure ( in mm Hg ):";
            // 
            // cb_sex
            // 
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "0: F",
            "1: M"});
            this.cb_sex.Location = new System.Drawing.Point(263, 105);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(100, 21);
            this.cb_sex.TabIndex = 6;
            // 
            // cb_painType
            // 
            this.cb_painType.FormattingEnabled = true;
            this.cb_painType.Items.AddRange(new object[] {
            "0: angina típica",
            "1 : angina atipica ",
            "2: dolor no anginoso",
            "3: asintomático"});
            this.cb_painType.Location = new System.Drawing.Point(263, 143);
            this.cb_painType.Name = "cb_painType";
            this.cb_painType.Size = new System.Drawing.Size(100, 21);
            this.cb_painType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cholestoral in mg/dl fetched via BMI sensor:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_colesterol
            // 
            this.txt_colesterol.Location = new System.Drawing.Point(263, 213);
            this.txt_colesterol.Name = "txt_colesterol";
            this.txt_colesterol.Size = new System.Drawing.Size(100, 20);
            this.txt_colesterol.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "( fasting blood sugar > 120 mg/dl ):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resting electrocardiographic results:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Maximum heart rate achieved:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Exercise induced angina:";
            // 
            // cb_bloodSugar
            // 
            this.cb_bloodSugar.FormattingEnabled = true;
            this.cb_bloodSugar.Items.AddRange(new object[] {
            "0: False",
            "1: True"});
            this.cb_bloodSugar.Location = new System.Drawing.Point(263, 245);
            this.cb_bloodSugar.Name = "cb_bloodSugar";
            this.cb_bloodSugar.Size = new System.Drawing.Size(100, 21);
            this.cb_bloodSugar.TabIndex = 17;
            // 
            // txt_maxHeart
            // 
            this.txt_maxHeart.Location = new System.Drawing.Point(263, 315);
            this.txt_maxHeart.Name = "txt_maxHeart";
            this.txt_maxHeart.Size = new System.Drawing.Size(100, 20);
            this.txt_maxHeart.TabIndex = 19;
            // 
            // cb_angina
            // 
            this.cb_angina.FormattingEnabled = true;
            this.cb_angina.Items.AddRange(new object[] {
            "0: False",
            "1: True"});
            this.cb_angina.Location = new System.Drawing.Point(263, 350);
            this.cb_angina.Name = "cb_angina";
            this.cb_angina.Size = new System.Drawing.Size(100, 21);
            this.cb_angina.TabIndex = 20;
            // 
            // txt_ID
            // 
            this.txt_ID.AccessibleName = "";
            this.txt_ID.Location = new System.Drawing.Point(263, 36);
            this.txt_ID.MaxLength = 3;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 22;
            this.txt_ID.Tag = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(25, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID:";
            // 
            // cbResultElectro
            // 
            this.cbResultElectro.FormattingEnabled = true;
            this.cbResultElectro.Items.AddRange(new object[] {
            "0 normal",
            "1 Tiene una anomalia de la onda ST\'T",
            "2 Muestra Hipertrofia venticular"});
            this.cbResultElectro.Location = new System.Drawing.Point(263, 275);
            this.cbResultElectro.Name = "cbResultElectro";
            this.cbResultElectro.Size = new System.Drawing.Size(100, 21);
            this.cbResultElectro.TabIndex = 23;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(150, 401);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 16;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HeartAttackApp.Properties.Resources.fondo_3;
            this.pictureBox1.Location = new System.Drawing.Point(-88, -19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 497);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Add_pane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.cbResultElectro);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_angina);
            this.Controls.Add(this.txt_maxHeart);
            this.Controls.Add(this.cb_bloodSugar);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_colesterol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_painType);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_bloodPressure);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Add_pane";
            this.Text = "Add_pane";
            this.Load += new System.EventHandler(this.Add_pane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_bloodPressure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.ComboBox cb_painType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_colesterol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_bloodSugar;
        private System.Windows.Forms.TextBox txt_maxHeart;
        private System.Windows.Forms.ComboBox cb_angina;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbResultElectro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}