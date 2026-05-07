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
            Console.WriteLine("Ingrese uno de los siguientes idiomas:");
            Console.WriteLine("1 = ingles");
            Console.WriteLine("2 = Frances");
            Console.WriteLine("3 = aleman");
            Console.Write("Ingrese el idioma deseado: ");
            string opcion = Console.ReadLine(); 
            switch (opcion)
            {
                case "1": Console.WriteLine("Hello."); break;
                case "2": Console.WriteLine("Salut.");  break;
                case "3": Console.WriteLine("Hallo.");  break;
                default: Console.WriteLine("Su eleccion no existe."); break;
            }
        }
    }
}
