using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        
        static void ContarHasta(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Ingresa un numero entero positivo.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                ContarHasta(numero);
            }
            else
            {
                Console.WriteLine("Debes ingresar un número entero mayor a 0.");
            }
        }
    }
}
