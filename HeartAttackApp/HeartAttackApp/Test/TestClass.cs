using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeartAttackApp.Model;

namespace HeartAttackApp.Test
{
    public class TestClass
    {
        public List<Patient> patientsTraing;
        public List<Patient> patientsTesting;
        public DecisionTree decision;

        public TestClass()
        {
            patientsTesting = new List<Patient>();
            patientsTraing = new List<Patient>();
            decision = new DecisionTree();
            files();
            for(int i = 2;i<=9;i++)
            {
                decision.depthLimit = i;
                train();
                double result = test();
                Console.WriteLine("# "+i+" " + result);
            }
        }

        private void train()
        {
            decision.training(patientsTraing);
        }

        private double test()
        {
            return decision.testing(patientsTesting);
        }

        private void files()
        {
            string path = "D:/ICESI/Integrador I/ProjectX/Dataset/Datasets/";
            var reader = new System.IO.StreamReader(File.OpenRead(path + "DataSetTrainingFull.csv"));
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
                /*
                double oldPeak = double.Parse(array[10]);
                int slp = int.Parse(array[11]);
                int caa = int.Parse(array[12]);
                int thall = int.Parse(array[13]);
                */
                int result = int.Parse(array[10]);

                Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                patientsTraing.Add(all);
                line = reader.ReadLine();
            }
            reader = new System.IO.StreamReader(File.OpenRead(path + "DataSetValidFull.csv"));
            line = reader.ReadLine();
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
                /*
                double oldPeak = double.Parse(array[10]);
                int slp = int.Parse(array[11]);
                int caa = int.Parse(array[12]);
                int thall = int.Parse(array[13]);
                */
                int result = int.Parse(array[10]);

                Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate,  result);
                patientsTesting.Add(all);
                line = reader.ReadLine();
            }
        }
    }
}
