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
            Console.Write("Ingrese un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());
            while (numero >= 0)
            {
                Console.WriteLine(numero);
                numero--;
            }
        }
    }
}
