using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    public class Patient
    {
        //  CONST
        public const string ID = "idPatient";
        public const string AGE = "age";
        public const string SEX = "sex";
        public const string TYPE_PAIN = "typePain";
        public const string BLOOD_PRESSURE = "blood pressure";
        public const string CHOLESTEROL = "cholesterol";
        public const string LEVEL_SUGAR = "level of sugar";
        public const string ANGINA = "angina";
        public const string RESULT_ELECTRO = "electrocardiographic results";
        public const string HEART_RATE = "heart rate";
        //  public const string RESULT = "result";

        public int id { get; set; }
        public int age { get; set; }

        // bolean
        public string sex { get; set; } //man or woman
        // int
        public int typePain { get; set; }

        public int bloodPressure { get; set; }
        public int cholesterol { get; set; }

        public int levelSugar { get; set; }

        // boolean
        public int angina { get; set; } // 0 para no, 1 para si

        public int resultElectro { get; set; }

        public int heartRate { get; set; }

        public int? result { get; set; }

        public Patient(int id, int age, string sex, int typePain, int bloodPressure, int cholesterol, int levelSugar, int angina, int resultElectro, int heartRate)
        {
            this.id = id;
            this.age = age;
            this.sex = sex;
            this.typePain = typePain;
            this.bloodPressure = bloodPressure;
            this.cholesterol = cholesterol;
            this.levelSugar = levelSugar;
            this.angina = angina;
            this.resultElectro = resultElectro;
            this.heartRate = heartRate;
            this.result = null;
        }

        public int get(int index)
        {
            string[] values =  toString().Split(' ');
            int[] valuesInt = new int[values.Length];
            
            for (int i = 0; i < values.Length; i++) {
                valuesInt[i] = int.Parse(values[i]);
            }
            return valuesInt[index];
        }

        public static string[] matrixE()
        {
            string[] result = { ID, AGE , SEX, TYPE_PAIN,BLOOD_PRESSURE,
                                CHOLESTEROL,LEVEL_SUGAR,ANGINA,RESULT_ELECTRO,
                                HEART_RATE};
            return result;
        }

        public static string[] cadenaValues()
        {
            string[] result = { ID };
            return result;
        }

        public static string[] numericValues()
        {

            string[] result =  {AGE,BLOOD_PRESSURE,
                                CHOLESTEROL,
                                HEART_RATE};
            return result;
        }

        public static string[] binariValue()
        {

            string[] result = { SEX, TYPE_PAIN,
                                LEVEL_SUGAR,ANGINA,
                                RESULT_ELECTRO};
            return result;
        }

        public string toString()
        {
            return id + " " + age + " " + sex + " " + typePain + " " + bloodPressure + " " + cholesterol + " " + levelSugar + " " + angina + " " + resultElectro + " " + heartRate + " " + result;
        }

        public 
        /*
        public string[] toTrain()
        {
            string[] aux = toString().Split(' ');
            string[] result = new string[aux.Length - 1];
            for (int i = 1; i < aux.Length; i++)
            {
                result[i - 1] = aux[i];
            }

            return result;
        }

        public string[] toTest()
        {
            string[] aux = toString().Split(' ');
            string[] result = new string[aux.Length - 1];
            for (int i = 0; i < aux.Length; i++)
            {
                result[i] = aux[i];
            }

            return result;
        }
        */
    }
}

