using HeartAttackApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartAttackApp.Ui
{
    public partial class Main_pane : Form
    {
        private ControllerGUI c = new ControllerGUI();

        private Add_pane addPane;
        private ControllerGUI controller;
        OpenFileDialog file;
        public Main_pane()
        {
            controller = new ControllerGUI();
            InitializeComponent();
            string[] values = Patient.matrixE();
            cb_filter.Items.AddRange(values);
            file = new OpenFileDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
         
            addPane = new Add_pane();
            addPane.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cb_filter.SelectedItem.ToString(); 
            cb_choose.Visible = false;
            txt_to.Visible = false;
            tb_higger.Visible = false;
            tb_lower.Visible = false;
            tb_cadena.Visible = false;
            cb_choose.Items.Clear();
            if (!cb_filter.SelectedIndex.Equals(0))
            {
                string [] valuesC = Patient.cadenaValues();
                string [] valuesN = Patient.numericValues();
                string [] valuesB = Patient.binariValue();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_pane_Load(object sender, EventArgs e)
        {

        }

        private void grid_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            file.Filter = "CSV|*.csv";
            List<Patient> patients = new List<Patient>();
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBoxLoad1.Text = file.FileName;
                string path = file.FileName;
                textBoxLoad2.Text = file.SafeFileName;
                MessageBox.Show("Datos cargados correctamente.");
                patients = controller.loadGrid(path);
                Console.WriteLine(patients.Count);
                loadGrid(patients);
            }
        }

        private void loadGrid(List<Patient> patients)
        {
            grid_data.DataSource = patients;
            cb_filter.Visible = true;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            grid_data.DataSource = controller.patient();//llamar metodo
            cb_choose.Visible = false;
            txt_to.Visible = false;
            tb_higger.Visible = false;
            tb_lower.Visible = false;
            tb_cadena.Visible = false;
            cb_filter.Visible = false;
            btn_search.Visible = false;
            cb_filter.SelectedIndex=0;
            cb_choose.Items.Clear();
            cb_choose.SelectedItem = "";

        }
        //NO LA TOQUEN
        private void btn_search_Click(object sender, EventArgs e)
        {
            string selected = cb_filter.SelectedItem.ToString();
            string[] valuesC = Patient.cadenaValues();
            string[] valuesN = Patient.numericValues();
            string[] valuesB = Patient.binariValue();
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
                grid_data.DataSource = patients;
            }
            catch (FormatException t)
            {
                Console.WriteLine(t.Message);
            }
        }

        private void btn_graphics_Click(object sender, EventArgs e)
        {
            Show_Chart ch = new Show_Chart(c.RetrieveCuadro1(), c.RetrieveCuadro2(), c.RetrieveCuadro3(), c.RetrieveCuadro4(), c.RetrieveCuadro5());
            ch.Show();
            MessageBox.Show("Se han generado las graficas");
        }
    }
}
