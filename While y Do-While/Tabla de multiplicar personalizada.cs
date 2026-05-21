using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int ciclo = 1;
            int multiplicacion = 1;
            do
            {
                if (ciclo <=12)
                {
                    multiplicacion = numero * ciclo;
                    Console.WriteLine(numero + " multiplicado por " + ciclo + " es igual a " + multiplicacion + ".");
                    ciclo++;
                }
            }while (numero<=12);
        }
    }
}
