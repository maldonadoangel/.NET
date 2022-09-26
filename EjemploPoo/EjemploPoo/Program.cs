// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Hello, World!");

Circulo circulo = new Circulo();

Console.WriteLine($"El calculo del area es: {circulo.CalculoArea(5)}"); 

Circulo circulo2 = new Circulo();

Console.WriteLine($"{circulo2.CalculoArea(9)}");
*/

//Probamos la clase convertir euro a dolar


ConversorEuroDolar convertirEuroADolar = new ConversorEuroDolar();

convertirEuroADolar.cambiaValorEuro(1.45);

Console.WriteLine($"El valor de convertir 50 euros a dolar: {convertirEuroADolar.Convierte(50)}");


class Circulo
{
    //private nos sirve para encapsular nuestros atributos o metodos de nuestra clase
    //Se recomiendan datos, variables o constantes, se recomiendan que sean privados
    //si queremos acceder a estos atributos o metodos se utiliza un metodo que veremos mas adelante
    private const double pi = 3.1416; // propiedad de la clase circulo


   public double CalculoArea(int radio)
    {
        return pi * radio * radio;
    }

}

class ConversorEuroDolar
{
   private double valorEuro = 1.253;

    public double Convierte(double cantidad)
    {
        return cantidad * valorEuro;
    }

    public void cambiaValorEuro(double nuevoValor)
    {
        if(nuevoValor < 0)
        {
            valorEuro = 1.253;
        }
        else
        {
            valorEuro = nuevoValor;
        }
        
    }
}