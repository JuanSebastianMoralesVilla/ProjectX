
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
            this.scroll_Vertical = new System.Windows.Forms.VScrollBar();
            this.ptb_TreeVisualitation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_TreeVisualitation)).BeginInit();
            this.SuspendLayout();
            // 
            // scroll_Vertical
            // 
            this.scroll_Vertical.Location = new System.Drawing.Point(733, 146);
            this.scroll_Vertical.Name = "scroll_Vertical";
            this.scroll_Vertical.Size = new System.Drawing.Size(17, 80);
            this.scroll_Vertical.TabIndex = 0;
            // 
            // ptb_TreeVisualitation
            // 
            this.ptb_TreeVisualitation.Location = new System.Drawing.Point(8, 8);
            this.ptb_TreeVisualitation.Name = "ptb_TreeVisualitation";
            this.ptb_TreeVisualitation.Size = new System.Drawing.Size(7500, 1500);
            this.ptb_TreeVisualitation.TabIndex = 2;
            this.ptb_TreeVisualitation.TabStop = false;
            // 
            // Visualization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.ptb_TreeVisualitation);
            this.Controls.Add(this.scroll_Vertical);
            this.Name = "Visualization";
            this.Text = "Visualization";
            this.Load += new System.EventHandler(this.Visualization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_TreeVisualitation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar scroll_Vertical;
        private System.Windows.Forms.PictureBox ptb_TreeVisualitation;
    }
}