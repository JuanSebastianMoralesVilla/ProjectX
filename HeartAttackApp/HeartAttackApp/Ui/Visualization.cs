using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartAttackApp.Ui
{
    public partial class Visualization : Form
    {
        ControllerGUI controller;
        public Visualization()
        {
            InitializeComponent();
        }

        public void initialize(ControllerGUI controller)
        {
            this.controller = controller;
            ptb_TreeVisualitation = controller.miHospital.ptbDecision;
        }
        private void Visualization_Load(object sender, EventArgs e)
        {

        }

        public PictureBox getPtbDecision()
        {
            return ptb_TreeVisualitation;
        }
        public PictureBox getPtbC45()
        {
            return ptb_C45TreeVisualization;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            ptb_C45TreeVisualization.Visible = !ptb_C45TreeVisualization.Visible;
            ptb_TreeVisualitation.Visible = !ptb_TreeVisualitation.Visible;
        }
    }
}
