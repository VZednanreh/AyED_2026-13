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
            double acumuladorGastos = 0;
            double acumuladorTotalGastos;
            double gasto;
            double contador = 0;
            for (int x = 1; x <= 5; x++)
            {
                Console.Write("Ingrese el gasto N°" + x + ": ");
                gasto = double.Parse(Console.ReadLine());
                acumuladorGastos = acumuladorGastos + gasto;
                if (gasto > 500)
                {
                    contador++;
                }
                acumuladorTotalGastos = acumuladorGastos;
                if (x == 5)
                {
                    Console.WriteLine("la suma de todos los gastos de hoy fueron de " + acumuladorTotalGastos + " y hubo " + contador + " gastos mayores a $500.");
                }
                else
                {
                    Console.WriteLine("la suma de todos los gastos de hoy por ahora es de " + acumuladorTotalGastos + " y hubo " + contador + " gastos mayores a $500.");
                }
            }
        }
    }
}
