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
            codigo();
        }

        static void codigo()
        {
            Console.Write("Ingrese un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            int[] Primos = new int[numero];
            int cantidad = 0;

            for (int i = 2; i <= numero; i++)
            {
                int contador = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contador++;
                    }
                }

                if (contador == 2)
                {
                    Primos[cantidad] = i;
                    cantidad++;
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(Primos[i]);
            }
        }
    }
}
