﻿using HeartAttackApp.HeavyTask;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartAttackApp.Ui
{
    public partial class Main : Form
    {
        private ControllerGUI controller;
        public bool stop;
        private Visualization visualizationPane;
        public Main()
        {
            stop = false;
            InitializeComponent();
            visualizationPane = new Visualization();
            controller = new ControllerGUI(visualizationPane.getPtbDecision(),visualizationPane.getPtbC45());
            startApp1.initialize(this);
            gridPatients1.initialize(controller,this);
            filterOptions1.inicialize(controller, gridPatients1,visualizationPane);
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
            if (advance == 10)
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
            HeavyTask.HeavyTask hvtask = new HeavyTask.HeavyTask(this);

            // Puedes crear multiples callbacks o solo uno
            hvtask.Callback += CallbackActualiceProgess;
            hvtask.Start();
            training();
        }

        private void buttonsOptions1_Load(object sender, EventArgs e)
        {

        }
    }
}
