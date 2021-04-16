using System;
using System.Collections.Generic;
using System.Linq;
using HeartAttackApp.Model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HeartAttackApp.Ui
{
    class ControllerGUI
    {
        private string path;

        private Hospital miHospital;

        //private AllPatients data;

        OpenFileDialog file = new OpenFileDialog();


        //  private const String path = @"..\..\..\ProjectX\Dataset\DataSetHeartAtack.xlsx";

        private Add_pane addPane;

        // List<String> listPatients; 

        public ControllerGUI()
        {
            miHospital = new Hospital();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addPane = new Add_pane();
            addPane.ShowDialog();
        }


        private void loadFile(string fileName, string safeFileName)
        {
            file.Filter = "CSV|*.csv";
           
            MessageBox.Show("Datos cargados correctamente.");
            miHospital = new Hospital();
            loadGrid();
        }
        private List<Patient> loadGrid()
        {
            List<Patient> patients = new List<Patient>();
            try
            {
                var reader = new System.IO.StreamReader(File.OpenRead(path));
                string line = reader.ReadLine();
                line = reader.ReadLine();
                
                while (!string.IsNullOrEmpty(line))
                {
                    string[] array = line.Split(';');
                    int idPatient = int.Parse(array[0]);
                    int year = int.Parse(array[1]);
                    string genre = (array[2]);
                    int typePain = int.Parse(array[3]);
                    int bloodPressure = int.Parse(array[4]);
                    int cholesterol = int.Parse(array[5]);
                    int levelSugar = int.Parse(array[6]);
                    int resultElectro = int.Parse(array[7]);
                    int heartRate = int.Parse(array[8]);
                    int angina = int.Parse(array[9]);
                    int result = int.Parse(array[10]);

                    Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate);
                    miHospital.add(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                    patients.Add(all);
                    line = reader.ReadLine();
                }
            }
            catch (Exception exception1)
            {
                Console.WriteLine(exception1.ToString());
            }
            return patients;
        }

        public void method()
        {
            string selected = cb_filter.SelectedItem.ToString();//parametro
            string[] valuesC = Patient.cadenaValues();
            string[] valuesN = Patient.numericValues();
            string[] valuesB = Patient.binariValue();
            List<Patient> patients = new List<Patient>();
            try
            {
                if (valuesC.Contains(selected))
                {
                    int id = int.Parse(tb_cadena.Text);//paremetro
                    patients = miHospital.classify(id);
                }
                else if (valuesN.Contains(selected))
                {
                    int lower = Math.Abs(int.Parse(tb_lower.Text));
                    int higger = Math.Abs(int.Parse(tb_higger.Text));
                    tb_lower.Text = lower.ToString();
                    tb_higger.Text = higger.ToString();

                    patients = miHospital.classify(selected, lower, higger);
                }
                else if (valuesB.Contains(selected))
                {
                    int value = int.Parse(cb_choose.SelectedItem.ToString());

                    patients = miHospital.classify(selected, value);
                }
                else
                {
                    patients = miHospital.patients;
                }
                grid_data.DataSource = patients;
            }
            catch (FormatException t)
            {
                Console.WriteLine(t.Message);
            }
        }
        public List<string[]> RetrieveCuadro1()
        {
            return
     }

        public List<string[]> RetrieveCuadro2()
        {


        }
        public List<string[]> RetrieveCuadro3()
        {

        }

        public List<string[]> RetrieveCuadro4()
        {

        }

        public List<string[]> RetrieveCuadro5()
        {


        }
    }


    

}

