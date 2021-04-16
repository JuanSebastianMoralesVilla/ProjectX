using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    class Hospital
    {
        public List<Patient> patients{ get; set; }

        public Hashtable Cuadro1 { get; set; }
        public Hashtable Cuadro2 { get; set; }
        public Hashtable Cuadro3 { get; set; }
        public Hashtable Cuadro4 { get; set; }
        public Hashtable Cuadro5 { get; set; }

        public int size;

        public Hospital()
        {
            patients = new List<Patient> ();
            this.size = 0;
            Cuadro1 = new Hashtable();
            Cuadro2 = new Hashtable();
            Cuadro3 = new Hashtable();
            Cuadro4 = new Hashtable();
            Cuadro5 = new Hashtable();
        }

        public void add(int idPatient, string age, string genre, string typeDolor, string bloodPressure, string cholesterol, string levelSugar, string angina, string resultElectro, string heartRate, string result)
        {
            Patient patient = null;
            for (int i = 0; i < size; i++) {
                if (patients.ElementAt(i).id ==idPatient )
                {
                    patient =patients.ElementAt(i);
                    break;
                }
            }
            if (patient == null)
            {
               patient = new Patient(idPatient, age, genre, typeDolor, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate);
                patients.Add(patient);
                size++;
            }
        }

        public List<Patient> classify(int id)
        {
            List<Patient> result = new List<Patient>();
            foreach(Patient patient in patients)
            {
                if (patient.id.Equals(id))
                {
                    result.Add(patient); ;
                    break;
                }
            }
            
            return result;
        }

        public List<Patient> classify(string type, int lower,int higger)
        {
            List<Patient> result = new List<Patient>();
            int aux = 0;
            foreach (Patient patient in patients)
            {
                switch (type)
                {
                    case Patient.AGE:
                        aux = int.Parse(patient.age);
                        break;
                    case Patient.BLOOD_PRESSURE:
                        aux = int.Parse(patient.bloodPressure);
                        break;
                    case Patient.CHOLESTEROL:
                       aux = int.Parse(patient.cholesterol);
                        break;
                    case Patient.HEART_RATE:
                        aux = int.Parse(patient.heartRate);
                        break;
                    default:
                        aux = 0;
                        break;
                }
                if (aux >= lower && aux <= higger)
                {
                    result.Add(patient);
                }
            }

            return result;
        }

        public List<Patient> classify(string type, int value)
        {
            List<Patient> result = new List<Patient>();
            int aux = 0;
            foreach (Patient patient in patients)
            {
                switch (type)
                {
                    case Patient.GENRE:
                        aux = int.Parse(patient.genre);
                        break;
                    case Patient.TYPE_PAIN:
                        aux = int.Parse(patient.typePain);
                        break;
                    case Patient.LEVEL_SUGAR:
                        aux = int.Parse(patient.levelSugar);
                        break;
                    case Patient.RESULT_ELECTRO:
                        aux = int.Parse(patient.resultElectro);
                        break;
                    case Patient.ANGINA:
                        aux = int.Parse(patient.angina);
                        break;
                    default:
                        aux = 0;
                        break;
                }
                if (aux == value)
                {
                    result.Add(patient);
                }
            }

            return result;
        }

        public void AddRecordToHashTables(Patient Pat)
        {
            int oneUnit = 1;
            int[] arrayForAverage = { 0, 0 };

            if (Cuadro1.ContainsKey(Pat.genre))
            {
                object objArray = Cuadro1[Pat.genre];
                if (objArray != null)
                {
                    arrayForAverage = (int[])objArray;

                    arrayForAverage[0] = arrayForAverage[0] + 1;

                }
            }
        }


        public List<string[]> Cuadro1Conversor()
        {
            List<string[]> datos = new List<string[]>();
            foreach (DictionaryEntry i in  Cuadro1)
            {
                string[] dato = new string[2];
                dato[0] = (string)i.Key;
                dato[1] = "" + i.Value;
                datos.Add(dato);
            }
            return datos;
        }
    }
}
