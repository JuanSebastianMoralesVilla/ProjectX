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



        // List<String> listPatients; 

        public Main_pane()
        {
            miHospital = new Hospital();
            //data = new AllPatients();

            InitializeComponent();
            path = @"..\..\Dataset\DatasetLoad.csv";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        }
         catch (Exception exception1)
            {
                Console.WriteLine(exception1.ToString());
            }
}


    }
}
