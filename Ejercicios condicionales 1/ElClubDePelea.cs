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
            string nombre;
            int edad;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (edad < 18)
            {
                Console.WriteLine("Lo siento, eres muy polluelo para esto.");
            }
            else
            {
                Console.WriteLine("Bienvenido al club " + nombre + ".");
            }
        }
    }
}
