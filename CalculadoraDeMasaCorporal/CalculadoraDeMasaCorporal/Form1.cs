using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDeMasaCorporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            string textoAltura = txtAltura.Text;

            double peso = Double.Parse(textoPeso);
            double altura = Double.Parse(textoAltura);

            double imc = peso / (altura * altura);

            double imcRedondeado = Math.Round(imc, 2);

            MessageBox.Show($"El IMC es: {imcRedondeado}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
