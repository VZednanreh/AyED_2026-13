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
            kiko();
        }
        static void kiko()
        {
            Console.Write("Ingrese el primer numero entero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero entero: ");
            int num2 = int.Parse(Console.ReadLine());

            int inicio;
            int fin;
            if (num1 < num2)
            {
                inicio = num1;
                fin = num2;
            }
            else
            {
                inicio = num2;
                fin = num1;
            }

            int acumulador = 0;
            int pares = 0;
            int impares = 0;

            Console.WriteLine("Numeros comprendidos entre " + inicio + " y " + fin + ":");

            for (int i = inicio; i <= fin; i++)
            {
                Console.Write(i + " ");

                acumulador += i;

                if (i % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }

            Console.WriteLine("Suma total: " + acumulador);
            Console.WriteLine("Cantidad de pares: " + pares);
            Console.WriteLine("Cantidad de impares: " + impares);
        }
    }
}
