// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] nombresAlumnos = { "Angel", "Pepito", "Mario", "Juan", "Carlos" };
Console.ForegroundColor = ConsoleColor.Green;
mostrarNombreAlumno(nombresAlumnos);


   static void mostrarNombreAlumno(string[] nombreAlumno)
{
    foreach(string elemento in nombreAlumno)
    {
        Console.WriteLine(elemento);    
    }
}