decimal [] ventasemanal = new decimal [7];
decimal total = 0;
decimal diasmayores150 = 0;
decimal ventamasbaja = 0;

Console.WriteLine("Ingrese las ventas de la semana: ");
for (int i=0; i < ventasemanal.Length; i++)
{
    try
    {
      Console.WriteLine($"Ventas del dia {i+1}:");
    ventasemanal[i] = decimal.Parse(Console.ReadLine());  
    }
    
    catch(FormatException)
    {
        Console.WriteLine("Formato incorrecto, ingrese un numero valido.");
        i--;
    }

    total += ventasemanal[i];

    if (ventasemanal[i] > 150)
    {
     diasmayores150++;  
    }
    
    if(i==0)
    {
        ventamasbaja = ventasemanal[i];
    }
    else if (ventasemanal[i] < ventamasbaja)
    {
        ventamasbaja = ventasemanal[i];
    }
}
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nRESULTADO\n");
Console.WriteLine($"El total vendido fue: {total}");
Console.WriteLine($"Dias que superaron 150 en ventas: {diasmayores150}");
Console.WriteLine($"Venta mas baja de la semana: {ventamasbaja}");
Console.ResetColor();
