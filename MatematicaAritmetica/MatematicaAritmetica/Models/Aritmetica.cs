using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MatematicaAritmetica.Models
{
    internal class Aritmetica
    {
        public double numero = 0;
        public double numero2 = 0;

        
        
        public Aritmetica(double numero, double numero2)
        {
            this.numero = numero;
            this.numero2 = numero2;
        }

        public double Suma(double numero, double numero2)
        {
            return this.numero + this.numero2;
        }
        public double Resta(double numero, double numero2)
        {
            return this.numero - this.numero2;
        }

        public double Multiplicacion(double numero, double numero2)
        {
            return this.numero * this.numero2;
        }
        public double Division(double numero, double numero2)
        {
            return this.numero / this.numero2;
        }


    }
}
