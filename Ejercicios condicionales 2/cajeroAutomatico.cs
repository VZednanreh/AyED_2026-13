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
            Double saldo;
            Double retiro;
            Console.Write("Ingrese su saldo actual: ");
            saldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el dinero a retirar: ");
            retiro = Convert.ToDouble(Console.ReadLine());
            Double multiplo = retiro % 1000;
            if (retiro > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else if (retiro <= saldo & multiplo == 0)
            {
                Console.WriteLine("Operacion permitida.");
            }
            else if (multiplo < 0 | multiplo > 0)
            {
                Console.WriteLine("Solo billetes 1000");
            }

        }
    }
}
