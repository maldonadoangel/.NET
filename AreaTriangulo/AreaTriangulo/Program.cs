using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bases;
            double altura;
            double area;

            Console.Write("Por favor ingrese la base de su triangulo: ");
            bases = Convert.ToDouble(Console.ReadLine());
            Console.Write("Por favor ingrese la altura de su triangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = bases * altura;

            Console.WriteLine($"El area del triangulo es: {area}");
            Console.ReadLine();

        }
    }
}
