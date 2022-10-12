using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeMascotas.Models
{
    internal class Animales
    {
        //Atributos
        public string nombre { get; set; }
        public string color { get; set; }
        public double precio { get; set; }
        public string raza { get; set; }
        public bool disponible { get; set; }

        public Animales(string nombre, string color, double precio, string raza, bool disponible)
        {
            this.nombre = nombre;
            this.color = color;
            this.precio = precio;
            this.raza = raza;
            this.disponible = disponible;
        }

        public Animales(string color, double precio, string raza, bool disponible)
        {
            this.color = color;
            this.precio = precio;
            this.raza = raza;
            this.disponible = disponible;
        }

        public void compraAnimales(double pago)
        {
            while(this.disponible == true)
            {

                if (pago == this.precio)
                {
                    Console.WriteLine("El pago fue realizado con éxito");
                    this.precio = this.precio - pago;
                    Console.WriteLine($"El total de tu compra es de {this.precio}");
                    Console.WriteLine($"Felicidades por tu nuevo: {this.nombre}");
                    Console.ReadKey();
                    this.disponible = false;
                    
                }
                if (pago < this.precio)
                {
                    Console.WriteLine("El pago es menor al precio de la mascota");
                    this.precio = this.precio - pago;
                    Console.WriteLine($"Aun debes: {this.precio}, para poder comprar un {this.nombre}");
                    break;
                }
            }
            
            
           
        }
    }
}
