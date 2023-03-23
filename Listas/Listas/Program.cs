// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.ForegroundColor = ConsoleColor.Yellow;

List<int> listNumeros = new List<int>();
int contador;
listNumeros.Add(10);
listNumeros.Add(20);
listNumeros.Add(30);
contador = listNumeros.Count;
for (int i = 0; i < contador; i++)
{
    Console.WriteLine($"No encontramos en el indice {i} de la lista y el valor que se encuentra es: {listNumeros[i]}");
}
Console.WriteLine($"Numero de elementos dentro de la lista: {listNumeros.Count}");

