using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nota: ");
            int nota = int.Parse(Console.ReadLine());
            do
            {
                if (nota < 1 || nota > 10)
                {
                    Console.WriteLine("ERROR: su nota ingresada no esta entre 1 y 10.");
                    Console.Write("ingrese su nota devuelta: ");
                    nota = int.Parse(Console.ReadLine());
                }
            } while (nota < 1 || nota > 10);
            Console.WriteLine("nota: " + nota);
        }
    }
}
