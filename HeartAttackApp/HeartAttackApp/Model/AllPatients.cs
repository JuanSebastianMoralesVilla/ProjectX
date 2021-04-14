using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    class AllPatients
       
    {

        public int idPatient { get; set; }
        public string year { get; set; }

        // bolean
        public string genre { get; set; }
        // int
        public string typeDolor { get; set; }

        public string bloodPressure { get; set; }


        public string cholesterol { get; set; }

        public string levelSugar { get; set; }


        // boolean
        public string angina { get; set; }

        public string resultElectro { get; set; }

        public string heartRate { get; set; }

        public string result { get; set; }

        private const String path = @"..\..\..\ProjectX\Dataset\DataSetHeartAtack.xlsx";



        List<String> listPatients;

        public AllPatients(int idPatient, string year, string genre, string typeDolor, string bloodPressure, string cholesterol, string levelSugar, string angina, string resultElectro, string heartRate, string result)
        {
            this.idPatient = idPatient;
            this.year = year;
            this.genre = genre;
            this.typeDolor = typeDolor;
            this.bloodPressure = bloodPressure;
            this.cholesterol = cholesterol;
            this.levelSugar = levelSugar;
            this.angina = angina;
            this.resultElectro = resultElectro;
            this.heartRate = heartRate;
            this.result = result;
        }


        public String toString() {
            return idPatient + year + genre + typeDolor + bloodPressure + cholesterol + levelSugar + angina + resultElectro + heartRate + result;
        }
      
    }
}
