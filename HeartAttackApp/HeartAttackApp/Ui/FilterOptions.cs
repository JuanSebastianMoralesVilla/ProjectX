﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartAttackApp.Model;

namespace HeartAttackApp.Ui
{
    public partial class FilterOptions : UserControl
    {
        private ControllerGUI controller;
        private GridPatients gridPatients;
        private Visualization visualization;
        public FilterOptions()
        {
            InitializeComponent();
        }

        public void inicialize(ControllerGUI controller, GridPatients gridPatients,Visualization visualization)
        {
            string[] values = controller.matrixE();
            cb_filter.Items.AddRange(values);
            this.controller = controller;
            this.gridPatients = gridPatients;
            this.visualization = visualization;
           
        }
        public void setAccuracy()
        {
            txt_accuracy.Text = controller.miHospital.accuracity * 100 + "%";
        }
        public void cb_filterSetVisible(bool visible)
        {
            cb_filter.Visible = visible;
        }
        public void clear()
        {
            cb_choose.Visible = false;
            txt_to.Visible = false;
            tb_higger.Visible = false;
            tb_lower.Visible = false;
            tb_cadena.Visible = false;
            cb_filter.Visible = false;
            btn_search.Visible = false;
            cb_filter.SelectedIndex = 0;
            cb_choose.Items.Clear();
            tb_cadena.Clear();
            tb_higger.Clear();
            tb_lower.Clear();
            cb_choose.SelectedItem = "";
        }
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            string selected = cb_filter.SelectedItem.ToString();
            string[] valuesC = controller.valuesC();
            string[] valuesN = controller.valuesN();
            string[] valuesB = controller.valuesB();
            List<Patient> patients;
            try
            {
                if (valuesC.Contains(selected))
                {
                    int id = int.Parse(tb_cadena.Text);
                    patients = controller.search(id);
                }
                else if (valuesN.Contains(selected))
                {
                    int lower = Math.Abs(int.Parse(tb_lower.Text));
                    int higger = Math.Abs(int.Parse(tb_higger.Text));
                    if (higger < lower)
                    {
                        int aux = lower;
                        lower = higger;
                        higger = aux;
                    }
                    tb_lower.Text = lower.ToString();
                    tb_higger.Text = higger.ToString();

                    patients = controller.search(selected, lower, higger);
                }
                else if (valuesB.Contains(selected))
                {
                    int value = int.Parse(cb_choose.SelectedItem.ToString());
                    patients = controller.search(selected, value);
                }
                else
                {
                    patients = controller.patient();
                }
                gridPatients.loadGrid(patients);
            }
            catch (FormatException t)
            {
                Console.WriteLine(t.Message);
            }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            string selected = cb_filter.SelectedItem.ToString();
            string[] valuesC = controller.valuesC();
            string[] valuesN = controller.valuesN();
            string[] valuesB = controller.valuesB();
            List<Patient> patients = new List<Patient>();
            try
            {
                if (valuesC.Contains(selected))
                {
                    int id = int.Parse(tb_cadena.Text);
                    patients = controller.search(id);
                }
                else if (valuesN.Contains(selected))
                {
                    int lower = Math.Abs(int.Parse(tb_lower.Text));
                    int higger = Math.Abs(int.Parse(tb_higger.Text));
                    if (higger < lower)
                    {
                        int aux = lower;
                        lower = higger;
                        higger = aux;
                    }
                    tb_lower.Text = lower.ToString();
                    tb_higger.Text = higger.ToString();

                    patients = controller.search(selected, lower, higger);
                }
                else if (cb_choose.SelectedItem!=null && valuesB.Contains(selected))
                {
                    int value = int.Parse(cb_choose.SelectedItem.ToString());
                    patients = controller.search(selected, value);
                }
                else
                {
                    patients = controller.patient();
                }
                gridPatients.loadGrid(patients);
            }
            catch (FormatException t)
            {
                Console.WriteLine(t.Message);
            }
        }

        private void cb_filter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            string selected = cb_filter.SelectedItem.ToString();
            cb_choose.Visible = false;
            txt_to.Visible = false;
            tb_higger.Visible = false;
            tb_lower.Visible = false;
            tb_cadena.Visible = false;
            btn_search.Visible = false;
            cb_choose.SelectedItem ="";
            cb_choose.SelectedIndex = -1;
            cb_choose.Items.Clear();
            tb_cadena.Clear();
            tb_higger.Clear();
            tb_lower.Clear();

            if (!cb_filter.SelectedIndex.Equals(-1))
            {
                string[] valuesC = controller.valuesC();
                string[] valuesN = controller.valuesN();
                string[] valuesB = controller.valuesB();
                if (valuesC.Contains(selected))
                {
                    tb_cadena.Visible = true;
                }
                else if (valuesN.Contains(selected))
                {
                    txt_to.Visible = true;
                    tb_higger.Visible = true;
                    tb_lower.Visible = true;
                }
                else if (valuesB.Contains(selected))
                {
                    cb_choose.Visible = true;
                    string[] bin = { "0", "1" };
                    cb_choose.Items.AddRange(bin);
                    if (selected.Equals(Patient.TYPE_PAIN))
                    {
                        cb_choose.Items.Add("2");
                    }
                }
                btn_search.Visible = true;
            }
        }

        private void btn_showDecisionTree_Click(object sender, EventArgs e)
        {
            visualization.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
