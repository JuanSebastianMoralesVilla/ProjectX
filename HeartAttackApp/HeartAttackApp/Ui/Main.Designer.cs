
namespace HeartAttackApp.Ui
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gridPatients1 = new HeartAttackApp.Ui.GridPatients();
            this.buttonsOptions1 = new HeartAttackApp.Ui.ButtonsOptions();
            this.filterOptions1 = new HeartAttackApp.Ui.FilterOptions();
            this.startApp1 = new HeartAttackApp.Ui.StartApp();
            this.showCharts1 = new HeartAttackApp.Ui.ShowCharts();
            this.SuspendLayout();
            // 
            // gridPatients1
            // 
            this.gridPatients1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridPatients1.BackgroundImage")));
            this.gridPatients1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPatients1.Location = new System.Drawing.Point(0, 95);
            this.gridPatients1.Name = "gridPatients1";
            this.gridPatients1.Size = new System.Drawing.Size(995, 332);
            this.gridPatients1.TabIndex = 2;
            this.gridPatients1.Visible = false;
            // 
            // buttonsOptions1
            // 
            this.buttonsOptions1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonsOptions1.BackgroundImage")));
            this.buttonsOptions1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsOptions1.Location = new System.Drawing.Point(0, 427);
            this.buttonsOptions1.Name = "buttonsOptions1";
            this.buttonsOptions1.Size = new System.Drawing.Size(995, 140);
            this.buttonsOptions1.TabIndex = 3;
            this.buttonsOptions1.Visible = false;
            this.buttonsOptions1.Load += new System.EventHandler(this.buttonsOptions1_Load);
            // 
            // filterOptions1
            // 
            this.filterOptions1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterOptions1.Location = new System.Drawing.Point(0, 0);
            this.filterOptions1.Name = "filterOptions1";
            this.filterOptions1.Size = new System.Drawing.Size(995, 95);
            this.filterOptions1.TabIndex = 1;
            this.filterOptions1.Visible = false;
            // 
            // startApp1
            // 
            this.startApp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startApp1.Location = new System.Drawing.Point(0, 0);
            this.startApp1.Name = "startApp1";
            this.startApp1.Size = new System.Drawing.Size(995, 567);
            this.startApp1.TabIndex = 0;
            // 
            // showCharts1
            // 
            this.showCharts1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showCharts1.BackgroundImage")));
            this.showCharts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showCharts1.Location = new System.Drawing.Point(0, 0);
            this.showCharts1.Name = "showCharts1";
            this.showCharts1.Size = new System.Drawing.Size(995, 567);
            this.showCharts1.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 567);
            this.Controls.Add(this.gridPatients1);
            this.Controls.Add(this.buttonsOptions1);
            this.Controls.Add(this.filterOptions1);
            this.Controls.Add(this.startApp1);
            this.Controls.Add(this.showCharts1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private StartApp startApp1;
        private FilterOptions filterOptions1;
        private GridPatients gridPatients1;
        private ButtonsOptions buttonsOptions1;
        private ShowCharts showCharts1;
    }
}