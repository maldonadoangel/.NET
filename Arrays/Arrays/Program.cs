// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Los arreglos siempre que los creamos, los valores que tienen regularmente se inicializan, por ejemplo:
//Si creamos un arreglo de numeros enteros y no añadimos los valores,por defecto se inicializan en cero

int[] numeros = new int[5];

numeros[0] = 10;
numeros[1] = 20;
numeros[2] = 40;
numeros[3] = 100;
numeros[4] = 400;



// Otra forma de agregar los datos
int[] listaNumero = new int[5] { 10, 23, 50, 24, 54 };

for (int i = 0; i < numeros.Length; i++)
{
    
    Console.WriteLine(numeros[i]);

     }

Console.WriteLine();
for (int j = 0; j < listaNumero.Length; j++)
{
    Console.WriteLine(listaNumero[j]);
}
Console.WriteLine();
//Ver el tamaño de la lista
Console.WriteLine($"El tamaño de la lista: {listaNumero.Length}");


//Otra forma de crear un array
int[] numeros2 = { 1, 2, 3, 4, 5, 6, 19, 32 };

for (int index = 0; index < numeros2.Length; index++)
{
    Console.WriteLine(numeros2[index]);
}