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
    public class ControllerGUI
    {

        public Hospital miHospital { get; private set; }


        public ControllerGUI(PictureBox ptb)
        {
            miHospital = new Hospital(ptb);
        }

       
        public List<Patient> patient()
        {
            return miHospital.classify();
        }
        
        public void add(int idPatient, int age, int sex, int typePain, int bloodPressure, int cholesterol, int levelSugar, int angina, int resultElectro, int heartRate)
        {
            miHospital.add(idPatient, age, sex, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate,null);
        }
        public void solve()
        {
            miHospital.resolve();
        }
        public void clear()
        {
            miHospital.clear();
        }
        public void training()
        {
            miHospital.training();
            miHospital.visualize();
        }
        public List<Patient> loadGrid(string path)
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
                    int genre = int.Parse(array[2]);
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
            catch (FormatException exception1)
            {
                Console.WriteLine(exception1.Message);
            }
            return patients;
        }

        
        public List<Patient> search(int id)
        {
            List<Patient> patients = new List<Patient>();
            patients = miHospital.classify(id);
            return patients;
        }

        public List<Patient> search(string type,int lower,int higger)
        {
            List<Patient> patients = new List<Patient>();
            patients = miHospital.classify(type,lower, higger);
            return patients;
        }

        public List<Patient> search(string type,int id)
        {
            List<Patient> patients = new List<Patient>();
            patients = miHospital.classify(type,id);
            return patients;
        }

        public List<string[]> RetrieveCuadro1()
        {
            return miHospital.Cuadro1Conversor();
        }

        public List<string[]> RetrieveCuadro2()
        {
            return miHospital.Cuadro2Conversor();

        }
        public List<string[]> RetrieveCuadro3()
        {
            return miHospital.Cuadro3Conversor();
        }

        public List<string[]> RetrieveCuadro4()
        {
            return miHospital.Cuadro4Conversor();
        }

        public List<string[]> RetrieveCuadro5()
        {
            return miHospital.Cuadro5Conversor();

        }
    }
}



