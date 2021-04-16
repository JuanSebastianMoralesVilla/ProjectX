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
                    int idPatient = Int32.Parse(array[0]);
                    string year = (array[1]);
                    string genre = (array[2]);
                    string typePain = (array[3]);
                    string bloodPressure = (array[4]);
                    string cholesterol = (array[5]);
                    string levelSugar = (array[6]);
                    string resultElectro = (array[7]);
                    string heartRate = (array[8]);
                    string angina = (array[9]);
                    string result = (array[10]);

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

        
       
    }

}

