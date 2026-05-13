double [,] matriz = new double [3, 3];

    Console.WriteLine("Matrices");
    Console.WriteLine("Ingrese las temperaturas: ");
    int contador = 1;
    for (int r=0; r < 3; r++)
{   
    for (int c = 0; c < 3; c++)
    {
        Console.WriteLine($"Dime la temperatura #{contador++} ");
        try{
        matriz[r, c] = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Formato incompatible. Por favor, ingrese un numero valido.");
            contador--;
            c--;
        }
    }
}
    
 Console.Clear();
 Console.WriteLine("Temperaturas registradas");
 for (int f =0; f < 3; f++)
{
    for (int c = 0; c < 3; c++)
    {

        if(matriz[f, c] < 35) Console.ForegroundColor = ConsoleColor.Green;
        else if (matriz[f, c] >=35 && matriz[f, c]<= 39) Console.ForegroundColor = ConsoleColor.Yellow;
        else Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{matriz[f, c]} ");
        Console.ResetColor();
    }
    Console.WriteLine();
}
