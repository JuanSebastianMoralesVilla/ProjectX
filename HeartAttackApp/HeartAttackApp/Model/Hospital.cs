using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    class Hospital
    {
        public List<Patient> patients{ get; set; }

        public int size;

        public Hospital()
        {
          patients = new List<Patient> ();
          this.size = 0;
        }

        public void add(int idPatient, string year, string genre, string typeDolor, string bloodPressure, string cholesterol, string levelSugar, string angina, string resultElectro, string heartRate, string result)
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
               patient = new Patient(idPatient, year, genre, typeDolor, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                patients.Add(patient);
                size++;
            }

            patients.Add(patient);
            
        }

        }
}
