// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Coche carro = new Coche(); // Crear objeto o instancia de tipo Coche
//Dar un estado inicial a nuestro Coche

Coche carro2 = new Coche();

Console.WriteLine($"{carro.getInformacionCoche()}");
Console.WriteLine($"{carro2.getInformacionCoche()}");
Coche carro3 = new Coche(4500.54, 47.14);
Console.WriteLine(carro3.getInformacionCoche());

class Coche
{
    //Atributos
    private int ruedas;
    private double longitud;
    private double ancho;
    private int puertas;
    private bool climatizador;
    private string tapiceria;

    //Constructor - inicializa un estado inicial de nuestros atributos de tipo Coche
    public Coche()
    {
        this.ruedas = 4;
        this.longitud = 2300.4;
        this.ancho = 0.800;

    }

    public Coche(double largoCoche, double anchoCoche)
    {
        ruedas = 4;
        longitud = largoCoche;
        ancho = anchoCoche;
    }

    //metodos que nos dan informacion de propiedades, el metodo get se encarga de devolvernos o darnos la informacion que queremos, se recomienda
    //Inicializar los nombres de estos metodos que devuelven informacion con getNombreDelMetodo
    public string getInformacionCoche()
    {
        return "El carro tiene: " + this.ruedas + " Con una Longitud de: " + this.longitud + " con un ancho de: " + this.ancho;
    }
}