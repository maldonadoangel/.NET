// See https://aka.ms/new-console-template for more information
using TiendaDeMascotas.Models;


Animales gato = new Animales("Gato", "negro", 350, "sin raza", true);

gato.compraAnimales(350);

Console.WriteLine("-----------------------------");


Pez pescadito = new Pez("Pez dorado","Dorado", 500, "Dorado", true);
pescadito.compraAnimales(500);
