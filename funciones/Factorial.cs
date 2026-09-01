using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Factorial(int n)
        {
            int factor = 1;
            for (int i = 1; i <= n; i++)
            {
                factor *= i;
            }
            Console.WriteLine("La sumatoria dio: " + factor);
        }
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Factorial(numero);
            }
            else
            {
                Console.WriteLine("Ingresar un número entero mayor a 0.");
            }
        }
    }
}
