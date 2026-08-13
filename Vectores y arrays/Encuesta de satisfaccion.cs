using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] respuestas = new int[25];
            int[] contadores = new int[5];
            for (int i = 0; i < 25; i++)
            {
                Console.Write("Ingrese calificación del cliente N°" + (i + 1) + " (1 al 5): ");
                respuestas[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 25; i++)
            {
                int nota = respuestas[i];
                if (nota >= 1 && nota <= 5)
                {
                    contadores[nota - 1]++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Cantidad de " + (i + 1) + ": " + contadores[i] + " respuesta(s)");
            }
        }
    }
}
