using HeartAttackApp.Model;
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
    public partial class Main : Form
    {
        private ControllerGUI controller { get; set; }
        public Main()
        {
            controller = new ControllerGUI();
            InitializeComponent();
        }

        private void startApp1_Load(object sender, EventArgs e)
        {
            controller.training();
            loadMainOptions();
        }

        private void loadMainOptions()
        {
            GridPatients gridPatients = new GridPatients(controller);
            FilterOptions filterOptions = new FilterOptions(controller,gridPatients);
            ButtonsOptions buttonsOptions = new ButtonsOptions(controller, gridPatients, filterOptions);
            
        }
    }
}
