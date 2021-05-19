using HeartAttackApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data;
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
            addPane = new Add_pane(controller, this);
        }

        private void btn_graphics_Click(object sender, EventArgs e)
        {
            main.loadCharts();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addPane.ShowDialog();
        }
        public void loadGrid(List<Patient> patients)
        {
            grid_data.DataSource = null;
            grid_data.DataSource = patients;
        }
        public void newClick()
        {
            grid_data.DataSource = new List<Patient>();
            addPane.SetId(304);
        }
      
        
        public void bt_export_Click(object sender, EventArgs e)
        {

          


            }
           


    public void enableExport() {
            bt_export.Enabled = false;
            btExcelExport.Enabled = true;
        }

        
        private void ExportarDatosExcel(DataGridView datagrid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in datagrid.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in datagrid.Rows)
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in datagrid.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("No have register for export .");
            }
        }

      
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btExcelExport_Click(object sender, EventArgs e)
        {
            ExportarDatosExcel(
                grid_data);
        }
  
    }
}
