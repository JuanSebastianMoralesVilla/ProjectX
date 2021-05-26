using HeartAttackApp.Model;
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
    public partial class Add_pane : Form
    {
        ControllerGUI controller;
        GridPatients grid;
        ButtonsOptions btopt;
        

        private int id;
        
        public Add_pane(ControllerGUI controller, GridPatients grid,ButtonsOptions btopt)
        {
            InitializeComponent();
            this.controller = controller;
            this.btopt = btopt;
            this.grid = grid;
            id = 304;
        }

        private void clear()
        {
            txt_age.Clear();
            cb_sex.SelectedIndex = -1;
            cb_painType.SelectedIndex = -1;
            txt_bloodPressure.Clear();
            txt_colesterol.Clear();
            cb_bloodSugar.SelectedIndex = -1;
            cb_electroResults.SelectedIndex = -1;
            txt_maxHeart.Clear();
            cb_angina.SelectedIndex = -1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                int age = int.Parse(txt_age.Text);
                int sex = cb_sex.SelectedIndex;
                int typePain = cb_painType.SelectedIndex;
                int bloodPressure = int.Parse(txt_bloodPressure.Text);
                int cholesterol = int.Parse(txt_colesterol.Text);
                int bloodSugar = cb_bloodSugar.SelectedIndex;
                int electro = cb_electroResults.SelectedIndex;
                int heartRate = int.Parse(txt_maxHeart.Text);
                int angina = cb_angina.SelectedIndex;

                if (age < 18 || age >= 130 || bloodPressure <= 30 || bloodPressure >= 260 || cholesterol <= 30 || cholesterol >= 700 || heartRate <= 60 || heartRate >= 280 ||
                    sex == -1 || typePain == -1 || bloodSugar == -1|| electro== -1 || angina == -1)
                {
                    throw new FormatException();
                }
                /*
                age = Math.Abs(age);
                bloodPressure = Math.Abs(bloodPressure);
                cholesterol = Math.Abs(cholesterol);
                electro = Math.Abs(electro);
                heartRate = Math.Abs(heartRate);

                txt_age.Text = age + "";
                txt_bloodPressure.Text = bloodPressure + "";
                txt_colesterol.Text = cholesterol + "";
                txt_electroCardio.Text = electro + "";
                txt_maxHeart.Text = heartRate + "";
                */
                
                DialogResult result = MessageBox.Show("ARE YOU SURE YOU WANT TO ADD THAT PATIENT?", "Confirm add patient", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    controller.add(id, age, sex, typePain, bloodPressure, cholesterol, bloodSugar, angina, electro, heartRate);
                    List<Patient> patients = controller.patient();
                    grid.loadGrid(patients);
                    id++;
                    clear();
                    grid.enableExport();
                    ButtonsOptions.enableButtons();

                    this.Close();
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Some values are Empty", " Values Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Some values are not valid", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Add_pane_Load(object sender, EventArgs e)
        {
            txt_ID.Text = id+ "";
        }

        public void SetId(int n)
        {
            id = n;
        }


       

    }
}
