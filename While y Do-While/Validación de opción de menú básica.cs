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
            Console.WriteLine("1. Saludar");
            Console.WriteLine("2. Despedirse");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese el numero ideal: ");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion != 3)
            {
                switch (opcion)
                {
                    case 1: Console.WriteLine("Que onda."); break;
                    case 2: Console.WriteLine("nos vemos amigo."); break;
                    case 3: Console.WriteLine("Cerrando...."); break;
                    default: Console.WriteLine("Su opcion ideal no existe."); break;
                }
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Despedirse");
                Console.WriteLine("3. Salir");
                Console.Write("Ingrese el numero ideal: ");
                opcion = int.Parse(Console.ReadLine());
            }

        }
    }
}
