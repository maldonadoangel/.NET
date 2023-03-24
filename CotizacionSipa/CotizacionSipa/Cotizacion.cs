using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionSipa
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            dgvProductos.Columns.Add("Codigo", "Codigo");
            dgvProductos.Columns.Add("Nombre", "Nombre");
            dgvProductos.Columns.Add("Descripcion", "Descripcion");
            dgvProductos.Columns.Add("Medidas", "Medidas");
            dgvProductos.Columns.Add("Foto", "Foto");
            dgvProductos.Columns.Add("Cantidad", "Cantidad");
            dgvProductos.Columns.Add("P/Unitario", "P/Unitario");
            dgvProductos.Columns.Add("Total", "Total");
            
        }
    }
}
