double [] temperaturas = new double [7];
double suma = 0;
double promedio;

for (int i=0; i < temperaturas.Length; i++)
{
    try{
    Console.WriteLine($"Digite la temperatura del dia {i+1}:");
    temperaturas[i] = double.Parse(Console.ReadLine()!);
    }

    catch(FormatException)
    {
        Console.WriteLine("Formato no valido. Ingrese un número valido.");
        i--;
    }

    suma += temperaturas[i];
}
Console.WriteLine("\nLas temperaturas ingresadas son:");
for (int i=0; i < temperaturas.Length; i++)
{
    Console.WriteLine($"Dia {i+1}: {temperaturas[i]}");
}

promedio = suma / 7.00;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nRESULTADOS\n");
Console.WriteLine($"El promedio de temperatura semanal es ≈ {promedio:F2}");
Console.WriteLine($"La temperatura registrada mas alta de la semana es: {temperaturas.Max()}");
Console.WriteLine($"La temperatura registrada mas baja de la semana es: {temperaturas.Min()}");
Console.ResetColor();