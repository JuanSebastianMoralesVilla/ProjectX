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
    public partial class ButtonsOptions : UserControl
    {
        private ControllerGUI controller;
        private GridPatients gridPatiens;
        private OpenFileDialog file;
        private FilterOptions filterOptions;
        public ButtonsOptions(ControllerGUI controller, GridPatients gridPatiens, FilterOptions filterOptions)
        {
            this.controller = controller;
            this.gridPatiens = gridPatiens;
            InitializeComponent();
            file = new OpenFileDialog();
            this.filterOptions = filterOptions;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            gridPatiens.newClick();
            filterOptions.clear();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            file.Filter = "CSV|*.csv";
            List<Patient> patients = new List<Patient>();
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBoxLoad1.Text = file.FileName;
                string path = file.FileName;
                textBoxLoad2.Text = file.SafeFileName;
                MessageBox.Show("Datos cargados correctamente.");
                patients = controller.loadGrid(path);
                Console.WriteLine(patients.Count);
                gridPatiens.loadGrid(patients);
                filterOptions.cb_filterSetVisible(true);
            }
        }
    }
}
