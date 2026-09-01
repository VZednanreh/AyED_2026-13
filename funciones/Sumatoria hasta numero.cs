using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void SumarHasta(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            Console.WriteLine("La sumatoria dio: " + suma);
        }
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                SumarHasta(numero);
            }
            else
            {
                Console.WriteLine("Ingresar un número entero mayor a 0.");
            }
        }
    }
}
