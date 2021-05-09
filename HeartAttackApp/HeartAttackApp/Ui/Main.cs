using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartAttackApp.Ui
{
    public partial class Main : Form
    {
        private ControllerGUI controller;
        public Main()
        {
            InitializeComponent();
            controller = new ControllerGUI();
            gridPatients1.initialize(controller,this);
            filterOptions1.inicialize(controller, gridPatients1);
            buttonsOptions1.inicialize(controller, gridPatients1, filterOptions1);
            loadMain();
        }

        public void training()
        {
            controller.training();
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
    }
}
