// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Circulo circulo = new Circulo();

Console.WriteLine($"El calculo del area es: {circulo.calculoArea(5)}"); 

Circulo circulo2 = new Circulo();

Console.WriteLine($"{circulo2.calculoArea(9)}");


class Circulo
{
    const double pi = 3.1416; // propiedad de la clase circulo


   public double calculoArea(int radio)
    {
        return pi * radio * radio;
    }

}