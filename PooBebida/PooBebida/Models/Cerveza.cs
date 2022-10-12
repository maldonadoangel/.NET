using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBebida.Models
{
    //Herencia
    internal class Cerveza: Bebida
    {
        public Cerveza(string nombre, string sabor = "Sabor no ingresado", int cantidad = 100) 
            :base(nombre, sabor, cantidad)//Como podemos ver de esta forma aplicamos la herencia de la clase padre Bebida
        {

        }
    }
}
