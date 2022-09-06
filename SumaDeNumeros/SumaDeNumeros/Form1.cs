using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDeNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1, numero2, numero3, total;

            string textoNumero1 = textBox1.Text;
            string textoNumero2 = textBox2.Text;
            string textoNumero3 = textBox3.Text;

            numero1 = Convert.ToDouble(textoNumero1);
            numero2 = Convert.ToDouble(textoNumero2);
            numero3 = Convert.ToDouble(textoNumero3);

            total = numero1 + numero2 + numero3;

            label4.Text = total.ToString();




           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
