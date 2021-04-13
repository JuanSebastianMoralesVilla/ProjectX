﻿
namespace HeartAttackApp.Ui
{
    partial class Main_pane
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
            this.grid_data = new System.Windows.Forms.DataGridView();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_solve = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.cb_column = new System.Windows.Forms.ComboBox();
            this.txt_to = new System.Windows.Forms.Label();
            this.tb_higger = new System.Windows.Forms.TextBox();
            this.tb_lower = new System.Windows.Forms.TextBox();
            this.cb_choose = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_data
            // 
            this.grid_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_data.Location = new System.Drawing.Point(35, 82);
            this.grid_data.Name = "grid_data";
            this.grid_data.Size = new System.Drawing.Size(692, 269);
            this.grid_data.TabIndex = 0;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(35, 372);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(137, 46);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "NEW";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(314, 372);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(130, 46);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "LOAD";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // btn_solve
            // 
            this.btn_solve.Location = new System.Drawing.Point(608, 372);
            this.btn_solve.Name = "btn_solve";
            this.btn_solve.Size = new System.Drawing.Size(119, 46);
            this.btn_solve.TabIndex = 3;
            this.btn_solve.Text = "SOLVE";
            this.btn_solve.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(733, 201);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 34);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(35, 12);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(162, 21);
            this.cb_filter.TabIndex = 5;
            this.cb_filter.Text = "Filter by:";
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_column
            // 
            this.cb_column.FormattingEnabled = true;
            this.cb_column.Location = new System.Drawing.Point(35, 49);
            this.cb_column.Name = "cb_column";
            this.cb_column.Size = new System.Drawing.Size(162, 21);
            this.cb_column.TabIndex = 6;
            this.cb_column.Text = "Column:";
            this.cb_column.Visible = false;
            // 
            // txt_to
            // 
            this.txt_to.AutoSize = true;
            this.txt_to.Location = new System.Drawing.Point(289, 34);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(19, 13);
            this.txt_to.TabIndex = 7;
            this.txt_to.Text = "to:";
            this.txt_to.Visible = false;
            // 
            // tb_higger
            // 
            this.tb_higger.Location = new System.Drawing.Point(314, 31);
            this.tb_higger.Name = "tb_higger";
            this.tb_higger.Size = new System.Drawing.Size(47, 20);
            this.tb_higger.TabIndex = 8;
            this.tb_higger.Visible = false;
            // 
            // tb_lower
            // 
            this.tb_lower.Location = new System.Drawing.Point(238, 31);
            this.tb_lower.Name = "tb_lower";
            this.tb_lower.Size = new System.Drawing.Size(45, 20);
            this.tb_lower.TabIndex = 9;
            this.tb_lower.Visible = false;
            this.tb_lower.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cb_choose
            // 
            this.cb_choose.FormattingEnabled = true;
            this.cb_choose.Location = new System.Drawing.Point(238, 31);
            this.cb_choose.Name = "cb_choose";
            this.cb_choose.Size = new System.Drawing.Size(125, 21);
            this.cb_choose.TabIndex = 10;
            this.cb_choose.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(369, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // Main_pane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.cb_choose);
            this.Controls.Add(this.tb_lower);
            this.Controls.Add(this.tb_higger);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.cb_column);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_solve);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.grid_data);
            this.Name = "Main_pane";
            this.Text = "main_pane";
            this.Load += new System.EventHandler(this.Main_pane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_data;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_solve;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.ComboBox cb_column;
        private System.Windows.Forms.Label txt_to;
        private System.Windows.Forms.TextBox tb_higger;
        private System.Windows.Forms.TextBox tb_lower;
        private System.Windows.Forms.ComboBox cb_choose;
        private System.Windows.Forms.Button btn_search;
    }
}