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
            ptb_TreeVisualitation = controller.miHospital.ptb;
        }
        private void Visualization_Load(object sender, EventArgs e)
        {

        }

        public PictureBox getPtb()
        {
            return ptb_TreeVisualitation;
        }
    }
}
