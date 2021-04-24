using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    public class DecisionTree
    {
        private DecisionTree currentNode;
        private DecisionTree[] childrenNode;
        private List<Patient> trainingSet;
        private int column;

        public DecisionTree()
        {
            column = -1;
        }

        public void training(List<Patient> patients)
        {
            this.trainingSet = patients;
            training();
        }
        private void training()
        {
            double mainEntropy = entropy();
            double[] gain = new double[9];
            double max = -1;
            int index = 0;
            for ( int i = 1; i <= 9; i++)
            {
                gain[i-1]= mainEntropy-entropy(i);
                if (max < gain[i - 1])
                {
                    index = i;
                    max = gain[i - 1];
                }
            }
            column = index;


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
            int total = ammountNo + ammountNo;
            
            double result = (ammountYes / (total)) *Math.Log(ammountYes / (total), 2) + (ammountNo / (total))*Math.Log(ammountNo / (total), 2);
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

                }
                else if (column == 5) //
                {

                }
                else if (column == 9)
                {

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
                result+= ((ammountYes[i]+ ammountNo[i])/total)*((ammountYes[i] / (total))*Math.Log(ammountYes[i] / (total), 2) - ((total - ammountYes[i]) / (total))*Math.Log((ammountNo[i] )/ (total), 2));
            }
            
            return result;
        }
    }
}
