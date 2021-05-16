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
        public const string TYPE_PAIN = "type Pain";
        public const string BLOOD_PRESSURE = "blood pressure";
        public const string CHOLESTEROL = "cholesterol";
        public const string LEVEL_SUGAR = "level sugar";
        public const string ANGINA = "angina";
        public const string RESULT_ELECTRO = "electro results";
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

        public Patient(int id, int age, int sex, int typePain, int bloodPressure, int cholesterol, int levelSugar, int angina, int resultElectro, int heartRate)
        {
            this.id = id;
            this.age = age;
            this.sex = sex == 0 ? "F" : sex == 1?"M":null;
            this.typePain = typePain;
            this.bloodPressure = bloodPressure;
            this.cholesterol = cholesterol;
            this.levelSugar = levelSugar;
            this.angina = angina;
            this.resultElectro = resultElectro;
            this.heartRate = heartRate;
            this.result = null;
        }

        public Patient(int id, int age, int sex, int typePain, int bloodPressure, int cholesterol, int levelSugar, int angina, int resultElectro, int heartRate,int result)
        {
            this.id = id;
            this.age = age;
            this.sex = sex == 0 ? "F" : sex == 1 ? "M" : null;
            this.typePain = typePain;
            this.bloodPressure = bloodPressure;
            this.cholesterol = cholesterol;
            this.levelSugar = levelSugar;
            this.angina = angina;
            this.resultElectro = resultElectro;
            this.heartRate = heartRate;
            this.result = result;
        }

        public int get(int index)
        {
            string[] values =  toString().Split(' ');
            int[] valuesInt = new int[values.Length];
            
            for (int i = 0; i < values.Length; i++) {
                if (i == 2)
                {
                    valuesInt[i] = values[i] == "F" ? 0 : values[i] == "M"? 1:-1;
                }
                else if (i == 10)
                {
                    valuesInt[i] = values[i] == "" ? -1 : int.Parse(values[i]);
                }
                else{
                    valuesInt[i] = int.Parse(values[i]);
                }
                
            }
            return valuesInt[index];
        }

        public static string getNamesColums(int index)
        {
            string[] matrix = matrixE();
            matrix = matrix[index].Split(' ');
            string result = "";
            for(int i= 0; i < matrix.Length; i++)
            {
                
                result += matrix[i] + "\n";
            }
            return result;
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

        public static bool isCategoric(int i)
        {
            if (i == 4 || i == 5 || i == 9 )
            {
                return false;
            }
            return true;
        }
        
    }
}

