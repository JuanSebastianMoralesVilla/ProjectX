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
        private HeavyTasks heavy;
        public bool exported { get; set; }
        public GridPatients()
        {
            InitializeComponent();
        }
        public void initialize(ControllerGUI controller,Main main, ButtonsOptions btnopt, FilterOptions ft,HeavyTasks heavy)
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

        public void exportarExperimento(string[][] mat)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            for (int fila = 0; fila < mat.Length; fila++)
            {
                for (int colum = 0; colum < mat[0].Length; colum++)
                {
                    excel.Cells[fila + 1, colum+1] = mat[fila][colum];
                }
            }
            excel.Visible = true;
        }
        private void btExcelExport_Click(object sender, EventArgs e)
        {
            heavy.Start(1);
            Thread thread = new Thread(new ThreadStart(ExportarDatosExcel));
            thread.Start();
        }

        public void setLoad(double load)
        {
            pb_loadingExperiment.Value = (int)Math.Round(load*100,0);
            if (pb_loadingExperiment.Value == 100)
            {
                btn_experiment.Enabled = true;
                pb_loadingExperiment.Visible = false;
                pb_loadingExperiment.Value = 0;
                lb_wait.Visible = false;
            }
        }
        public void ourTree(bool our)
        {
            main.ourTree(our);
        }

        private void experiment()
        {
            string[][] experimentMatriz = controller.miHospital.generateResultExperiment(3);
            exportarExperimento(experimentMatriz);
        } 
        private void btn_experiment_Click(object sender, EventArgs e)
        {
            DialogResult mes =  MessageBox.Show("This process could take a long time. Are you sure want to start it?", "Information Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mes.Equals(DialogResult.Yes))
            {

                btn_experiment.Enabled = false;
                lb_wait.Visible = true;
                pb_loadingExperiment.Visible = true;
           
                heavy.Start(2);
                Thread thread = new Thread(new ThreadStart(experiment));
                thread.Start();

            }
        }
    }
}
