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
    public partial class GridPatients : UserControl
    {
        private Add_pane addPane;
        private ControllerGUI controller;
        private Main main;
        public GridPatients()
        {
            InitializeComponent();
        }
        public void initialize(ControllerGUI controller,Main main)
        {
            this.main = main;
            this.controller = controller;
        }

        private void btn_graphics_Click(object sender, EventArgs e)
        {
            main.loadCharts();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addPane = new Add_pane(controller,this);
            addPane.ShowDialog();
        }
        public void loadGrid(List<Patient> patients)
        {
            grid_data.DataSource = patients;
        }
        public void newClick()
        {
            grid_data.DataSource = new List<Patient>();
        }
    }
}
