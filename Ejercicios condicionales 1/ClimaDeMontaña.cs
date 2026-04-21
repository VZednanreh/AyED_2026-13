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
            Double Temperatura;
            Console.Write("Ingrese la temperatura actual: ");
            Temperatura = Convert.ToDouble(Console.ReadLine());
            if (Temperatura < 0)
            {
                Console.WriteLine("peligro de congelamiento.");
            }
            else if (Temperatura > 0 & Temperatura < 15)
            {
                Console.WriteLine("Mucho Frio.");
            }
            if (Temperatura > 15)
            {
                Console.WriteLine("Clima agradable.");
            }
        }
    }
}
