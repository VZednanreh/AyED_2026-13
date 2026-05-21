using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero limite entero y positivo: ");
            int limite = int.Parse(Console.ReadLine());
            int GeneradorNumeros = 1;
            while (GeneradorNumeros <= limite)
            {
                if (GeneradorNumeros % 2 == 0)
                {
                    Console.WriteLine(GeneradorNumeros + " Es par.");
                }
                GeneradorNumeros++;
            }
        }
    }
}
