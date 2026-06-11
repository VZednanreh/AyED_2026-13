using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Edades = 0;
            int contador = 0;
            int mayoresDeEdad = 0;
            int menoresDeEdad = 0;
            int edad = 0;
            Console.WriteLine("Ingrese las edades de las personas. Para finalizar ingrese un número negativo.");

            while (edad >= 0)
            {
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad >= 0)
                {
                    Edades += edad;
                    contador++;

                    if (edad >= 18)
                    {
                        mayoresDeEdad++;
                    }
                    if (edad < 18)
                    {
                        menoresDeEdad++;
                    }
                }
            }

            if (contador > 0)
            {
                double promedio = (double)Edades / contador;

                Console.WriteLine("Promedio de edad: " + promedio + "años.");
                Console.WriteLine("Personas mayores de edad: " + mayoresDeEdad);
                Console.WriteLine("Personas menores de edad: " + menoresDeEdad);
            }

            if (contador == 0)
            {
                Console.WriteLine("No se registraron edades válidas.");
            }
        }
    }
}
