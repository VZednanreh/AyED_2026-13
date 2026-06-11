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
            Console.WriteLine("Ingrese números enteros positivos. Para finalizar ingrese un número negativo.");

            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            int minimo = numero;

            while (numero >= 0)
            {
                if (numero < minimo)
                {
                    minimo = numero;
                }
                Console.Write("Ingrese un número: ");
                numero = int.Parse(Console.ReadLine());
            }

            if (minimo >= 0)
            {
                Console.WriteLine("El número más chico ingresado fue: " + minimo);
            }
            if (minimo < 0)
            {
                Console.WriteLine("No se ingresaron números positivos en la lista.");
            }
        }
    }
}
