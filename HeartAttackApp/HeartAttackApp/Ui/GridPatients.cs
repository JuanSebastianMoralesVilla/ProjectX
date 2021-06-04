using HeartAttackApp.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using HeartAttackApp.HeavyTask;

namespace HeartAttackApp.Ui
{
    public partial class GridPatients : UserControl
    {
        private Add_pane addPane;
        private ControllerGUI controller;
        private Main main;
        private HeavyTaskExcel heavy;
        public bool exported { get; set; }
        public GridPatients()
        {
            InitializeComponent();
        }
        public void initialize(ControllerGUI controller,Main main, ButtonsOptions btnopt, FilterOptions ft,HeavyTaskExcel heavy)
        {
            this.main = main;
            this.controller = controller;
            addPane = new Add_pane(controller, this, btnopt, ft);
            this.heavy = heavy;
            exported = exported;
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
        }
        public void enableAll(bool enable)
        {
            btExcelExport.Enabled = enable;
            btn_add.Enabled = enable;
            btn_graphics.Enabled = enable;
        }

        // LO HABILITA CUANDO VOY A EXPORTAR UNO O MAS PACIENTES SIN HABER CARGDO LA BD 

        public void enableExport() {
            btExcelExport.Enabled = true;
        }
        
        private void ExportarDatosExcel()
        {
            ExportarDatosExcel(grid_data);
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
            exported = true;
        }

        private void btExcelExport_Click(object sender, EventArgs e)
        {
            heavy.Start();
            Thread thread = new Thread(new ThreadStart(ExportarDatosExcel));
            thread.Start();
        }

        public void ourTree(bool our)
        {
            main.ourTree(our);
        }
    }
}
