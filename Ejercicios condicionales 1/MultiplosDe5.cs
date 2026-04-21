using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Ingrese un numero entero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if ((numero % 5) == 0)
            {
                Console.WriteLine(numero + " es multiplo de 5.");
            }
            else
            {
                Console.WriteLine(numero + " no es multiplo de 5.");
            }
        }
    }
}
