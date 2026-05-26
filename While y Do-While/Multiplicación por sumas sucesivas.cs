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
            Console.Write("Ingrese 2 numeros para multiplicarse: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero para multiplicar " + numero + ": ");
            int multiplicacion = int.Parse(Console.ReadLine());
            int acumulador = 0;
            int contador = 1;
            while (contador <= multiplicacion)
            {
                acumulador += numero;
                contador++;
            }
            int resultado = acumulador;
            Console.WriteLine(numero + "x" + multiplicacion + "=" + resultado);
        }
    }
}
