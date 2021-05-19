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
            ExportarDatos(grid_data);
        
              /*
        
            string csv= string.Empty;

            foreach (DataGridViewColumn column in grid_data.Columns) {
                csv += column.HeaderText + ',';
            }

            csv += "\r\n";

            //" \\ProjectX\\HeartAttackApp\\HeartAttackApp\\Recourses";

            foreach (DataGridViewRow row in grid_data.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    csv += cell.Value.ToString().Replace(",", ";") + ',';


                }
                csv += "\r\n";
            }

            string folderPath = "C:\\Users\\user\\Desktop\\";
            File.WriteAllText(folderPath + "DataGridViewExport.csv",csv);
            MessageBox.Show(" Export finished with exit");
         */
    }


    public void enableExport() {
            bt_export.Enabled = true;
        }


        private void ExportarDatos(DataGridView datalistado)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); // Instancia a la libreria de Microsoft Office
                excel.Application.Workbooks.Add(true); //Con esto añadimos una hoja en el Excel para exportar los archivos
                int IndiceColumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns) //Aquí empezamos a leer las columnas del listado a exportar
                {
                    IndiceColumna++;
                    excel.Cells[1, IndiceColumna] = columna.Name;
                }
                int IndiceFila = 0;
                foreach (DataGridViewRow fila in datalistado.Rows) //Aquí leemos las filas de las columnas leídas
                {
                    IndiceFila++;
                    IndiceColumna = 0;
                    foreach (DataGridViewColumn columna in datalistado.Columns)
                    {
                        IndiceColumna++;
                        excel.Cells[IndiceFila + 1, IndiceColumna] = fila.Cells[columna.Name].Value;
                    }
                }
                excel.Visible = true;
            }
            catch (Exception)
            {
               MessageBox.Show("No hay Registros a Exportar.");
            }
        }
    }
}
