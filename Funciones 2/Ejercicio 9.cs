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
            codigo();
        }
        static void codigo()
        {
            Console.Write("Ingrese la cantidad de numeros enteros: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] numeros = new int[cantidad];
            int[] frecuencias = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese un numero " + (i + 1) + ": ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < cantidad; i++)
            {
                int contador = 0;
                for (int j = 0; j < cantidad; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        contador++;
                    }
                }
                frecuencias[i] = contador;
            }
            int maxFrecuencia = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if (frecuencias[i] > maxFrecuencia)
                {
                    maxFrecuencia = frecuencias[i];
                }
            }
            Console.WriteLine("Se repitieron un total de "+ maxFrecuencia + " veces los siguientes numeros:");

            for (int i = 0; i < cantidad; i++)
            {
                if (frecuencias[i] == maxFrecuencia)
                {
                    int YaEsta = 0;
                    for (int k = 0; k < i; k++)
                    {
                        if (numeros[i] == numeros[k])
                        {
                            YaEsta = 1;
                        }
                    }

                    if (YaEsta == 0)
                    {
                        Console.WriteLine(numeros[i] +"");
                    }
                }
            }
        }
    }
}
