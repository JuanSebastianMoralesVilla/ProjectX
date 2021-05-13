using System;
using System.Collections;
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

        public int depth { get; set; }
        public int depthLimit { get; set; }
        public DecisionTree()
        {
            column = -1;
            asnswer = -1;
            depth = 0;
            depthLimit = 3;
        }

        public void training(List<Patient> patients)
        {
            this.trainingSet = patients;
            training();
        }
        private void training()
        {
            bool haveAtributes = false;
            for (int i = 1; i <= 9 && haveAtributes==false && trainingSet.Count>0 && depth<=depthLimit; i++)
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
                        if (trainingSet.ElementAt(0).get(i) != -1)
                        {
                            if (!Patient.isCategoric(i))
                            {
                                splitContinuValues(i);
                            }
                            gain[i - 1] = mainEntropy - entropy(i);
                            if (max < gain[i - 1])
                            {
                                index = i;
                                max = gain[i - 1];
                            }
                        }
                    }
                    column = index;
                    int aux = 2;
                    if (column == 1 || column == 8)//variables de 3 valores  
                    {
                        aux = 3;
                    }
                    else if (column == 3) aux = 4;
                    childrenNode = new DecisionTree[aux];
                    List<Patient>[] all = new List<Patient>[aux];
                    for (int i = 0; i < all.Length; i++)
                    {
                        all[i] = new List<Patient>();
                    }
                    List<Patient> newPatients = new List<Patient>();
                    foreach (Patient patient in trainingSet)
                    {
                        int value = patient.get(column);
                        double safe = 0;
                        if (!Patient.isCategoric(column))
                        {
                            if (column == 4)
                            {
                                safe = splitBloodPressure;
                            }
                            else if (column == 5)
                            {
                                safe = splitCholesterol;
                            }
                            else if (column == 9)
                            {
                                safe = splitHeartRate;
                            }
                            
                            if (patient.get(column) < safe)
                            {
                                value = 0;
                            }
                            else
                            {
                                value = 1;
                            }
                        }
                        if (column == 1)
                        {
                            
                            if (value < 30)//Young
                            {
                                value = 0;
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
                        int[] values = new int[11];
                        for (int j = 0; j < 11; j++)
                        {
                            values[j] = patient.get(j);
                        }
                        values[column] = -1;
                        Patient newPatient = new Patient(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10]);
                        all[value].Add(newPatient);
                    }
                    for (int i = 0; i < childrenNode.Length; i++)
                    {
                        DecisionTree child = new DecisionTree();
                        child.depth = depth + 1;
                        child.depthLimit = depthLimit;
                        child.training(all[i]);
                        childrenNode[i] = child;
                    }
                }
            }
            else
            {
                double ammountYes = 0;
                double ammountNo = 0;
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
                if (ammountYes/(ammountYes+ ammountNo)>0.54)
                {
                    asnswer = 1;
                }
                else
                {
                    asnswer = 0;
                }
            }
        }

      
        private void splitContinuValues(int column)
        {
            
            List<int> values = new List<int>();
            foreach (Patient patient in trainingSet)
            {
                
                int value = patient.get(column);
                if (!values.Contains(value))
                {
                    values.Add(value);
                }
               
            }
            double minEntripy = double.MaxValue;
            int index = 0;
            for (int i = 0; i < values.Count; i++)
            {
                if (column == 4)
                {
                    splitBloodPressure = (int)values[i];
                }
                else if (column == 5)
                {
                    splitCholesterol = (int)values[i];
                }
                else if (column == 9)
                {
                    splitHeartRate = (int)values[i];
                }
                double aux = entropy(column);
                if (aux < minEntripy)
                {
                    minEntripy = aux;
                    index = i;
                }
            }
            if (column == 4)
            {
                splitBloodPressure = (int)values[index];
            }
            else if (column == 5)
            {
                splitCholesterol = (int)values[index];
            }
            else if (column == 9)
            {
                splitHeartRate = (int)values[index];
            }

        }
        private double entropy()
        {
            double ammountYes = 0;
            double ammountNo = 0;
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
            double total = ammountNo + ammountYes;
            if(total==ammountNo || total == ammountYes)
            {
                return 0;
            }
            double result = -(ammountYes/total) *Math.Log(ammountYes /total, 2) - (ammountNo /total)*Math.Log(ammountNo /total, 2);
            return result;
        }

        private double entropy(int column)
        {

            double total = 0;
            double[] ammountYes = new double[4];
            double[] ammountNo = new double[4];
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

                if (ammountNo[i] != 0 && ammountYes[i] != 0)
                {
                    double auxYes = -(ammountYes[i] / total) * Math.Log(ammountYes[i] / (total), 2); //-P(A)*Log2(P(A)
                    double auxNo = -(ammountNo[i] / (total)) * Math.Log((ammountNo[i]) / (total), 2); //-P(B)*Log2(P(B)
                    result += ((ammountYes[i] + ammountNo[i]) / total) * (auxNo + auxYes);  // P(AB)*Suma(de los de lo anterior)
                }
            }


            return result;
        }

        private int? output(Patient patient)
        {
            if (asnswer != -1)
            {
                return asnswer;
            }
            int value = patient.get(column); ;
            double value2 = 0;
            if (column == 1)
            { 
               
                if (value < 30)//Young
                {
                    value = 0;
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

            if (!Patient.isCategoric(column))
            {
                if (column == 4)
                {
                    value2 = splitBloodPressure;
                }
                else if (column == 5)
                {
                    value2 = splitCholesterol;
                }
                else if (column == 9)
                {
                    value2 = splitHeartRate;
                }
                if (value < value2)
                {
                    value = 0;
                }
                else
                {
                    value = 1;
                }
            }
            return childrenNode[value].output(patient);
        }

        public double testing(List<Patient> patients)
        {
            double total = 0;
            double correct = 0;
            int test = 0;
            foreach (Patient patient in patients)
            {
                total++;
                int? value = output(patient);
                if (value == patient.result)
                {
                    correct++;
                }
                if (value == 0)
                {
                    test++;
                }
            }
            return correct / total;
        }

        public List<Patient> solve(List<Patient> patients)
        {
            foreach (Patient patient in patients)
            {
                int? output = this.output(patient);
                patient.result = output;
            }
            return patients;
        }
    }
}
