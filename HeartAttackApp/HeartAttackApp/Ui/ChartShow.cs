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
    public partial class ChartShow : Form
    {
        public ChartShow()
        {
            InitializeComponent();

            chart1.Titles.Add("Temperatura promedio por municipio");
            chart2.Titles.Add("Cantidad de registros por zona hidrografica");
            chart3.Titles.Add("Cantidad de registros de temperatura por municipio");
            chart1.Series["Temperatura promedio"].IsValueShownAsLabel = true;
            chart2.Series["pie"].IsValueShownAsLabel = true;
            chart3.Series["barras"].IsValueShownAsLabel = true;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart3.ChartAreas["ChartArea1"].AxisX.Interval = 1;
        }
    }
}
