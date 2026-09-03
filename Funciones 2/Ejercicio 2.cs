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
            pipo();
        }
        static void pipo()
        {
            Console.Write("Ingrese un numero entero positivo: ");
            int numero = int.Parse(Console.ReadLine());
            int suma = 0;
            
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    suma = suma + i;
                }
            }
            
            if (suma == numero && numero > 0)
            {
                Console.WriteLine("es un numero perfecto.");
            }
            else
            {
                Console.WriteLine("no es un numero perfecto.");
            }
        }
    }
}
