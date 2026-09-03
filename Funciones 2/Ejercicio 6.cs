using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            codigo();
        }
        static void codigo()
        {
            Console.Write("Ingrese la cantidad deseada de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad < 2)
            {
                Console.WriteLine("Debe ingresar al menos 2 números para calcular el segundo mayor.");
                return;
            }

            double[] numeros = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = double.Parse(Console.ReadLine());
            }
            double mayor;
            double segundoMayor;
            if (numeros[0] > numeros[1])
            {
                mayor = numeros[0];
                segundoMayor = numeros[1];
            }
            else
            {
                mayor = numeros[1];
                segundoMayor = numeros[0];
            }

            for (int i = 2; i < cantidad; i++)
            {
                if (numeros[i] > mayor)
                {
                    segundoMayor = mayor;
                    mayor = numeros[i];
                }
                else if (numeros[i] > segundoMayor && numeros[i] < mayor)
                {
                    segundoMayor = numeros[i];
                }
            }
            Console.WriteLine("Segundo mayor: " + segundoMayor);
        }
    }
}
