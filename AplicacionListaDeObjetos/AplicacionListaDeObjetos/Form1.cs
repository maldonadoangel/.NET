using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionListaDeObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObjetos_Click(object sender, EventArgs e)
        {
            //Arreglos Unidimensionales
            //No nos permite ser dinamicos, por lo tanto no podemos agregar más elementos, pero es otra forma de crear arreglos
            int[] listaItems = new int[] {0,1,2,3,4,5};

            //Esta forma de crear arreglos en mejor porque funciona de manera dinamica osea nos permite agregar más elementos0
            List<string> compras = new List<string>();

            compras.Add("Teclado");
            compras.Add("Monitor");
            compras.Add("CPU");

            for(int i = 0; i < compras.Count; i++)
            {
                
                MessageBox.Show($"El objeto es: {compras[i]}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
