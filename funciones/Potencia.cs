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
            Potencia();
        }

        static void Potencia()
        {
            int Base;
            int potencia;
            Console.Write("Ingrese una base:");
            Base = int.Parse(Console.ReadLine());
            Console.Write("Ingrese una potencia:");
            potencia = int.Parse(Console.ReadLine());
            int contador = 1;
            int resultado = Base;

            while (contador < potencia)
            {

                resultado = resultado * Base;

                contador++;
            }
            Console.WriteLine(resultado);

        }
    }
}
