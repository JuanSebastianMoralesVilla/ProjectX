
using System;

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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_graphics = new System.Windows.Forms.Button();
            this.btExcelExport = new System.Windows.Forms.Button();
            this.btn_experiment = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_data = new System.Windows.Forms.DataGridView();
            this.pb_loadingExperiment = new System.Windows.Forms.ProgressBar();
            this.lb_wait = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.BackgroundImage = global::HeartAttackApp.Properties.Resources.verde_menta;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_add, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_graphics, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btExcelExport, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_experiment, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pb_loadingExperiment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_wait, 0, 5);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(752, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.45946F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.54054F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.AllowDrop = true;
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(33, 79);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(174, 46);
            this.btn_add.TabIndex = 14;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_graphics
            // 
            this.btn_graphics.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_graphics.BackColor = System.Drawing.Color.White;
            this.btn_graphics.Image = ((System.Drawing.Image)(resources.GetObject("btn_graphics.Image")));
            this.btn_graphics.Location = new System.Drawing.Point(33, 23);
            this.btn_graphics.Name = "btn_graphics";
            this.btn_graphics.Size = new System.Drawing.Size(174, 50);
            this.btn_graphics.TabIndex = 13;
            this.btn_graphics.UseVisualStyleBackColor = false;
            this.btn_graphics.Click += new System.EventHandler(this.btn_graphics_Click);
            // 
            // btExcelExport
            // 
            this.btExcelExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btExcelExport.BackColor = System.Drawing.Color.White;
            this.btExcelExport.Enabled = false;
            this.btExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("btExcelExport.Image")));
            this.btExcelExport.Location = new System.Drawing.Point(91, 131);
            this.btExcelExport.Name = "btExcelExport";
            this.btExcelExport.Size = new System.Drawing.Size(58, 50);
            this.btExcelExport.TabIndex = 16;
            this.btExcelExport.UseVisualStyleBackColor = false;
            this.btExcelExport.Click += new System.EventHandler(this.btExcelExport_Click);
            // 
            // btn_experiment
            // 
            this.btn_experiment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_experiment.Location = new System.Drawing.Point(67, 216);
            this.btn_experiment.Name = "btn_experiment";
            this.btn_experiment.Size = new System.Drawing.Size(105, 23);
            this.btn_experiment.TabIndex = 17;
            this.btn_experiment.Text = "Experiment";
            this.btn_experiment.UseVisualStyleBackColor = true;
            this.btn_experiment.Click += new System.EventHandler(this.btn_experiment_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HeartAttackApp.Properties.Resources.verde_menta;
            this.panel1.Controls.Add(this.grid_data);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 320);
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
            this.grid_data.Size = new System.Drawing.Size(744, 314);
            this.grid_data.TabIndex = 1;
            // 
            // pb_loadingExperiment
            // 
            this.pb_loadingExperiment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_loadingExperiment.Location = new System.Drawing.Point(51, 247);
            this.pb_loadingExperiment.Name = "pb_loadingExperiment";
            this.pb_loadingExperiment.Size = new System.Drawing.Size(137, 22);
            this.pb_loadingExperiment.TabIndex = 18;
            this.pb_loadingExperiment.Visible = false;
            // 
            // lb_wait
            // 
            this.lb_wait.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_wait.AutoSize = true;
            this.lb_wait.BackColor = System.Drawing.Color.Transparent;
            this.lb_wait.Location = new System.Drawing.Point(86, 272);
            this.lb_wait.Name = "lb_wait";
            this.lb_wait.Size = new System.Drawing.Size(67, 13);
            this.lb_wait.TabIndex = 19;
            this.lb_wait.Text = "Please wait..";
            this.lb_wait.Visible = false;
            // 
            // GridPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HeartAttackApp.Properties.Resources.verde_menta;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GridPatients";
            this.Size = new System.Drawing.Size(995, 320);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_data)).EndInit();
            this.ResumeLayout(false);

        }

        private void bt_excel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_data;
        private System.Windows.Forms.Button btn_graphics;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btExcelExport;
        private System.Windows.Forms.Button btn_experiment;
        private System.Windows.Forms.ProgressBar pb_loadingExperiment;
        private System.Windows.Forms.Label lb_wait;
    }
}
