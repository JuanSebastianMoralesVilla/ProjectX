﻿using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HeartAttackApp.Model
{
    public class Hospital
    {
        public List<Patient> patients { get;private set; }
        private List<Patient> trainingSet { get; set; }

        private C45Learning c45Learning;   

        public double accuracyDecision;
        public double accuracyC45lib;

        public int advance;
        private DecisionTree decision { get; set; }
        private List<Patient> testingSet { get; set; }
        public Hashtable Cuadro1 { get; private set; }
        public Hashtable Cuadro2 { get; private set; }
        public Hashtable Cuadro3 { get; private set; }
        public Hashtable Cuadro4 { get; private set; }
        public Hashtable Cuadro5 { get; private set; }

        public PictureBox ptbDecision;
        public PictureBox ptbC45Learning;

        private Visualization visualizationDecision;
        private Visualization visualizationC45Learning;
        public Hospital(PictureBox ptbDecision, PictureBox ptbC45Learning)
        {
            this.ptbDecision = ptbDecision;
            this.ptbC45Learning = ptbC45Learning;
            visualizationDecision = new Visualization(ptbDecision);
            visualizationC45Learning = new Visualization(ptbC45Learning);
            patients = new List<Patient>();
            Cuadro1 = new Hashtable();
            Cuadro2 = new Hashtable();
            Cuadro3 = new Hashtable();
            Cuadro4 = new Hashtable();
            Cuadro5 = new Hashtable();
        }

        public void add(int idPatient, int age, int genre, int typePain, int bloodPressure, int cholesterol, int levelSugar, int angina, int resultElectro, int heartRate, int? result)
        {
            Patient patient = null;
            for (int i = 0; i < patients.Count; i++)
            {
                if (patients.ElementAt(i).id == idPatient)
                {
                    patient = patients.ElementAt(i);
                    break;
                }
            }
            if (patient == null)
            {
                patient = new Patient(idPatient, age, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate);
                patients.Add(patient);
                AddRecordToHashTables(patient);
            }
            
        }

        public void clear()
        {
            patients.Clear();
            clearGrahpics();
        }

        public void clearGrahpics()
        {
            Cuadro1.Clear();
            Cuadro2.Clear();
            Cuadro3.Clear();
            Cuadro4.Clear();
            Cuadro5.Clear();
        }

        public List<Patient> classify()
        {
            clearGrahpics();
            List<Patient> result = new List<Patient>();
            foreach (Patient patient in patients)
            {
                AddRecordToHashTables(patient);
            }
            result = patients;
            return result;
        }
        public List<Patient> classify(int id)
        {
            clearGrahpics();
            List<Patient> result = new List<Patient>();
            foreach (Patient patient in patients)
            {
                if (patient.id.Equals(id))
                {
                    result.Add(patient);
                    AddRecordToHashTables(patient);
                    break;
                }
            }

            return result;
        }

        public List<Patient> classify(string type, int lower, int higger)
        {
            clearGrahpics();
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
                    
                    AddRecordToHashTables(patient);
                    result.Add(patient);
                }
            }

            return result;
        }

        public List<Patient> classify(string type, int value)
        {
            clearGrahpics();
            List<Patient> result = new List<Patient>();
            int aux = 0;
            foreach (Patient patient in patients)
            {
                switch (type)
                {
                    case Patient.SEX:
                        aux = patient.sex=="F"?0:1;
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
                    AddRecordToHashTables(patient);
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
            if (Pat.sex.Equals("F"))
            {
                x = "Female";
            }
            else
            {
                x = "Male";
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
            }
            else
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
            if (angi != "")
            {

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
                Cuadro5[colesterol] = ((int)Cuadro5[colesterol] + 1);
            }
            else
            {
                Cuadro5.Add(colesterol, 1);
            }
        }

        public List<string[]> Cuadro1Conversor()
        {
            List<string[]> datos = new List<string[]>();
            foreach (DictionaryEntry i in Cuadro1)
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
            reader = new System.IO.StreamReader(File.OpenRead(path + "DataSetValidFull.csv"));
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

                Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                testingSet.Add(all);
                line = reader.ReadLine();
            }
        }

        public void visualize()
        {
            decision.createTree(visualizationDecision);
            visualizationDecision.visualize();
            visualizationC45Learning.insert(DecisionNodeToNodeClass(c45Learning.Model.Root));
            visualizationC45Learning.visualize();
        }

        public void training()
        {
            trainingSet = new List<Patient>();
            testingSet = new List<Patient>();
            trainingDecision();
            trainingC45lib();
        }

        private void trainingC45lib()
        {
            c45Learning = new C45Learning()
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
                        aux[j - 1] = patient.get(j) < 30 ? 0 : patient.get(j) < 60 ? 1 : 2;
                    }
                    else aux[j - 1] = patient.get(j);
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

            int[] predicted = tree.Decide(inputs2);

            double error = new ZeroOneLoss(outputs2).Loss(predicted);
            accuracyC45lib = Math.Round(1 - error, 2) * 100;
            Console.WriteLine(accuracyC45lib);
        }

        private void trainingDecision()
        {
            decision = new DecisionTree();
            files();
            advance = 1;
            double best = 0;
            int index = 0;
            for (int i = 2; i <= 9; i++)
            {
                decision.depthLimit = i;
                decision.training(trainingSet);
                double result = Math.Round(decision.testing(testingSet), 2);
                if (result > best)
                {
                    best = result;
                    index = i;
                }
                advance = i;
                Console.WriteLine("# " + i + " " + result);
            }
            decision.depthLimit = index;
            decision.training(trainingSet);
            advance = 10;
            accuracyDecision = best;
        }
        public void resolve()
        {
            decision.solve(patients);
        }

        public Node DecisionNodeToNodeClass(DecisionNode root)
        {
            Node result = new Node();
            DecisionNodeToNodeClass(root, result);
            return result;
        }

        private void  DecisionNodeToNodeClass(DecisionNode decisionNode, Node currentNode)
        {
           
            if (!decisionNode.IsRoot)
            {
                string comparation = decisionNode.ToString();
                string[] aux = comparation.Split(' ');
                currentNode.parent.value = int.Parse(aux[0]);
                currentNode.message = Patient.getNamesColums(int.Parse(aux[0])) + " " + aux[1] + " " + aux[2];

            }
            else
            {
                currentNode.height = 1;
            }
            currentNode.answer = decisionNode.Output;
            currentNode.nodes = new Node[decisionNode.Branches.Count];
            int distX = 2 * Visualization.SIZE + 10 * currentNode.nodes.Length;
            currentNode.distX = distX;
            int i = 0;
            foreach(DecisionNode childNode in decisionNode.Branches)
            {
                Node newNode = new Node();
                currentNode.nodes[i] = newNode;
                newNode.parent = currentNode;
                newNode.height = newNode.parent.height + 1;
                newNode.posY = newNode.parent.posY + Visualization.DIST_Y;
                DecisionNodeToNodeClass(childNode, newNode);
                i++;
            }
            if (decisionNode.IsLeaf)
            {
                currentNode.value = null;
                currentNode.answer = currentNode.answer == null ? -1 : currentNode.answer;
            }
        }
    }
}
