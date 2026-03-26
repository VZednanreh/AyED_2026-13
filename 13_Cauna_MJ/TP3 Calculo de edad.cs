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
            Console.WriteLine("Que onda usuario.");
            Console.Write("¿En que año naciste? : ");
            int Año = Convert.ToInt32(Console.ReadLine());
            int Edad = (2026 - Año);
            Console.WriteLine("Entonces si naciste en " + Año + ", Tendrias que tener " + Edad + " años.");
        }
    }
}
