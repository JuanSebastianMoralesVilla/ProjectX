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
    public partial class VisualizationForm : Form
    {
        ControllerGUI controller;
        public VisualizationForm()
        {
            InitializeComponent();
        }

        public void initialize(ControllerGUI controller)
        {
            this.controller = controller;
            ptb_TreeVisualitation = controller.miHospital.ptbDecision;
        }
        public PictureBox getPtbDecision()
        {
            return ptb_TreeVisualitation;
        }
        public PictureBox getPtbC45()
        {
            return ptb_C45TreeVisualization;
        }

        private void Visualization_Load(object sender, EventArgs e)
        {
            AutoScrollPosition = new Point(3000, 0);
            Console.WriteLine(AutoScrollPosition.X);
        }
    }
}
