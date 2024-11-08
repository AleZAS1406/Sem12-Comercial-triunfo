using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial_El_triunfo_Bonificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTN1_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(TXT1.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado.","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(!decimal.TryParse(TXT2.Text, out decimal salarioBasico) || salarioBasico < 0)
            {
                MessageBox.Show("Por favor ingrese un salario valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Calculo de bonificación decimal
           decimal porcentajeBonificacion= 0m;
            if (RDBTN1.Checked)
            {
                porcentajeBonificacion = 0.10m;
            }
            else if (RDBTN2.Checked)
            {
                porcentajeBonificacion = 0.15m;
            }
            else if (RDBTN3.Checked)
            {
                porcentajeBonificacion = 0.20m;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un porcentaje de bonificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal bonificacion = salarioBasico * porcentajeBonificacion;

            //calculo de retencion
            decimal retencion = salarioBasico >= 10000 ? salarioBasico * 0.05m : 0m;

            //Calculo del total a recibir
            decimal totalRecibir = salarioBasico + bonificacion - retencion;

            //Mostrar resultados
            TXT3.Text = bonificacion.ToString("C");
            TXT4.Text = retencion.ToString("C");
            TXT5.Text = totalRecibir.ToString("C");


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            TXT1.Clear();
            TXT2.Clear();
            TXT3.Clear();
            TXT4.Clear();
            TXT5.Clear();
            RDBTN1.Checked = false;
            RDBTN2.Checked = false;
            RDBTN3.Checked = false;
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios!");
            Application.Exit();
        }
    }
}
