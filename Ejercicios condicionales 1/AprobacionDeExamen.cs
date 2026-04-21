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
            Double nota;
            Console.Write("Ingrese su nota: ");
            nota = Convert.ToDouble(Console.ReadLine());
            if (nota >= 7)
            {
                Console.WriteLine("Promocionado.");
            }
            else if (nota >= 4 & nota <= 6)
            {
                Console.WriteLine("A finales.");
            }
            if (nota < 4)
            {
                Console.WriteLine("A recuperatorio.");
            }
        }
    }
}
