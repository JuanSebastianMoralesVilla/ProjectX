﻿
namespace HeartAttackApp.Ui
{
    partial class GridPatients
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridPatients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_graphics = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_data = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_graphics, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_add, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(776, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.00764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.99237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 496);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_graphics
            // 
            this.btn_graphics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_graphics.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_graphics.Image = ((System.Drawing.Image)(resources.GetObject("btn_graphics.Image")));
            this.btn_graphics.Location = new System.Drawing.Point(3, 76);
            this.btn_graphics.Name = "btn_graphics";
            this.btn_graphics.Size = new System.Drawing.Size(247, 139);
            this.btn_graphics.TabIndex = 13;
            this.btn_graphics.UseVisualStyleBackColor = false;
            this.btn_graphics.Click += new System.EventHandler(this.btn_graphics_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(3, 278);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(247, 48);
            this.btn_add.TabIndex = 14;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grid_data);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 496);
            this.panel1.TabIndex = 1;
            // 
            // grid_data
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid_data.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.grid_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_data.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grid_data.Location = new System.Drawing.Point(3, 3);
            this.grid_data.Name = "grid_data";
            this.grid_data.Size = new System.Drawing.Size(773, 490);
            this.grid_data.TabIndex = 1;
            this.grid_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_data_CellContentClick);
            // 
            // GridPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GridPatients";
            this.Size = new System.Drawing.Size(1029, 496);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_data;
        private System.Windows.Forms.Button btn_graphics;
        private System.Windows.Forms.Button btn_add;
    }
}
