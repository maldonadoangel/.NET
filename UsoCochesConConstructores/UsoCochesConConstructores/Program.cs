// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Coche carro = new Coche(); // Crear objeto o instancia de tipo Coche
//Dar un estado inicial a nuestro Coche

Coche carro2 = new Coche();

Console.WriteLine($"{carro.getInformacionCoche()}");
Console.WriteLine($"{carro2.getInformacionCoche()}");
Coche carro3 = new Coche(4500.54, 47.14);
Console.WriteLine($"El carro 3 tiene: {carro3.getInformacionCoche()}");

carro3.setExtras(true, "Cuero");
Console.WriteLine(carro3.getExtras());

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
        this.ruedas = 4;
        this.longitud = largoCoche;
        this.ancho = anchoCoche;
    }

    public string getInformacionCoche()
    {
        return "" + this.ruedas + " Con una Longitud de: " + this.longitud + " con un ancho de: " + this.ancho;
    }
    //metodo setter, no devuelve nada, solo modifica los valores o da valores, pero no los devuelve, por lo tanto se utiliza void
    public void setExtras(bool climatizador, string tapiceria)
    {
        this.climatizador = climatizador;
        this.tapiceria = tapiceria;
    }

    public string getExtras()
    {
        return "Extras del coche:" + " tapiceria: " + this.tapiceria + "climatizador: " + this.climatizador; 
    }
}