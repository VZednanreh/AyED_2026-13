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
            double[] precios = new double[8];
            int contador = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.Write("Ingrese el precio del producto n° " + (i + 1) + ": ");
                precios[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Ingrese el dinero disponible del cliente: ");
            double dinero = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 8; i++)
            {
                if (precios[i] <= dinero)
                {
                    contador++;
                }
            }
            Console.WriteLine("Cantidad de productos distintos que puede comprar: " + contador);
        }
    }
}
