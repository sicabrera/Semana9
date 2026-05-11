int[] ventas = new int[5];

int totalLibros = 0;
int categoriaMayor = 0;
double promedio = 0;


for (int i = 0; i < ventas.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la cantidad de libros vendidos en la categoría #{i + 1}:");

        ventas[i] = int.Parse(Console.ReadLine());


        totalLibros += ventas[i];

      
        if (i == 0)
        {
            categoriaMayor = i;
        }
        else if (ventas[i] > ventas[categoriaMayor])
        {
            categoriaMayor = i;
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


promedio = (double)totalLibros / ventas.Length;


Console.WriteLine("\n----- RESULTADOS -----");

Console.WriteLine($"Total de libros vendidos: {totalLibros}");

Console.WriteLine($"La categoría con más ventas es la #{categoriaMayor + 1} con {ventas[categoriaMayor]} ventas.");

Console.WriteLine($"Promedio de ventas: {promedio:F2}");