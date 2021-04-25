using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    public class DecisionTree
    {
        //private DecisionTree currentNode;
        private DecisionTree[] childrenNode;
        private List<Patient> trainingSet;
        private int column;
        private int splitBloodPressure;
        private int splitCholesterol;
        private int splitHeartRate;
        private int? asnswer;
        public DecisionTree()
        {
            column = -1;
            asnswer = -1;
        }

        public void training(List<Patient> patients)
        {
            this.trainingSet = patients;
            /*
            int auxBP = 0;
            int auxC = 0;
            int auxHR = 0;
            foreach(Patient patient in trainingSet)
            {
                if (patient.get(4)!=-1) //bloodPressure
                {
                    auxBP++;
                }
                else if (column == 5) //
                {
                    auxC++;
                }
                else if (column == 9)
                {
                    auxHR++;
                }
            }
            */
            training();
        }
        private void training()
        {
            bool haveAtributes = false;
            for (int i = 1; i <= 9&&haveAtributes==false; i++)
            {
                if (trainingSet.ElementAt(0).get(i) != -1)
                {
                    haveAtributes = true;
                }
            }
            if (haveAtributes)
            {
                double mainEntropy = entropy();

                if (mainEntropy == 0)
                {
                    asnswer = trainingSet.ElementAt(0).result;
                }
                else
                {
                    double[] gain = new double[9];
                    double max = -1;
                    int index = 0;
                    for (int i = 1; i <= 9; i++)
                    {
                        gain[i - 1] = mainEntropy - entropy(i);
                        if (max < gain[i - 1])
                        {
                            index = i;
                            max = gain[i - 1];
                        }
                    }
                    column = index;
                    splitContinuValues();
                    int aux = 2;
                    if (column == 1 || column == 3 || column ==7)//variables de 3 valores  
                    {
                        aux = 3;
                    }
                    childrenNode = new DecisionTree[aux];
                    for (int i = 0; i < aux; i++)
                    {
                        List<Patient> newPatients = new List<Patient>();
                        foreach (Patient patient in trainingSet)
                        {
                            int[] values = new int[10];
                            for (int j = 0; j < 11; j++)
                            {
                                values[j] = patient.get(j);
                            }
                            values[column] = -1;
                            Patient newPatient = new Patient(values[0], values[1], "" + values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
                            newPatients.Add(newPatient);
                        }
                        DecisionTree child = new DecisionTree();
                        child.training(newPatients);
                        childrenNode[i] = child;
                    }
                }
            }
            else
            {
                int ammountYes = 0;
                int ammountNo = 0;
                foreach (Patient patient in trainingSet)
                {
                    if (patient.result == 0)
                    {
                        ammountNo++;
                    }
                    else
                    {
                        ammountYes++;
                    }
                }
                if (ammountNo > ammountYes)
                {
                    asnswer = 0;
                }
                else
                {
                    asnswer = 1;
                }
            }
        }

        private void splitContinuValues()
        {
            int max = 0;
            int min = int.MaxValue;
            foreach(Patient patient in trainingSet)
            {
                if (patient.get(column) > max)
                {
                    max = patient.get(column);
                }

                if (patient.get(column) < min)
                {
                    min = patient.get(column);
                }
            }
            int mid = max / min;
            int[] values = {mid,mid+(max/mid), mid-(mid/min)};
            double minEntripy = double.MaxValue;
            int index = 0;
            for(int i = 0; i < values.Length; i++)
            {
                if (column == 4) //bloodPressure
                {
                    splitBloodPressure = values[i];
                }
                else if (column == 5) //
                {
                    splitCholesterol = values[i];
                }
                else if (column == 9)
                {
                    splitHeartRate = values[i];
                }
                double aux = entropy(column);
                if (aux < minEntripy)
                {
                    minEntripy = aux;
                    index = i;
                }
            }
            if (column == 4) //bloodPressure
            {
                splitBloodPressure = values[index];
            }
            else if (column == 5) //
            {
                splitCholesterol = values[index];
            }
            else if (column == 9)
            {
                splitHeartRate = values[index];
            }
            
            
        }

        private double entropy()
        {
            int ammountYes = 0;
            int ammountNo = 0;
            foreach(Patient patient in trainingSet)
            {
                if (patient.result == 0)
                {
                    ammountNo++;
                }
                else
                {
                    ammountYes++;
                }
            }
            int total = ammountNo + ammountYes;
            if(total==ammountNo || total == ammountYes)
            {
                return 0;
            }
            double result = (ammountYes/total) *Math.Log(ammountYes /total, 2) + (ammountNo /total)*Math.Log(ammountNo /total, 2);
            return result;
        }

        private double entropy(int column)
        {
            
            int total = 0;
            int[] ammountYes = new int[3];
            int[] ammountNo = new int[3];
            foreach (Patient patient in trainingSet)
            {
                total++;
                int value = patient.get(column);
                //When is evaluating the age column
                if (column == 1)
                {
                    if (value < 30)//Young
                    {
                        value =0;
                    }
                    else if (value < 60)//Adult
                    {
                        value = 1;
                    }
                    else//Elder
                    {
                        value = 2;

                    }
                }
                else if (column == 4) //bloodPressure
                {
                    if(value < splitBloodPressure)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = 1;
                    }
                }
                else if (column == 5) //
                {
                    if (value < splitCholesterol)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = 1;
                    }
                }
                else if (column == 9)
                {
                    if (value < splitHeartRate)
                    {
                        value = 0;
                    }
                    else
                    {
                        value = 1;
                    }
                }
                if (patient.result == 1)
                {
                    ammountYes[value]++;
                }
                else
                {
                    ammountNo[value]++;
                }
            }
            double result = 0;
            
            for (int i = 0; i < ammountYes.Length; i++)
            {
                //MEJORAR LEGIBILIDAD
                if (ammountNo[i] != 0 && ammountYes[i] != 0)
                {
                    result += ((ammountYes[i] + ammountNo[i]) / total) * ((ammountYes[i] / (total)) * Math.Log(ammountYes[i] / (total), 2) - ((total - ammountYes[i]) / (total)) * Math.Log((ammountNo[i]) / (total), 2));
                }
            }
            
            return result;
        }
    }
}
