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
    public partial class Show_Chart : Form
    {
        public Show_Chart(List<string[]> info1, List<string[]> info2, List<string[]> info3, List<string[]> info4, List<string[]> info5)
        {
            InitializeComponent();

            chart1.Titles.Add("Amount of mans and womans that have a hight risk to get a heart attack");
            chart2.Titles.Add("patients that have an angina vs patients that not");
            chart3.Titles.Add("diferents ranges of ages");
            chart4.Titles.Add("patients clasified by their type of pain");
            chart5.Titles.Add("cholesterol levels ranges of the patientes");

            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart2.Series["s2"].IsValueShownAsLabel = true;
            chart3.Series["s3"].IsValueShownAsLabel = true;
            chart2.Series["s4"].IsValueShownAsLabel = true;
            chart3.Series["s5"].IsValueShownAsLabel = true;

            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart2.ChartAreas["ChartArea2"].AxisX.Interval = 1;
            chart3.ChartAreas["ChartArea3"].AxisX.Interval = 1;
            chart4.ChartAreas["ChartArea4"].AxisX.Interval = 1;
            chart5.ChartAreas["ChartArea5"].AxisX.Interval = 1;

            C1(info1);
            C2(info2);
            C3(info3);
            C4(info4);
            C5(info5);
        }

        private void C1(List<string[]> info1)
        {
            foreach (string[] i in info1)
            {
                chart1.Series["s1"].Points.AddXY(i[0], i[1]);
            }
        }

        private void C2(List<string[]> info2)
        {
            foreach (string[] i in info2)
            {
                chart2.Series["s2"].Points.AddXY(i[0], i[1]);
            }
        }

        private void C3(List<string[]> info3)
        {
            foreach (string[] i in info3)
            {
                chart3.Series["s3"].Points.AddXY(i[0], i[1]);
            }
        }

        private void C4(List<string[]> info4)
        {
            foreach (string[] i in info4)
            {
                chart4.Series["s4"].Points.AddXY(i[0], i[1]);
            }
        }

        private void C5(List<string[]> info5)
        {
            foreach (string[] i in info5)
            {
                chart5.Series["s5"].Points.AddXY(i[0], i[1]);
            }
        }


    }
}
