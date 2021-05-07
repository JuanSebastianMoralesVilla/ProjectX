
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
            this.startApp1 = new HeartAttackApp.Ui.StartApp();
            this.showCharts1 = new HeartAttackApp.Ui.ShowCharts();
            this.SuspendLayout();
            // 
            // startApp1
            // 
            this.startApp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startApp1.Location = new System.Drawing.Point(0, 0);
            this.startApp1.Name = "startApp1";
            this.startApp1.Size = new System.Drawing.Size(800, 450);
            this.startApp1.TabIndex = 0;
            // 
            // showCharts1
            // 
            this.showCharts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showCharts1.Location = new System.Drawing.Point(0, 0);
            this.showCharts1.Name = "showCharts1";
            this.showCharts1.Size = new System.Drawing.Size(800, 450);
            this.showCharts1.TabIndex = 1;
            this.showCharts1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showCharts1);
            this.Controls.Add(this.startApp1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private StartApp startApp1;
        private ShowCharts showCharts1;
    }
}