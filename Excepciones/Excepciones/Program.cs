// See https://aka.ms/new-console-template for more information

int numero = 0, contador = 0, numeroRandom;
//Generamos un numero random desde 0 a 10
Random random = new Random();
//Asignamos el valor Random a la variable numero random, convirtiendolo en entero al asignar el parametros de 0 a 10
numeroRandom = random.Next(0, 10);
Console.WriteLine("Bienvenido al programa donde adivinaras el numero de la PC");



do
{
    contador++;
    Console.WriteLine("Ingrese un numero para adivinar: ");
    try
    {
        numero = int.Parse(Console.ReadLine());
    }catch(Exception e)
    {
        Console.WriteLine("No haz introducido un valor numerico valido, se tomara como valor por defecto el 0");
        Console.WriteLine(e.Message);
    }
    
    if(numero > numeroRandom)
    {
        Console.WriteLine($"El numero ingresado es mayor al de la maquina, intenta de nuevo");
    }
    if(numero < numeroRandom){
        Console.WriteLine("El numero ingresado es menor al de la maquina, intenta de nuevo");
    }
    
} while (numero != numeroRandom);

Console.WriteLine($"Correcto!!, el numero es: {numeroRandom} y el numero de intentos es de {contador}");
