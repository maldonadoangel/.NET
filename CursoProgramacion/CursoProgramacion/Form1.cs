namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string edadTexto = textBox1.Text;
            int edad = Int32.Parse(edadTexto);

            if(edad >= 18)
            {
                label1.Text = "Es mayor de edad";
            }
            else
            {
                label1.Text = "Es menor de edad";
            }
            
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}