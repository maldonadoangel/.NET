using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cuando usamos constantes se recomienda escribir el nombre
            //en mayusculas
            const double PI = 3.1416;
            double radio;
            string userData;
            double areaCirculo;

            Console.Write("Cual es el radio del circulo: ");
            userData = Console.ReadLine();

            if(double.TryParse(userData, out radio))
            {
                areaCirculo = PI * Math.Pow(radio, 2);
                //Forma de concatenar variables con valores numericos
                Console.WriteLine($"El area del circulo es: {areaCirculo}");
            }
            else
            {
                Console.WriteLine("El valor introducido no es numerico.");
            }

            Console.ReadKey();

        }
    }
}
