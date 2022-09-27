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

    double distancia = punto.DistanciaHasta(punto2);
    Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");
}