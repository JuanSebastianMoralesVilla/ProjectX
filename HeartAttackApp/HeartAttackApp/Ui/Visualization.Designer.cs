
namespace HeartAttackApp.Ui
{
    partial class Visualization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualization));
            this.ptb_C45TreeVisualization = new System.Windows.Forms.PictureBox();
            this.ptb_TreeVisualitation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_C45TreeVisualization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_TreeVisualitation)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_C45TreeVisualization
            // 
            this.ptb_C45TreeVisualization.Location = new System.Drawing.Point(0, 0);
            this.ptb_C45TreeVisualization.Name = "ptb_C45TreeVisualization";
            this.ptb_C45TreeVisualization.Size = new System.Drawing.Size(3500, 1500);
            this.ptb_C45TreeVisualization.TabIndex = 0;
            this.ptb_C45TreeVisualization.TabStop = false;
            // 
            // ptb_TreeVisualitation
            // 
            this.ptb_TreeVisualitation.Location = new System.Drawing.Point(0, 0);
            this.ptb_TreeVisualitation.Name = "ptb_TreeVisualitation";
            this.ptb_TreeVisualitation.Size = new System.Drawing.Size(7500, 1500);
            this.ptb_TreeVisualitation.TabIndex = 1;
            this.ptb_TreeVisualitation.TabStop = false;
            this.ptb_TreeVisualitation.Visible = false;
            // 
            // Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.ptb_TreeVisualitation);
            this.Controls.Add(this.ptb_C45TreeVisualization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visualization";
            this.Text = "Visualization";
            this.Load += new System.EventHandler(this.Visualization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_C45TreeVisualization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_TreeVisualitation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_C45TreeVisualization;
        private System.Windows.Forms.PictureBox ptb_TreeVisualitation;
    }
}