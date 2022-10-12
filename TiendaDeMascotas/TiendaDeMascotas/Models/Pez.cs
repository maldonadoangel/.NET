using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeMascotas.Models
{
    internal class Pez: Animales
    {
        public Pez(string nombre, string color, double precio, string raza, bool disponible)
            : base(nombre, color, precio,  raza, disponible)
        {

        } 
    }
}
