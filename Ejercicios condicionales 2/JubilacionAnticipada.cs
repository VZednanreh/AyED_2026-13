using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            String genero;
            int edad;
            Console.Write("Ingrese su genero M o F: ");
            genero = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            if (genero == "M" & edad > 65)
            {
                Console.WriteLine("Puede iniciar el tramite");
            }
            else if (genero == "F" & edad > 60)
            {
                Console.WriteLine("Puede iniciar el tramite");
            }
            else
            {
                Console.WriteLine("Tramite no disponible");
            }
        }
    }
}
