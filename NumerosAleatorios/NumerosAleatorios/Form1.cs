namespace NumerosAleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumeroAleatorio_Click(object sender, EventArgs e)
        {
            string? numeroString;
            numeroString = txtNumero.Text;
            Random random = new Random();
            


            //Valor entre cero y 10
            int numeroRandom = random.Next(11);
            int numero = Convert.ToInt32(numeroString);

            calcularNumeroAleatorio(numero,numeroRandom);
        }

        private void calcularNumeroAleatorio(int numero, int numeroRandom)
        {
            
                if(numero < numeroRandom)
                {
                    MessageBox.Show("El numero es mayor, intenta nuevamente");

                } else if(numero > numeroRandom)
                {
                    MessageBox.Show("El numero es menor, intenta nuevamente ");
            }
            else
            {
                MessageBox.Show($"Ganaste!, el numero es {numeroRandom}");
            }

        }
    }
}