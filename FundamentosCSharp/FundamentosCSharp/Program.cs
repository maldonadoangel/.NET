// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

sbyte numero = -128;
ulong numeroLargo = 12120021545154454449;
float numeroDecimal = 14.6f;
double numeroDec = 54.5;
object persona = new { nombre = "Angel", apellido = "Morales", edad = 24 };
Console.WriteLine(persona);


DateTime fecha = DateTime.Now;

Console.ReadKey();


Console.WriteLine($"La fecha actual es: {fecha}");