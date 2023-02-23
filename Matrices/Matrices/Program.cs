// See https://aka.ms/new-console-template for more information
//Declaracion de matrices o arreglos 1
Console.ForegroundColor = ConsoleColor.Green;
int[] listaNumeros = new int[3];

listaNumeros[0] = 100;
listaNumeros[1] = 200;
listaNumeros[2] = 300;
//listaNumeros[3] = 400;

Console.WriteLine($"Posicion 0: {listaNumeros[0]}, Posicion 1: {listaNumeros[1]}, Posicion 2: {listaNumeros[2]}");
foreach(int iteracion in listaNumeros)
{
    Console.WriteLine(iteracion);
}


//Declaracion de matrices o arreglos 2
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
int[] listaNumeros2 = {1,2,3,4,5,6,7};
string[] diaSemana = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
Console.WriteLine($"listaNumeros2[3] {listaNumeros2[3]}");
//Para que nos devuelva el ultimo dia de la semana
Console.WriteLine($"diaSemana[ultimoDia] {diaSemana[diaSemana.Length - 1]}");

//Declaracion de matrices o arreglos 3
Console.ForegroundColor = ConsoleColor.Red;
double[] numerosDecimales = new double[] {1.2,3.2,5.1 };
Console.WriteLine($"Numeros decimales:{numerosDecimales[2]}");
Console.ReadKey();

// matrices dobles
Console.ForegroundColor = ConsoleColor.Magenta;
int[][] matrisDoble = new int[2][];
matrisDoble[0] = new int[] {1};
matrisDoble[1] = new int[] {2};
foreach(int[] elemento in matrisDoble)
{
    foreach(int subElemento in elemento)
    {
        Console.WriteLine(subElemento);
    }
}

//Matriz de dos dimensiones
Console.ForegroundColor= ConsoleColor.Blue;
int[,] matridDimensional =new int [2,2];
matridDimensional[0,0] =  1;
matridDimensional[0,1] = 2;
matridDimensional[1,0] = 3;
matridDimensional[1,1] = 4;

Console.WriteLine($"matridDimensional[0,0] = {matridDimensional[0,0]}");
Console.WriteLine($"matridDimensional[0,1] = {matridDimensional[0, 1]}");
Console.WriteLine($"matridDimensional[1,0] = {matridDimensional[1, 0]}");
Console.WriteLine($"matridDimensional[1,1] = {matridDimensional[1, 1]}");

//Conocer la dimension del arreglo
Console.WriteLine($"La dimension del arreglo Matriz dimensional es: {matridDimensional.Rank}");
Console.WriteLine(matrisDoble.Rank);
