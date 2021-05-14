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
        public Add_pane(ControllerGUI controller, GridPatients grid)
        {
            InitializeComponent();
            this.controller = controller;
            this.grid = grid;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE TO ADD A PATIENT?","Confirm add patient", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txt_ID.Text);
                    int age = int.Parse(txt_age.Text);
                    int sex = cb_sex.SelectedIndex;
                    int typePain = cb_painType.SelectedIndex;
                    int bloodPressure = int.Parse(txt_bloodPressure.Text);
                    int cholesterol = int.Parse(txt_colesterol.Text);
                    int bloodSugar = cb_bloodSugar.SelectedIndex;
                    int electro = int.Parse(txt_electroCardio.Text);
                    int heartRate = int.Parse(txt_maxHeart.Text);
                    int angina = cb_angina.SelectedIndex;
                    this.controller.add(id,age, sex, typePain, bloodPressure,cholesterol,bloodSugar,angina,electro,heartRate);
                    List<Patient> patients = this.controller.patient();
                    grid.loadGrid(patients);
                    this.Close();
                }catch(NullReferenceException t)
                {
                    MessageBox.Show("Some values are Empty", " Values Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException t)
                {
                    MessageBox.Show("Some values are not valid", "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
