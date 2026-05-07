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
            int contador = 0;
            int numero;
            Console.Write("Ingrese un numero entero positivo porfavor o sos wachin: ");
            numero = int.Parse(Console.ReadLine());
            for (int x = 1; x <= numero; x++)
            {
                if (numero % x == 0)
                {
                    Console.WriteLine(numero + " es divisible por " + x + ".");
                }
                else
                {
                    Console.WriteLine(numero + " no es divisible por " + x + ".");
                }
                contador++;
            }
            if (contador == numero)
            {
                if (numero % 1 == 0 & numero % numero == 0)
                {
                    Console.WriteLine("Es primo.");
                }
            }
        }
    }
}
