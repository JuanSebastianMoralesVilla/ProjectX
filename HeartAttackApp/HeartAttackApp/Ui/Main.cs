using HeartAttackApp.HeavyTask;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HeartAttackApp.Ui
{
    public partial class Main : Form
    {
        private ControllerGUI controller;
        public bool stop;
        private VisualizationForm visualizationPane;
        private HeavyTasks heavy;
        public Main()
        {
            stop = false;
            InitializeComponent();
            HeavyTasks heavy = new HeavyTasks(this);
            heavy.CallbackExcel += CallbackLoadExcel;
            heavy.CallbackTraining += CallbackActualiceProgess;
            heavy.CallbackExperiment += CallbackLoadExperiment;
            this.heavy = heavy;
            visualizationPane = new VisualizationForm();
            controller = new ControllerGUI(visualizationPane.getPtbDecision(),visualizationPane.getPtbC45());
            startApp1.initialize(this);
            filterOptions1.inicialize(controller, gridPatients1);
            gridPatients1.initialize(controller, this, buttonsOptions1, filterOptions1, heavy);
            buttonsOptions1.inicialize(controller, gridPatients1, filterOptions1);
            visualizationPane.initialize(controller);
        }
        
        public void training()
        {
            Thread t = new Thread(new ThreadStart(controller.training));
            t.Start();
        }

        private void CallbackActualiceProgess(object sender, HeavyTaskResponse response)
        {
            int advance = controller.miHospital.advance;
            startApp1.loading(advance);
            if (advance == 70)
            {
                stop = true;
                loadMain();
                filterOptions1.setAccuracy();
            }
        }
        public void loadMain()
        {
            startApp1.Visible = false;
            showCharts1.Visible = false;
            gridPatients1.Visible = true;
            filterOptions1.Visible = true;
            buttonsOptions1.Visible = true;
        }
        public void loadCharts()
        {
            startApp1.Visible = false;
            showCharts1.Visible = true;
            gridPatients1.Visible = false;
            filterOptions1.Visible = false;
            buttonsOptions1.Visible = false;
            showCharts1.initialize(controller.RetrieveCuadro1(), controller.RetrieveCuadro2(), controller.RetrieveCuadro3(), controller.RetrieveCuadro4(), controller.RetrieveCuadro5(),this);
        }
        public void loadStart()
        {
            startApp1.Visible = true;
            showCharts1.Visible = false;
            gridPatients1.Visible = false;
            filterOptions1.Visible = false;
            buttonsOptions1.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            heavy.Start(0);
            training();
        }

        private void CallbackLoadExcel(object sender, HeavyTaskResponse response)
        {
            filterOptions1.eneableAll(false);
            gridPatients1.enableAll(false);
            buttonsOptions1.enableButtons(false);
            if (gridPatients1.exported)
            {
                filterOptions1.eneableAll(true);
                gridPatients1.enableAll(true);
                buttonsOptions1.enableButtons(true);
                gridPatients1.exported = false;
                stop = true;
            }
        }

        private void CallbackLoadExperiment(object sender, HeavyTaskResponse response)
        {
            double load = controller.miHospital.loadExperiment;
            gridPatients1.setLoad(load);
            if (load == 1)
            {
                stop = true;
            }
        }
        public void ourTree(bool our)
        {
            if (our)
            {
                visualizationPane.getPtbC45().Visible = false;
                visualizationPane.getPtbDecision().Visible = true;
            }
            else
            {
                visualizationPane.getPtbC45().Visible = true;
                visualizationPane.getPtbDecision().Visible = false;
            }

            visualizationPane.ShowDialog();
        }
    }
}
