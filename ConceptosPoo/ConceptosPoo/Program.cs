// See https://aka.ms/new-console-template for more information
using ConceptosPoo;

Console.WriteLine("Hello, World!");


realizarTarea();
//Espera a que le teclees algo
Console.ReadKey();

static void realizarTarea()
{
    Punto punto2 = new Punto(150, 90);
    Punto punto = new Punto();
    Punto punto3 = new Punto();

    double distancia = punto.DistanciaHasta(punto2);
    Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");

    //Nos mostrara 3 objetos debido a que creamos 3 objetos de tipo Punto en esta clase, por lo tanto nuestro atributo static toma los valores dentro de su clase padre.
    Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
}