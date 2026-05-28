using System;

class Program
{
    static void Main()
    {
        int positivos = 0;
        int negativos = 0;
        int ceros = 0;
        string entrada = "";
        Console.WriteLine("Ingresa números continuamente. Para salir, presiona 'X' o 'n'.");
        while (entrada != "X" && entrada != "x" && entrada != "N" && entrada != "n")
        {
            Console.Write("Introduce un número (o 'X'/'n' para salir): ");
            entrada = Console.ReadLine();
            if (entrada != "X" && entrada != "x" && entrada != "N" && entrada != "n")
            {
                int numero = int.Parse(entrada);
                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    ceros++;
                }
            }
        }
        Console.WriteLine("Números Positivos: " + positivos);
        Console.WriteLine("Números Negativos: " + negativos);
        Console.WriteLine("Cantidad de Ceros: " + ceros);
    }
}
