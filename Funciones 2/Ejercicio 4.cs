using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            codigo();
        }
        static void codigo()
        {
            double acumulador1 = 0;
            double acumulador2 = 0;
            int Negativos = 0;
            int Positivos = 0;
            int IgualCero = 0;
            

            Console.Write("Ingrese la cantidad deseada de números: ");
            int cantidad = int.Parse(Console.ReadLine());

            double[] numeros = new double[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese el número " + (i + 1) + ": ");
                numeros[i] = double.Parse(Console.ReadLine());
                if (numeros[i] < 0)
                {
                    acumulador2 += numeros[i];
                    Negativos++;
                }
                else if (numeros[i] > 0)
                {
                    acumulador1 += numeros[i];
                    Positivos++;
                }
                else if (numeros[i] == 0)
                {
                    IgualCero++;
                }
            }
            double promedio1 = acumulador1 / Positivos;
            double promedio2 = acumulador2 / Negativos;

            Console.WriteLine("Promedio de negativos: " + promedio2);
            Console.WriteLine("Promedio de positivos: " + promedio1);
            Console.WriteLine("Cantidad de positivos: " + Positivos);
            Console.WriteLine("Cantidad de negativos: " + Negativos);
            Console.WriteLine("Cantidad de ceros: " + IgualCero);
        }
    }
}
