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
                    int id =(Math.Abs(int.Parse(txt_ID.Text)) > 303 )? Math.Abs(int.Parse(txt_ID.Text)): int.Parse("Value is not valid ") ;
                    
                 
                 
                    int age =( Math.Abs(int.Parse(txt_age.Text))<= 99) ? Math.Abs(int.Parse(txt_age.Text)) : int.Parse("Value is not valid "); ;
                    
               
                  

                    int sex = cb_sex.SelectedIndex;
                    int typePain = cb_painType.SelectedIndex;
                     // presion arterial < 250
                    int bloodPressure = (Math.Abs(int.Parse(txt_bloodPressure.Text)) <= 250) ? Math.Abs(int.Parse(txt_bloodPressure.Text)) : int.Parse("Value is not valid ");


                    int cholesterol = (Math.Abs(int.Parse(txt_colesterol.Text))<=600) ? Math.Abs(int.Parse(txt_colesterol.Text)) : int.Parse("Value is not valid ") ; ;
                   
                   
                    int bloodSugar = cb_bloodSugar.SelectedIndex;
                    int electro = cbResultElectro.SelectedIndex;

                    int heartRate =( Math.Abs(int.Parse(txt_maxHeart.Text))<= 280) ? Math.Abs(int.Parse(txt_maxHeart.Text)) : int.Parse("Value is not valid "); ;
                   
                    
                   
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Add_pane_Load(object sender, EventArgs e)
        {

        }
    }
}
