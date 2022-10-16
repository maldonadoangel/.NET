// See https://aka.ms/new-console-template for more information

//Array implicito

var datos = new[] { 1, 2, 3, 10.2 };

//Otra forma de declarar arrays
double[] numeros = { 1, 2.3, 54.3 };

//array de objetos


//Array multidimensional
string[,] arregl2D = new string[3, 2] { { "Uno", "Dos" }, { "Tres", "Cuatro" }, { "Cinco", "Seis" } };
foreach(string str in arregl2D)
{
    Console.WriteLine(str);
}

for(int i = 0; i < datos.Length; i++)
{
    Console.WriteLine(datos[i]);
}

//Array de tipos o anonimos
var personas = new[]
{
    new { Nombre = "Angel", edad = 24 },
    new { Nombre = "Ana", edad = 18 },
    new { Nombre = "Carlos", edad = 40 }
};

foreach(Object element in personas)
{
    Console.WriteLine(element);
}