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
            int presentes = 0;
            int ausentes = 0;
            int totalAlumnos = 0;
            string continuar = "s";
            while (continuar == "s" || continuar == "S")
            {
                Console.Write("Ingrese el nombre del alumno: ");
                string nombre = Console.ReadLine();

                string estado = "";
                while (estado != "P" && estado != "p" && estado != "A" && estado != "a")
                {
                    Console.Write("Ingrese el estado de " + nombre + " (P = Presente / A = Ausente): ");
                    estado = Console.ReadLine();

                    if (estado != "P" && estado != "p" && estado != "A" && estado != "a")
                    {
                        Console.WriteLine("Entrada inválida. Por favor, ingrese 'P' o 'A'.");
                    }
                }
                if (estado == "P" || estado == "p")
                {
                    presentes++;
                }
                else
                {
                    ausentes++;
                }

                totalAlumnos++;
                Console.Write("¿Desea cargar otro alumno? (s/n): ");
                continuar = Console.ReadLine();
            }
            Console.WriteLine("Cantidad de alumnos presentes: " + presentes);
            Console.WriteLine("Cantidad de alumnos ausentes: " + ausentes);
            Console.WriteLine("Total de alumnos evaluados: " + totalAlumnos);

            if (totalAlumnos > 0)
            {
                double porcentajePresentismo = ((double)presentes / totalAlumnos) * 100;
                Console.WriteLine("Porcentaje de presentismo: " + porcentajePresentismo + "%");
            }
            else
            {
                Console.WriteLine("No se registraron alumnos.");
            }
            Console.WriteLine("Presione cualquier tecla para salir...");
        }
    }
}
