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
        
        
        

        public void inicialize(ControllerGUI controller, GridPatients gridPatiens, FilterOptions filterOptions)
        {
            this.controller = controller;
            this.gridPatiens = gridPatiens;
            file = new OpenFileDialog();
            this.filterOptions = filterOptions;
            btn_new.Enabled = false;
            btn_solve.Enabled = false;
        }

        public void enableButtons() {

            btn_new.Enabled = true;
            btn_solve.Enabled = true;
        }
        public ButtonsOptions()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

            
            gridPatiens.newClick();
          
            controller.clear();
            textBoxLoad1.Clear();
            textBoxLoad2.Clear();
            btn_solve.Enabled = false;
            
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
                controller.loadGrid(path);
                patients = controller.patient();
                Console.WriteLine(patients.Count);
                gridPatiens.loadGrid(patients);
                filterOptions.cb_filterSetVisible(true);
                btn_new.Enabled = true;
                btn_solve.Enabled = true;
                gridPatiens.enableExport();
            }
        }


        private void btn_solve_Click(object sender, EventArgs e)
        {
            controller.solve();
            filterOptions.clear();
            filterOptions.cb_filterSetVisible(true);
            gridPatiens.loadGrid(controller.patient());
        }
    }
}
