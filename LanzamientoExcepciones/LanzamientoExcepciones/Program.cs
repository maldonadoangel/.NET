// See https://aka.ms/new-console-template for more information
int mes = 0;
Console.WriteLine("Ingresa el mes del 1 al 12 ");

try
{
     mes = int.Parse(Console.ReadLine());


}catch(Exception e)
{
    Console.WriteLine($"El valor es erroneo, se tomara por defecto el mes 1: {e.Message}");
    mes = 1;
}

Console.WriteLine(NombreDelMes(mes));

    static string NombreDelMes(int mes)
{
      switch (mes)
      {
        case 1:
            return "Enero";
            
        case 2:
            return "Febrero";
            
        case 3:
            return "Marzo";
            
        case 4:
            
            return "Abril";
        case 5:
            
            return "Mayo";
        case 6:
            
            return "Junio";
        case 7:
            
            return "Julio";
        case 8:
           
            return "Agosto";
        case 9:
            
            return "Septiembre";
        case 10:
            
            return "Octubre";
        case 11:
            
            return "Noviembre";
        case 12:
            return "Diciembre";
       
        default:
            throw new ArgumentOutOfRangeException();
    }
}