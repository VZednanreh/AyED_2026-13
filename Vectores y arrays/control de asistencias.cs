using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] asistencias = new string[20];
            int faltas = 0;
            Console.WriteLine("Ingrese (P) para Presente o (A) para Ausente.");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Clase n° " + (i + 1) + ": ");
                string entrada = Console.ReadLine();
                while (entrada != "P" && entrada != "p" && entrada != "A" && entrada != "a")
                {
                    Console.Write("Opción no válida. Ingrese (P) o (A) : ");
                    entrada = Console.ReadLine();
                }

                asistencias[i] = entrada;
            }

            for (int i = 0; i < 20; i++)
            {
                if (asistencias[i] == "A" || asistencias[i] == "a")
                {
                    faltas++;
                }
            }
            Console.WriteLine("Total de inasistencias: " + faltas);

            if (faltas > 6)
            {
                Console.WriteLine("Estado del alumno: Libre por faltas");
            }
            else
            {
                Console.WriteLine("Estado del alumno: Regular");
            }
        }
    }
}
