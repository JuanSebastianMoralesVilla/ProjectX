
namespace HeartAttackApp.Ui
{
    partial class FilterOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterOptions));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_choose = new System.Windows.Forms.ComboBox();
            this.tb_lower = new System.Windows.Forms.TextBox();
            this.tb_higger = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.Label();
            this.tb_cadena = new System.Windows.Forms.TextBox();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_showDecisionTree = new System.Windows.Forms.Button();
            this.txt_accuracy = new System.Windows.Forms.Label();
            this.labelDTree = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDecisionTree = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HeartAttackApp.Properties.Resources.verde_menta;
            this.panel1.Controls.Add(this.cb_choose);
            this.panel1.Controls.Add(this.tb_lower);
            this.panel1.Controls.Add(this.tb_higger);
            this.panel1.Controls.Add(this.txt_to);
            this.panel1.Controls.Add(this.tb_cadena);
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 27);
            this.panel1.TabIndex = 0;
            // 
            // cb_choose
            // 
            this.cb_choose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_choose.FormattingEnabled = true;
            this.cb_choose.Location = new System.Drawing.Point(3, 3);
            this.cb_choose.Name = "cb_choose";
            this.cb_choose.Size = new System.Drawing.Size(162, 21);
            this.cb_choose.TabIndex = 20;
            this.cb_choose.Visible = false;
            // 
            // tb_lower
            // 
            this.tb_lower.Location = new System.Drawing.Point(3, 4);
            this.tb_lower.Name = "tb_lower";
            this.tb_lower.Size = new System.Drawing.Size(45, 20);
            this.tb_lower.TabIndex = 19;
            this.tb_lower.Visible = false;
            // 
            // tb_higger
            // 
            this.tb_higger.Location = new System.Drawing.Point(118, 4);
            this.tb_higger.Name = "tb_higger";
            this.tb_higger.Size = new System.Drawing.Size(47, 20);
            this.tb_higger.TabIndex = 18;
            this.tb_higger.Visible = false;
            // 
            // txt_to
            // 
            this.txt_to.AutoSize = true;
            this.txt_to.Location = new System.Drawing.Point(68, 6);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(19, 13);
            this.txt_to.TabIndex = 17;
            this.txt_to.Text = "to:";
            this.txt_to.Visible = false;
            // 
            // tb_cadena
            // 
            this.tb_cadena.Location = new System.Drawing.Point(3, 3);
            this.tb_cadena.Name = "tb_cadena";
            this.tb_cadena.Size = new System.Drawing.Size(162, 20);
            this.tb_cadena.TabIndex = 22;
            this.tb_cadena.Visible = false;
            // 
            // cb_filter
            // 
            this.cb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Items.AddRange(new object[] {
            "Show all"});
            this.cb_filter.Location = new System.Drawing.Point(3, 5);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(162, 21);
            this.cb_filter.TabIndex = 16;
            this.cb_filter.Visible = false;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::HeartAttackApp.Properties.Resources.verde_menta;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.04453F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.95547F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_search, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_filter, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDTree, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbDecisionTree, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_accuracy, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_showDecisionTree, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.85714F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.14286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 95);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(186, 32);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 20);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // btn_showDecisionTree
            // 
            this.btn_showDecisionTree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_showDecisionTree.BackColor = System.Drawing.Color.White;
            this.btn_showDecisionTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showDecisionTree.Image = ((System.Drawing.Image)(resources.GetObject("btn_showDecisionTree.Image")));
            this.btn_showDecisionTree.Location = new System.Drawing.Point(786, 58);
            this.btn_showDecisionTree.Name = "btn_showDecisionTree";
            this.btn_showDecisionTree.Size = new System.Drawing.Size(144, 34);
            this.btn_showDecisionTree.TabIndex = 18;
            this.btn_showDecisionTree.Text = " SHOW";
            this.btn_showDecisionTree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_showDecisionTree.UseVisualStyleBackColor = false;
            this.btn_showDecisionTree.Click += new System.EventHandler(this.btn_showDecisionTree_Click);
            // 
            // txt_accuracy
            // 
            this.txt_accuracy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_accuracy.AutoSize = true;
            this.txt_accuracy.Font = new System.Drawing.Font("Stencil", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_accuracy.ForeColor = System.Drawing.Color.Red;
            this.txt_accuracy.Image = ((System.Drawing.Image)(resources.GetObject("txt_accuracy.Image")));
            this.txt_accuracy.Location = new System.Drawing.Point(831, 29);
            this.txt_accuracy.Name = "txt_accuracy";
            this.txt_accuracy.Size = new System.Drawing.Size(54, 25);
            this.txt_accuracy.TabIndex = 20;
            this.txt_accuracy.Text = "80%";
            this.txt_accuracy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDTree
            // 
            this.labelDTree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDTree.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDTree.Image = ((System.Drawing.Image)(resources.GetObject("labelDTree.Image")));
            this.labelDTree.Location = new System.Drawing.Point(795, 0);
            this.labelDTree.Name = "labelDTree";
            this.labelDTree.Size = new System.Drawing.Size(127, 28);
            this.labelDTree.TabIndex = 19;
            this.labelDTree.Text = "Accuracy";
            this.labelDTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDTree.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(275, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 21;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDecisionTree
            // 
            this.cbDecisionTree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDecisionTree.FormattingEnabled = true;
            this.cbDecisionTree.Items.AddRange(new object[] {
            "Decision tree library",
            "Decision tree our"});
            this.cbDecisionTree.Location = new System.Drawing.Point(497, 32);
            this.cbDecisionTree.Name = "cbDecisionTree";
            this.cbDecisionTree.Size = new System.Drawing.Size(149, 21);
            this.cbDecisionTree.TabIndex = 22;
            this.cbDecisionTree.SelectedIndexChanged += new System.EventHandler(this.cbDecisionTree_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(506, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Decision Tree:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // FilterOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FilterOptions";
            this.Size = new System.Drawing.Size(995, 95);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_cadena;
        private System.Windows.Forms.ComboBox cb_choose;
        private System.Windows.Forms.TextBox tb_lower;
        private System.Windows.Forms.TextBox tb_higger;
        private System.Windows.Forms.Label txt_to;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_showDecisionTree;
        private System.Windows.Forms.Label labelDTree;
        private System.Windows.Forms.Label txt_accuracy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDecisionTree;
        private System.Windows.Forms.Label label1;
    }
}
