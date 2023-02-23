// See https://aka.ms/new-console-template for more information

        //PILAS o Stack

        /* 
        Una pila es una estructura de
        datos de entradas ordenadas
        tales que solo se introduce y
        elimina por un extremo, llamado
        cima o tope
 
         */
using System.Collections;

string palabra;
int contador;
Stack greetingStack;


//Usando PUSH Y POP
Console.ForegroundColor = ConsoleColor.Green;
greetingStack = new Stack();
greetingStack.Push("Angel");
greetingStack.Push("Hernan");
greetingStack.Push("Morales");
greetingStack.Push("Maldonado");

contador = greetingStack.Count; // el metodo Count Este método (viene bajo el espacio de nombres System.Collections )
// se usa para obtener la cantidad de elementos contenidos en la pila. La capacidad es la cantidad de elementos que la pila puede almacenar y el conteo es la cantidad de elementos que realmente hay en la pila. La capacidad siempre es mayor o igual que Count. Recuperar el valor de esta propiedad es una operación O(1).
Console.WriteLine($"La cantidad de elementos que posee nuestro stack es: {contador}");

for(int i = 0; i < contador; i++)
{
    palabra = (string?)greetingStack.Pop(); // agregamos (string?) para realizar una convercion implicita, el metodo pop extrae el ultimo contenido de la pila
    Console.WriteLine($"Pop: {palabra}");
}
Console.WriteLine(contador);
Console.ReadKey();

//Uso de peek, este metodo nos ayuda a ver cual es el siguiente elemento en nuestra pila pero no lo extrae, solo nos indica cual sigue
//Usando PUSH Y POP
Console.ForegroundColor = ConsoleColor.Red;
greetingStack = new Stack();
greetingStack.Push("Angel");
greetingStack.Push("Hernan");
greetingStack.Push("Morales");
greetingStack.Push("Maldonado");

contador = greetingStack.Count; // el metodo Count Este método (viene bajo el espacio de nombres System.Collections )
// se usa para obtener la cantidad de elementos contenidos en la pila. La capacidad es la cantidad de elementos que la pila puede almacenar y el conteo es la cantidad de elementos que realmente hay en la pila. La capacidad siempre es mayor o igual que Count. Recuperar el valor de esta propiedad es una operación O(1).
for (int i = 0; i < contador; i++)
{
    palabra = (string?)greetingStack.Peek();
    Console.WriteLine($"La siguiente palabra en la pila: {palabra}");
    palabra = (string?)greetingStack.Pop(); // agregamos (string?) para realizar una convercion implicita, el metodo pop extrae el ultimo contenido de la pila
    Console.WriteLine($"Pop: {palabra}");
}
Console.ReadKey();

// CONTAINS y Clear
/*Contains nos ayuda a encontrar un elemento en nuestra pila y clear es para limpiar completamente la pila */
Console.ForegroundColor = ConsoleColor.White;
greetingStack = new Stack();
greetingStack.Push("Angel");
greetingStack.Push("Hernan");
greetingStack.Push("Morales");
greetingStack.Push("Maldonado");

if (greetingStack.Contains("Morales"))
{
    greetingStack.Clear();
}
Console.WriteLine($"El numero de elementos de nuestra pila: {greetingStack.Count}, despues que ejecutamos el metodo Clear");

Console.ReadKey();
