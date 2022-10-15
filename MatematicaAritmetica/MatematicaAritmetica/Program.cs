// See https://aka.ms/new-console-template for more information

using MatematicaAritmetica.Models;

double numero = 0;
double numero2 = 0;
Console.WriteLine("Ingresa tu primer numero");
try
{
     numero = Double.Parse(Console.ReadLine());
}
catch (OverflowException e)
{
    Console.WriteLine("El numero ingresado es demasiado grande, se usara el valor de 0 por defecto");
    numero = 0;
}
catch (FormatException e)
{
    Console.WriteLine("El valor ingresado no es del formato correcto, se tomara el valor de 0");
    numero = 0;
}catch(Exception e)
{
    Console.WriteLine("Error en el valor ingresado, se tomara como valor el 0");
    numero = 0;
}

Console.WriteLine("Ingresa tu segundo numero");

try
{
    numero2 = Double.Parse(Console.ReadLine());
}
catch (OverflowException e)
{
    Console.WriteLine("El numero ingresado es demasiado grande, se usara el valor de 0 por defecto");
    numero2 = 0;
}
catch (FormatException e)
{
    Console.WriteLine("El valor ingresado no es del formato correcto, se tomara el valor de 0");
    numero2 = 0;
}
catch (Exception e)
{
    Console.WriteLine("Error en el valor ingresado, se tomara como valor el 0");
    numero2 = 0;
}



Aritmetica aritmetica = new Aritmetica(numero, numero2);
double resultado = aritmetica.Suma(numero, numero2);
Console.WriteLine($"El valor de la suma es de: {resultado}");
