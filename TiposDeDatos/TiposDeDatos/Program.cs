using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = String.Empty;
            Console.WriteLine("Proporciona un mensaje por favor: ");
            message = Console.ReadLine();
            Console.WriteLine("Tu cadena es : " + message);
            Console.ReadKey();
        }
    }
}
