using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Analysis;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace HeartAttackApp.Model
{
    public class Hospital
    {
        public List<Patient> patients { get;private set; }
        private List<Patient>[] allTrainings { get; set; }
        private List<Patient> trainingSet { get; set; }
        private List<Patient> testingSet { get; set; }
        private List<Patient> trainingSets { get; set; }
        private C45Learning c45Learning { get; set; }

        public double loadExperiment { get; private set; }
        public double accuracyDecision { get; private set; }
        public double accuracyC45lib { get;private set; }
        private double accuracyDecisionExperiment { get; set; }
        private double accuracyC45libExperiment { get; set; }
        public double timeLeft { get; private set; }
        private Accord.MachineLearning.DecisionTrees.DecisionTree decisionTreeLib { get; set; }
        public int advance;
        private DecisionTree decision { get; set; }
        public Hashtable Cuadro1 { get; private set; }
        public Hashtable Cuadro2 { get; private set; }
        public Hashtable Cuadro3 { get; private set; }
        public Hashtable Cuadro4 { get; private set; }
        public Hashtable Cuadro5 { get; private set; }
        public PictureBox ptbDecision;
        public PictureBox ptbC45Learning;
        private Visualization visualizationDecision { get; set; }
        private Visualization visualizationC45Learning { get; set; }
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
            allTrainings = new List<Patient>[5];
            trainingSets = new List<Patient>();
            for(int s = 0; s < 5; s++)
            {
                allTrainings[s] = new List<Patient>();
            }
            //A seed is used so that the algorithm is deterministic.
            Random rnd = new Random(4);
           
            string path = @"../../../../Dataset/Datasets/";
            var reader = new StreamReader(File.OpenRead(path + "DataSetHeartAtack.csv"));
            string line = reader.ReadLine();
            line = reader.ReadLine();
            int i = 1;
            while (!string.IsNullOrEmpty(line))
            {
                string[] array = line.Split(';');
                int idPatient = i;
                int year = int.Parse(array[0]);
                int genre = int.Parse(array[1]);
                int typePain = int.Parse(array[2]);
                int bloodPressure = int.Parse(array[3]);
                int cholesterol = int.Parse(array[4]);
                int levelSugar = int.Parse(array[5]);
                int resultElectro = int.Parse(array[6]);
                int heartRate = int.Parse(array[7]);
                int angina = int.Parse(array[8]);
                int result = int.Parse(array[9]);

                Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                int position = rnd.Next(5);
                bool gainPosition = false;
                while (!gainPosition)
                {
                    if(allTrainings[position%5].Count < 60 + (position % 2))
                    {
                        allTrainings[position%5].Add(all);
                        gainPosition = true;
                    }
                    else
                    {
                        position++;
                    }
                }
                trainingSets.Add(all);
                line = reader.ReadLine();
                i++;
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
            c45Learning = new C45Learning()
            {
                Join = 2,
                MaxHeight = 5
            };
            files();
            advance = 0;
            Thread threadDecision = new Thread(new ThreadStart(crossValidationDecision));
            Thread threadC45 = new Thread(new ThreadStart(trainingC45lib));
            threadDecision.Start();
            threadC45.Start();
            threadDecision.Join();
            threadC45.Join();
        }
        private void training(int limit)
        {
            trainingSet = new List<Patient>();
            testingSet = new List<Patient>();
            files(limit);
            advance = 0;
            Thread threadDecision = new Thread(new ThreadStart(crossValidationDecisionExperiment));
            Thread threadC45 = new Thread(new ThreadStart(trainingC45libExperiment));
            threadDecision.Start();
            threadC45.Start();
            threadDecision.Join();
            threadC45.Join();
        }
        private void files(int limit)
        {
            allTrainings = new List<Patient>[5];
            trainingSets = new List<Patient>();
            for (int s = 0; s < 5; s++)
            {
                allTrainings[s] = new List<Patient>();
            }
            Random rnd = new Random();
            string path = @"../../../../Dataset/Datasets/";
            var reader = new StreamReader(File.OpenRead(path + "DataSetHeartAtack.csv"));
            string line = reader.ReadLine();
            line = reader.ReadLine();
            int i = 1;
            while (!string.IsNullOrEmpty(line) && i<= limit)
            {
                string[] array = line.Split(';');
                int idPatient = i;
                int year = int.Parse(array[0]);
                int genre = int.Parse(array[1]);
                int typePain = int.Parse(array[2]);
                int bloodPressure = int.Parse(array[3]);
                int cholesterol = int.Parse(array[4]);
                int levelSugar = int.Parse(array[5]);
                int resultElectro = int.Parse(array[6]);
                int heartRate = int.Parse(array[7]);
                int angina = int.Parse(array[8]);
                int result = int.Parse(array[9]);

                Patient all = new Patient(idPatient, year, genre, typePain, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate, result);
                int position = rnd.Next(5);
                bool gainPosition = false;
                while (!gainPosition)
                {
                    if (allTrainings[position % 5].Count < limit/5)
                    {
                        allTrainings[position % 5].Add(all);
                        gainPosition = true;
                    }
                    else
                    {
                        position++;
                    }
                }
                trainingSets.Add(all);
                line = reader.ReadLine();
                i++;
            }
        }
        private void trainingC45lib()
        {
            Accord.Math.Random.Generator.Seed = 0;
            c45Learning = new C45Learning()
            {
                Join = 2,
                MaxHeight = 5
            };
            int size = trainingSets.Count;
            double[][] inputs1 = new double[size][];
            int[] outputs1 = new int[size];
            int i = 0;
            foreach (Patient patient in trainingSets)
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

            var crossValidation = CrossValidation.Create(

                k: 5,

                learner: (p) => new C45Learning()
                {
                    Join = 2,
                    MaxHeight = 5
                },
                loss: (actual, expected, p) => new ZeroOneLoss(expected).Loss(actual),

                fit: (teacher,x,y,w) => teacher.Learn(x,y,w),

                x: inputs1,y:outputs1
            );
            decisionTreeLib = c45Learning.Learn(inputs1, outputs1);
            var result = crossValidation.Learn(inputs1, outputs1);

            GeneralConfusionMatrix gcm = result.ToConfusionMatrix(inputs1, outputs1);
            accuracyC45lib = Math.Round(gcm.Accuracy,3);
        }
        private void trainingC45libExperiment()
        {
            Accord.Math.Random.Generator.Seed = 0;
            int size = trainingSets.Count;
            double[][] inputs1 = new double[size][];
            int[] outputs1 = new int[size];
            int i = 0;
            foreach (Patient patient in trainingSets)
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

            var crossValidation = CrossValidation.Create(

                k: 5,

                learner: (p) => new C45Learning()
                {
                    Join = 2,
                    MaxHeight = 5
                },
                loss: (actual, expected, p) => new ZeroOneLoss(expected).Loss(actual),

                fit: (teacher, x, y, w) => teacher.Learn(x, y, w),

                x: inputs1, y: outputs1
            );
            var result = crossValidation.Learn(inputs1, outputs1);

            GeneralConfusionMatrix gcm = result.ToConfusionMatrix(inputs1, outputs1);
            accuracyC45libExperiment = Math.Round(gcm.Accuracy, 2);
        }
        private double trainingDecision(DecisionTree decision)
        {
            double best = 0;
            int index = 8;
            
            for (int i = 2; i <= 9; i++)
            {
                decision.depthLimit = i;
                decision.training(trainingSet);
                double aux = Math.Round(decision.testing(testingSet), 2);
                if (aux > best)
                {
                    best = aux;
                    index = i;
                }
                advance++;
            }
            decision.depthLimit = index;
            decision.training(trainingSet);
            double result = Math.Round(decision.testing(testingSet), 2);
            advance++;
            return result;
        }
        private void crossValidationDecision()
        {
            double allAccuracyDecision = 0;
            for (int i = 0; i < 5; i++)
            {
                trainingSet = new List<Patient>();
                testingSet = new List<Patient>();
                for (int j = 0; j < 5; j++)
                {
                    advance++;
                    if (i != j)
                    {
                        trainingSet.AddRange(allTrainings[j]);
                    }
                    else
                    {
                        testingSet.AddRange(allTrainings[j]);
                    }
                }
                decision = new DecisionTree();
                allAccuracyDecision += trainingDecision(decision); 
            }
            accuracyDecision = allAccuracyDecision / 5;
        }
        private void crossValidationDecisionExperiment()
        {
            double allAccuracyDecision = 0;
            for (int i = 0; i < 5; i++)
            {
                trainingSet = new List<Patient>();
                testingSet = new List<Patient>();
                for (int j = 0; j < 5; j++)
                {
                    advance++;
                    if (i != j)
                    {
                        trainingSet.AddRange(allTrainings[j]);
                    }
                    else
                    {
                        testingSet.AddRange(allTrainings[j]);
                    }
                }

                allAccuracyDecision += trainingDecision(new DecisionTree());
            }
            accuracyDecisionExperiment = allAccuracyDecision / 5;
        }
        public void resolve(int selected)
        {
            if (selected == 0)
            {
                decision.solve(patients);
            }else if(selected == 1)
            {
                foreach (Patient patient in patients)
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
                    patient.result=decisionTreeLib.Decide(aux);
                }
            }
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
                currentNode.parent.value = int.Parse(aux[0])+1;
                int column = int.Parse(aux[0])+1;
                if (column == 1)
                {
                    string comparator = Math.Floor(double.Parse(aux[2])) == 0 ? "30" : "60";
                    currentNode.message = Patient.getNamesColums(column) + " " + aux[1] + " " + comparator;
                }else if (column == 2)
                {
                    string comparator = aux[1].Contains(">") ? "M" : "F";
                    currentNode.message = Patient.getNamesColums(column) + " " + comparator;
                }else if(column == 8)
                {
                    currentNode.message =  "Value " + aux[1] + " " + Math.Floor(double.Parse(aux[2]));
                }else if (column == 6)
                {
                    string comparator = "120 mg/dl";
                    currentNode.message = Patient.getNamesColums(column) + " " + aux[1] + " " + comparator;
                }
                else
                {
                    currentNode.message = Patient.getNamesColums(column) + " " + aux[1] + " " + Math.Floor(double.Parse(aux[2]));
                }
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
        public string[] valuesB()
        {
            return trainingSet.ElementAt(0).binariValue();
        }
        public string[] valuesN()
        {
            return trainingSet.ElementAt(0).numericValues();
        }
        public string[] valuesC()
        {
            return trainingSet.ElementAt(0).cadenaValues();
        }
        public string[][] generateResultExperiment(int ammout)
        {
            string[][] result = new string[ammout+1][];
            string[] aux = new string[6];
            int total = ammout * 3;
            Stopwatch sw = new Stopwatch();
            timeLeft = double.MaxValue;
            sw.Start();
            //double time = sw.ElapsedMilliseconds;
            for (int i = 0; i < 6; i++)
            {
                aux[i] = "Tratamiento #"+(i+1);
            }
            result[0] = aux;
            int current = 1;
            for ( int i = 1; i <= ammout; i++)
            {
                aux = new string[6];
                for (int j = 0; j< 3; j++)
                {
                    training((j + 1) * 100);
                    
                    aux[j] = accuracyDecisionExperiment+ "" ;
                    aux[j + 3] = accuracyC45libExperiment + "";
                    current++;
                }
                //time = sw.ElapsedMilliseconds;
                calculateTime(i, ammout);
                result[i] = aux;
            }
            sw.Stop();
            return result;
        }
    
        private void calculateTime(double current,double total)
        {
            loadExperiment = current/total;
        }
    }
}