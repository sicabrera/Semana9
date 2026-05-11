double[] notas = new double[8];

double suma = 0;
double promedio = 0;

int reprobados = 0;


for (int i = 0; i < notas.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante #{i + 1}:");

        notas[i] = double.Parse(Console.ReadLine());

      
        suma += notas[i];

    
        if (notas[i] < 60)
        {
            reprobados++;
        }
    }

    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Ingrese una nota válida.");
        Console.ResetColor();

        i--;
    }
}


promedio = suma / notas.Length;

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\nNOTAS APROBADAS");

for (int i = 0; i < notas.Length; i++)
{
    if (notas[i] >= 60)
    {
        Console.WriteLine(notas[i]);
    }
}

Console.WriteLine($"\nCantidad de estudiantes reprobados: {reprobados}");

Console.WriteLine($"Promedio general del grupo: {promedio:F2}");
Console.ResetColor();