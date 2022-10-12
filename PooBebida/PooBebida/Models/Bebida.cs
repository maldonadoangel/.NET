using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooBebida.Models
{
    internal class Bebida
    {
        //Atributos
        public string nombre { get; set; }
        public string sabor { get; set; }

        public int cantidad { get; set; }

        //Constructores o inicializador de atributos
    
        public Bebida(string nombre, string sabor, int cantidad){

                this.nombre = nombre;
                this.sabor = sabor;
                this.cantidad = cantidad;
            }

        public void beberse(int cuantoBebio)
        {
            this.cantidad = this.cantidad - cuantoBebio;
        } 
        
    }
}
