using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionDeProducto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoProducto;
            string textoDescuento;

            textoProducto = txtproducto.Text;
            textoDescuento = txtdescuento.Text;


            calcularValor(Double.Parse(textoProducto), Double.Parse(textoDescuento));
            

        }

        private void calcularValor(double producto, double descuento)
        {
            double precioFinal;
            precioFinal = producto - (producto * (descuento/100));
            MessageBox.Show($"El valor Final del producto es: {precioFinal}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
