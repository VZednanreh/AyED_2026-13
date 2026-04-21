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
            int numero;
            Console.Write("Ingrese un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if ((numero % 2) == 0)
            {
                Console.WriteLine(numero + " es par.");
            }
            else
            {
                Console.WriteLine(numero + " es impar.");
            }
        }
    }
}
