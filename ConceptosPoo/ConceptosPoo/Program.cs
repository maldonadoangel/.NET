// See https://aka.ms/new-console-template for more information
using ConceptosPoo;
using static System.Math;

//Console.WriteLine("Hello, World!");


//realizarTarea();
//Espera a que le teclees algo
//como importamos system.Math, como es statico porque ponemos primero el Math que es el nombre de la clase, al importarlo ya no es necesario colocar
//Math.sqrt(9), sino simplemente Sqrt(9)
double raiz = Sqrt(9);
double potencia = Pow(3, 4);
Console.ReadKey();
Console.WriteLine(raiz);
Console.Write(potencia);

//--------------------------------------------------------------------------------------------------
//Clases anonimas
var nombreVariable = new {Nombre = "Angel", Edad = 24 };
Console.WriteLine($"Tu nombre es: {nombreVariable.Nombre} y tu edad es de: {nombreVariable.Edad}");
//--------------------------------------------------------------------------------------------------
static void realizarTarea()
{
    Punto punto2 = new Punto(150, 90);
    Punto punto = new Punto();
    Punto punto3 = new Punto();

    double distancia = punto.DistanciaHasta(punto2);
    Console.WriteLine($"La distancia entre los dos puntos es: {distancia}");

    //Nos mostrara 3 objetos debido a que creamos 3 objetos de tipo Punto en esta clase, por lo tanto nuestro atributo static toma los valores dentro de su clase padre.
    //Como observamos al ser un metodo estatico, debemos llamar la clase primero seguido del punto y el metodo static
    Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
}