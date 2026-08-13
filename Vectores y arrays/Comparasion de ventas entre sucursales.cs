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
            double[] sucursal1 = new double[5];
            double[] sucursal2 = new double[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ventas Día " + (i + 1) + ": ");
                sucursal1[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ventas Día " + (i + 1) + ": ");
                sucursal2[i] = double.Parse(Console.ReadLine());
            }
            double totalSucursal1 = 0;
            double totalSucursal2 = 0;
            for (int i = 0; i < 5; i++)
            {
                totalSucursal1 += sucursal1[i];
                totalSucursal2 += sucursal2[i];
                
                if (sucursal1[i] > sucursal2[i])
                {
                    Console.WriteLine("Día " + (i + 1) + ": Vendió más la Sucursal 1 (" + sucursal1[i] + " vs " + sucursal2[i] + ")");
                }
                else if (sucursal2[i] > sucursal1[i])
                {
                    Console.WriteLine("Día " + (i + 1) + ": Vendió más la Sucursal 2 (" + sucursal2[i] + " vs " + sucursal1[i] + ")");
                }
                else
                {
                    Console.WriteLine("Día " + (i + 1) + ": Empate (" + sucursal1[i] + " cada una)");
                }
            }
            Console.WriteLine("Total Sucursal 1: " + totalSucursal1);
            Console.WriteLine("Total Sucursal 2: " + totalSucursal2);

            if (totalSucursal1 > totalSucursal2)
            {
                Console.WriteLine("La primera sucursal tuvo la mayor recaudación total.");
            }
            else if (totalSucursal2 > totalSucursal1)
            {
                Console.WriteLine("La segunda sucursal tuvo la mayor recaudación total.");
            }
            else
            {
                Console.WriteLine("Ambas sucursales recaudaron lo mismo en la semana.");
            }
        }
    }
}
