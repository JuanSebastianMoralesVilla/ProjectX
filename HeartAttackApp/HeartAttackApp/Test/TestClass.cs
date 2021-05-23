using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.DecisionTrees.Rules;
using Accord.Math.Optimization.Losses;
using HeartAttackApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HeartAttackApp.Test
{
    public class TestClass
    {
        public List<Patient> trainingSet;
        public List<Patient> testingSet;
        public Model.DecisionTree decision;

        public TestClass()
        {
            testingSet = new List<Patient>();
            trainingSet = new List<Patient>();
            decision = new Model.DecisionTree();
            files();
            /*
            for(int i = 2;i<=9;i++)
            {
                decision.depthLimit = i;
                train();
                double result = Math.Round(test(),2);
                Console.WriteLine("# "+i+" " + result);
            }*/
            trainingC45lib();
        }
        private void trainingC45lib()
        {
            C45Learning c45Learning = new C45Learning()
                {
                new DecisionVariable("1", 3),
                new DecisionVariable("2", 2),
                new DecisionVariable("3", 4),
                new DecisionVariable("4", DecisionVariableKind.Continuous),
                new DecisionVariable("5", DecisionVariableKind.Continuous),
                new DecisionVariable("6", 2),
                new DecisionVariable("7", 2),
                new DecisionVariable("8", 3),
                new DecisionVariable("9", DecisionVariableKind.Continuous),
                };
            double[][] inputs1 = new double[trainingSet.Count][];
            double[][] inputs2 = new double[testingSet.Count][];
            int[] outputs1 = new int[trainingSet.Count];
            int[] outputs2 = new int[testingSet.Count];
            int i = 0;
            foreach (Patient patient in trainingSet)
            {
                double[] aux = new double[9];
                for (int j = 1; j <= 9; j++)
                {
                    if (j == 1)
                    {
                        aux[j-1] = patient.get(j) < 30 ? 0 : patient.get(j) < 60 ? 1 : 2;
                    }
                    else aux[j-1] = patient.get(j);
                }
                inputs1[i] = aux;
                outputs1[i] = patient.get(10);
                i++;
            }
            i = 0;
            foreach (Patient patient in testingSet)
            {
                double[] aux = new double[9];
                for (int j = 1; j <= 9; j++)
                {
                    if (j == 1)
                    {
                        aux[j - 1] = patient.get(j) < 30 ? 0 : patient.get(j) < 60 ? 1 : 2;
                    }
                    else aux[j - 1] = patient.get(j);
                }
                inputs2[i] = aux;
                outputs2[i] = patient.get(10);
                i++;
            }

            var tree = c45Learning.Learn(inputs1, outputs1);
            Console.WriteLine(tree.Root.Value);
            int[] predicted = tree.Decide(inputs2);
            Console.WriteLine(tree.Root.Branches.ElementAt(0).ToString());
            double error = new ZeroOneLoss(outputs2).Loss(predicted);
            Console.WriteLine(Math.Round(1-error,2)*100 + "%");
            //DecisionSet rules = tree.ToRules();
            //string ruleText = rules.ToString();
            //Console.WriteLine(ruleText);
        }
        private void train()
        {
            decision.training(trainingSet);
        }

        private double test()
        {
            return decision.testing(testingSet);
        }

        private void files()
        {
            string path = @"../../../../Dataset/Datasets/";
            var reader = new System.IO.StreamReader(File.OpenRead(path + "DataSetTrainingFull.csv"));
            string line = reader.ReadLine();
            line = reader.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {
                string[] array = line.Split(';');
                int idPatient = int.Parse(array[0]);
                int year = int.Parse(array[1]);
                int genre = int.Parse(array[2]);
                int typePain = int.Parse(array[3]);
                int bloodPressure = int.Parse(array[4]);
                int cholesterol = int.Parse(array[5]);
                int levelSugar = int.Parse(array[6]);
                int resultElectro = int.Parse(array[7]);
                int heartRate = int.Parse(array[8]);
                int angina = int.Parse(array[9]);
                /*
                double oldPeak = double.Parse(array[10]);
                int slp = int.Parse(array[11]);
                int caa = int.Parse(array[12]);
                int thall = int.Parse(array[13]);
                */
                int result = int.Parse(array[10]);

                Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                trainingSet.Add(all);
                line = reader.ReadLine();
            }
            string valid = "DataSetValidFull.csv";
            string test = "DataSetTestingFull.csv";
            reader = new System.IO.StreamReader(File.OpenRead(path + valid));
            line = reader.ReadLine();
            line = reader.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {
                string[] array = line.Split(';');
                int idPatient = int.Parse(array[0]);
                int year = int.Parse(array[1]);
                int genre = int.Parse(array[2]);
                int typePain = int.Parse(array[3]);
                int bloodPressure = int.Parse(array[4]);
                int cholesterol = int.Parse(array[5]);
                int levelSugar = int.Parse(array[6]);
                int resultElectro = int.Parse(array[7]);
                int heartRate = int.Parse(array[8]);
                int angina = int.Parse(array[9]);
                /*
                double oldPeak = double.Parse(array[10]);
                int slp = int.Parse(array[11]);
                int caa = int.Parse(array[12]);
                int thall = int.Parse(array[13]);
                */
                int result = int.Parse(array[10]);

                Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate,  result);
                testingSet.Add(all);
                line = reader.ReadLine();
            }
        }
    }
}
