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
        public GridPatients(ControllerGUI controller)
        {
            this.controller = controller;
            InitializeComponent();
        }

        private void grid_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_graphics_Click(object sender, EventArgs e)
        {
            Show_Chart ch = new Show_Chart(controller.RetrieveCuadro1(), controller.RetrieveCuadro2(), controller.RetrieveCuadro3(), controller.RetrieveCuadro4(), controller.RetrieveCuadro5());
            ch.Show();
            MessageBox.Show("Se han generado las graficas");
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addPane = new Add_pane();
            addPane.ShowDialog();
        }
        public void loadGrid(List<Patient> patients)
        {
            grid_data.DataSource = patients;
        }
        public void newClick()
        {
            grid_data.DataSource = controller.patient();
        }
    }
}
