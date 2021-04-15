using HeartAttackApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartAttackApp.Ui
{
    public partial class Main_pane : Form
    {
        private string path;

        private Hospital miHospital;

        //private AllPatients data;

        OpenFileDialog file = new OpenFileDialog();


        //  private const String path = @"..\..\..\ProjectX\Dataset\DataSetHeartAtack.xlsx";

      private Add_pane addPane;

        // List<String> listPatients; 

        public Main_pane()
        {
            miHospital = new Hospital();
            //data = new AllPatients();

            InitializeComponent();
            path = @"..\..\Dataset\DatasetLoad.csv";
            string[] values = Patient.matrixE();
            cb_filter.Items.AddRange(values);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         
           addPane = new Add_pane();
            addPane.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string)cb_filter.SelectedItem;
            cb_choose.Visible = false;
            txt_to.Visible = false;
            tb_higger.Visible = false;
            tb_lower.Visible = false;
            tb_cadena.Visible = false;
            btn_search.Visible = false;
            cb_choose.Items.Clear();
            if (!cb_filter.SelectedIndex.Equals(0))
            {
                string [] valuesC = Patient.cadenaValues();
                string [] valuesN = Patient.numericValues();
                string [] valuesB = Patient.binariValue();
                if (valuesC.Contains(selected))
                {
                    tb_cadena.Visible = true;
                }
                else if (valuesN.Contains(selected))
                {
                    txt_to.Visible = true;
                    tb_higger.Visible = true;
                    tb_lower.Visible = true;
                }
                else if (valuesB.Contains(selected))
                {
                    cb_choose.Visible = true;
                    string[] bin = { "0", "1" };
                    cb_choose.Items.AddRange(bin);
                    if (selected.Equals(Patient.TYPE_PAIN))
                    {
                        cb_choose.Items.Add("2");
                    }
                }
               
                btn_search.Visible = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_pane_Load(object sender, EventArgs e)
        {

        }

        private void grid_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {

            file.Filter = "CSV|*.csv";

            if (file.ShowDialog() == DialogResult.OK)
            {
                textBoxLoad1.Text = file.FileName;
                path = file.FileName;
                textBoxLoad2.Text = file.SafeFileName;
                MessageBox.Show("Datos cargados correctamente.");
                miHospital = new Hospital();
                loadGrid();
            }
        }

        private void loadGrid()
        {
            try 
            { 
                var reader = new StreamReader(File.OpenRead(path));
                string line = reader.ReadLine();
                line = reader.ReadLine();
                List<AllPatients> patients = new List<AllPatients>();
                while (!string.IsNullOrEmpty(line))
                {
                    string[] array = line.Split(';');
                    int idPatient = Int32.Parse(array[0]);
                    string year = (array[1]);
                    string genre = (array[2]);
                    string typeDolor = (array[3]);
                    string bloodPressure = (array[4]);
                    string cholesterol = (array[5]);
                    string levelSugar = (array[6]);
                    string resultElectro = (array[7]);
                    string heartRate = (array[8]);
                    string angina = (array[9]);
                    string result = (array[10]);

                    AllPatients all = new AllPatients(idPatient, year, genre, typeDolor, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                    miHospital.add(idPatient, year, genre, typeDolor, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                    patients.Add(all);
                    line = reader.ReadLine();



                }
                grid_data.DataSource = patients;
                cb_filter.Visible = true;
            }
            catch (Exception exception1)
            {
                Console.WriteLine(exception1.ToString());
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }
    }
}
