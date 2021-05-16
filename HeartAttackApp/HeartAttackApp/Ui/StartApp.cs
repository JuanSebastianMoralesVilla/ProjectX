using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartAttackApp.Ui
{
    public partial class StartApp : UserControl
    {
        private Main main;
        public StartApp()
        {
            InitializeComponent();
        }

        public void initialize(Main main)
        {
            this.main = main;
        }
        public void loading(int  advance)
        {
            pb_starting.Value = advance;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
