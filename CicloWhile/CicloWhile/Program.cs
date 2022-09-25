// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? nombre;
int espacio = 0;
List<string> mochila = new List<string>();
Console.Write("Cuantos espacios desea en su mochila?  " );
espacio = int.Parse(Console.ReadLine());


//Utilizamos este ciclo while, para guardar los objetos en la mochila
while(mochila.Count < espacio)
{
    Console.Write("Ingrese el nombre del objeto a guardar " );
    nombre = Console.ReadLine();
    mochila.Add(nombre);
}

//Bucle Determinado, utilizamos este for para mostrar los objetos guardados
for(int i = 0; i < mochila.Count; i++)
{
    Console.WriteLine("--------");
    Console.WriteLine(mochila[i]);
}