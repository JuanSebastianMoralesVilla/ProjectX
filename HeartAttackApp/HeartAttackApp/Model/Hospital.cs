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

        public void add(int idPatient, int age, string genre, int typeDolor, int bloodPressure, int cholesterol, int levelSugar, int angina, int resultElectro, int heartRate, int result)
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
            AddRecordToHashTables(patient);
        }

        public void clear()
        {
            patients.Clear();
        }

        public List<Patient> classify(int id)
        {
            List<Patient> result = new List<Patient>();
            foreach(Patient patient in patients)
            {
                if (patient.id.Equals(id))
                {
                    result.Add(patient);
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
                        aux = (patient.age);
                        break;
                    case Patient.BLOOD_PRESSURE:
                        aux = (patient.bloodPressure);
                        break;
                    case Patient.CHOLESTEROL:
                       aux = (patient.cholesterol);
                        break;
                    case Patient.HEART_RATE:
                        aux = (patient.heartRate);
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
                    case Patient.SEX:
                        aux = int.Parse(patient.sex);
                        break;
                    case Patient.TYPE_PAIN:
                        aux = (patient.typePain);
                        break;
                    case Patient.LEVEL_SUGAR:
                        aux = (patient.levelSugar);
                        break;
                    case Patient.RESULT_ELECTRO:
                        aux = (patient.resultElectro);
                        break;
                    case Patient.ANGINA:
                        aux = (patient.angina);
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
            int[] arrayForAverage = { 0, 0 };

            string x = "";
            int aux = 0;
            if (Pat.sex.Equals("0"))
            {
                x = "Woman";
            }
            else
            {
                x = "man";
            }
            if (Pat.result == 1)
            {
                aux = 1;
            }
            if (Cuadro1.ContainsKey(x))
            {
                Cuadro1[x] = ((int)Cuadro1[x] + aux);
            }
            else
            {
                Cuadro1.Add(x, aux);
            }

            string ang = "";
            switch (Pat.angina)
            {
                case 0:
                    ang = "no";
                    break;
                case 1:
                    ang = "yes";
                    break;
            }
            if (Cuadro2.ContainsKey(ang))
            {
                Cuadro2[ang] = ((int)Cuadro2[ang] + 1);
            }
            else
            {
                Cuadro2.Add(ang, 1);
            }

            string edad = "";
            if (Pat.age < 30)
            {
                edad = "Young";
            }
            else if (Pat.age < 60)
            {
                edad = "adult";
            } else
            {
                edad = "elder";
            }


            if (Cuadro3.ContainsKey(edad))
            {
                Cuadro3[edad] = ((int)Cuadro3[edad] + 1);
            }
            else
            {
                Cuadro3.Add(edad, 1);
            }

            string angi = "";
            switch (Pat.typePain)
            {
                case 0:
                    angi = "typic";
                    break;
                case 1:
                    angi = "atypic";
                    break;
                case 3:
                    angi = "Asymptomatic";
                    break;

            }
            if (angi != "") { 

                if (Cuadro4.ContainsKey(angi))
                {
                    Cuadro4[angi] = ((int)Cuadro4[angi] + 1);
                }
                else
                {
                    Cuadro4.Add(angi, 1);
                }
            }
            string colesterol = "";
            if (Pat.cholesterol < 200)
            {
                colesterol = "desirable";
            }
            else if (Pat.cholesterol < 239)
            {
                colesterol = "max limit";
            }
            else if (Pat.cholesterol < 300)
            {
                colesterol = "exceed limit";
            }
            else
            {
                colesterol = "extremly bad";
            }
            
            if (Cuadro5.ContainsKey(colesterol))
            {
                Cuadro5[ colesterol] = ((int)Cuadro5[colesterol] + 1);
            }
            else
            {
                Cuadro5.Add(colesterol, 1);
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

        public List<string[]> Cuadro2Conversor()
        {
            List<string[]> datos = new List<string[]>();
            foreach (DictionaryEntry i in Cuadro2)
            {
                string[] dato = new string[2];
                dato[0] = (string)i.Key;
                dato[1] = "" + i.Value;
                datos.Add(dato);
            }
            return datos;
        }

        public List<string[]> Cuadro3Conversor()
        {
            List<string[]> datos = new List<string[]>();
            foreach (DictionaryEntry i in Cuadro3)
            {
                string[] dato = new string[2];
                dato[0] = (string)i.Key;
                dato[1] = "" + i.Value;
                datos.Add(dato);
            }
            return datos;
        }

        public List<string[]> Cuadro4Conversor()
        {
            List<string[]> datos = new List<string[]>();
            foreach (DictionaryEntry i in Cuadro4)
            {
                string[] dato = new string[2];
                dato[0] = (string)i.Key;
                dato[1] = "" + i.Value;
                datos.Add(dato);
            }
            return datos;

        }

        public List<string[]> Cuadro5Conversor()
        {
            List<string[]> datos = new List<string[]>();
            foreach (DictionaryEntry i in Cuadro5)
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
