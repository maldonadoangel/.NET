using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesAritmeticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string textoNumero1 = "0", textoNumero2 = "0";
            double numero1, numero2, total = 0;

            textoNumero1 = textBox1.Text;
            textoNumero2 = textBox2.Text;

            numero1 = Double.Parse(textoNumero1);
            numero2 = Double.Parse(textoNumero2);

            total = numero1 + numero2;

            label3.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            string textoNumero1 = "0", textoNumero2 = "0";
            double numero1, numero2, total = 0;

            textoNumero1 = textBox1.Text;
            textoNumero2 = textBox2.Text;

            numero1 = Double.Parse(textoNumero1);
            numero2 = Double.Parse(textoNumero2);

            total = numero1 - numero2;

            label3.Text = total.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            string textoNumero1 = "0", textoNumero2 = "0";
            double numero1, numero2, total = 0;

            textoNumero1 = textBox1.Text;
            textoNumero2 = textBox2.Text;

            numero1 = Double.Parse(textoNumero1);
            numero2 = Double.Parse(textoNumero2);

            total = numero1 * numero2;

            label3.Text = total.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            string textoNumero1 = "0", textoNumero2 = "0";
            double numero1, numero2, total = 0;

            textoNumero1 = textBox1.Text;
            textoNumero2 = textBox2.Text;

            numero1 = Double.Parse(textoNumero1);
            numero2 = Double.Parse(textoNumero2);

            total = numero1 / numero2;

            label3.Text = total.ToString();
        }
    }
}
