using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    class Patient



    {
        // CONST
        public const string ID = "idPatient";
        public const string AGE = "age";
        public const string GENRE = "genre";
        public const string TYPE_PAIN = "typePain";
        public const string BLOOD_PRESSURE = "blood pressure";
        public const string CHOLESTEROL = "cholesterol";
        public const string LEVEL_SUGAR = "level of sugar";
        public const string ANGINA = "angina";
        public const string RESULT_ELECTRO = "electrocardiographic results";
        public const string HEART_RATE = "heart rate";
        //public const string RESULT = "result";

        public int id { get; set; }
        public string age { get; set; }

        // bolean
        public string genre { get; set; }
        // int
        public string typePain { get; set; }

        public string bloodPressure { get; set; }


        public string cholesterol { get; set; }

        public string levelSugar { get; set; }
        

        // boolean
        public string angina { get; set; }

        public string resultElectro { get; set; }

        public string heartRate { get; set; }

        public string result { get; set; }

        public Patient(int id, string age, string genre, string typePain, string bloodPressure, string cholesterol, string levelSugar, string angina, string resultElectro, string heartRate)
        {
            this.id = id;
            this.age = age;
            this.genre = genre;
            this.typePain = typePain;
            this.bloodPressure = bloodPressure;
            this.cholesterol = cholesterol;
            this.levelSugar = levelSugar;
            this.angina = angina;
            this.resultElectro = resultElectro;
            this.heartRate = heartRate;
            this.result = "N/A";
        }



        public static string[] matrixE()
        {
         
            string[] result = { ID, AGE , GENRE, TYPE_PAIN,BLOOD_PRESSURE, 
                                CHOLESTEROL,LEVEL_SUGAR,ANGINA,RESULT_ELECTRO,
                                HEART_RATE};
            return result;
        }

        public static string[] cadenaValues()
        {
            string[] result = {ID};
            return result;
        }

        public static string[] numericValues()
        {

            string[] result = {AGE , BLOOD_PRESSURE,
                                CHOLESTEROL,
                                HEART_RATE};
            return result;
        }

        public static string[] binariValue()
        {

            string[] result = { GENRE, TYPE_PAIN,
                                LEVEL_SUGAR,ANGINA,
                                RESULT_ELECTRO};
            return result;
        }

        public String toString()
        {
            return id + age + genre +typePain + bloodPressure + cholesterol + levelSugar + angina + resultElectro + heartRate + result;
        }
    }

    }

