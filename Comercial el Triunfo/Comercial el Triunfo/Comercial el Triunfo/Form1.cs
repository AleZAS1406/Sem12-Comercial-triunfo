using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Comercial_el_Triunfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblprecio_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Interfaz Por Ervin Perez");
            Application.Exit();
        }

        private void GrupoDescuento_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtSubtotaal_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //ESTE ES PARA EL SUBTOTAL EN LA FACTURA

            int precio = int.Parse(TxtPrecio.Text);
            int Cantidad = int.Parse(TxtCantidad.Text);
            int subtotal;
            subtotal = precio * Cantidad;
            TxtSubtotaal.Text = subtotal.ToString();
            // Variable para almacenar el porcentaje de descuento
            double porcentajeDescuento = 0;

            // Verificar cuál botón de radio está seleccionado y asignar el porcentaje correspondiente
            if (rbtncero.Checked) // 0% de descuento
            {
                porcentajeDescuento = 0;
            }
            else if (rbtn1.Checked) // 1% de descuento
            {
                porcentajeDescuento = 1;
            }
            else if (rbtn5.Checked) // 5% de descuento
            {
                porcentajeDescuento = 5;
            }
            else if (rbtn10.Checked) // 10% de descuento
            {
                porcentajeDescuento = 10;
            }
            else if (rbtn15.Checked) // 15% de descuento
            {
                porcentajeDescuento = 15;
            }

            // Mostrar el porcentaje de descuento en el TextBox TxtDescuento
            TxtDescuento.Text=porcentajeDescuento.ToString();
            
            //IVA DE EL 0.15%
            double IVA;
            IVA =subtotal * 0.15;
            TxtIVA.Text= IVA.ToString();

            //Total con IVA
            double totalconiva;
            totalconiva = (subtotal + IVA);
            //Monto descontado
            double montodescuento = totalconiva * (porcentajeDescuento / 100);
            //Total
            double totalfinal = totalconiva -montodescuento;
                TxtTotañ.Text= totalfinal.ToString();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos Leidos Correctamente");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            TxtIVA.Clear();
            TxtCantidad.Clear();
            TxtCodProd.Clear();
            TxtDescuento.Clear();
            Txtname.Clear();
            TxtPrecio.Clear();
            TxtSubtotaal.Clear();
            TxtTotañ.Clear();
            TxtCodProd.Focus();
        }

        private void TxtTotañ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
