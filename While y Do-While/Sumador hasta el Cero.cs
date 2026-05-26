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
            int contador = 1;
            int acumulador = 0;
            Console.Write("Ingrese la nota del alumno N°" + contador + ": ");
            int nota = int.Parse(Console.ReadLine());
            acumulador = acumulador + nota;
            int promedio = acumulador / 5;
            contador++;
            do
            {
                if (contador <= 5)
                {
                    Console.Write("Ingrese la nota del alumno N°" + contador + ": ");
                    nota = int.Parse(Console.ReadLine());
                    contador++;
                    acumulador = acumulador + nota;
                    promedio = acumulador / 5;
                }
            } while (contador <= 5);
            Console.WriteLine("El promedio de todos los alumnos fue de: " + promedio);
        }
    }
}
