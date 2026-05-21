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
            Console.Write("ingrese el dinero a para guardar: ");
            int numero = int.Parse(Console.ReadLine());
            int alcancia= 0;
            do
            {
                if (numero > 0)
                {
                    alcancia += numero;
                    Console.Write("ingrese el dinero a para guardar: ");
                    numero = int.Parse(Console.ReadLine());
                }
            } while (numero > 0);
            Console.WriteLine("El total guardado fue de: " + alcancia);
        }
    }
}
