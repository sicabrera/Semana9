int[] puntajes = new int[6];

int puntajeMayor = 0;
int mayores500 = 0;


for (int i = 0; i < puntajes.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese el puntaje #{i + 1}:");
        puntajes[i] = int.Parse(Console.ReadLine());

        
        if (i == 0)
        {
            puntajeMayor = puntajes[i];
        }
        else if (puntajes[i] > puntajeMayor)
        {
            puntajeMayor = puntajes[i];
        }

        
        if (puntajes[i] > 500)
        {
            mayores500++;
        }
    }

    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Ingrese un número entero.");
        Console.ResetColor();

        i--;
    }
}


Array.Sort(puntajes);

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n----- RESULTADOS -----");

Console.WriteLine($"Puntaje más alto: {puntajeMayor}");

Console.WriteLine($"\nCantidad de puntajes mayores a 500: {mayores500}");

Console.WriteLine("\nPuntajes ordenados de menor a mayor:");


for (int i = 0; i < puntajes.Length; i++)
{
    Console.WriteLine(puntajes[i]);
}

Console.ResetColor();