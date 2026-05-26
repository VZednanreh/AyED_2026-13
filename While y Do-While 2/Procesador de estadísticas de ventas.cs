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
            int acumulador = 0;
            int totalVentas = 0;
            int ventaMasAlta = 0;
            string respuesta = "";
            while (respuesta != "N" & respuesta != "n")
            {
                Console.Write("Ingrese el monto de la venta: ");
                int montoVenta = int.Parse(Console.ReadLine());
                acumulador += montoVenta;
                totalVentas++;
                if (montoVenta > ventaMasAlta)
                {
                    ventaMasAlta = montoVenta;
                }
                Console.Write("¿Desea continuar ingresando más ventas? (S/N): ");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("Total recaudado: " + acumulador);
            Console.WriteLine("Cantidad total de ventas realizadas: " + totalVentas);
            Console.WriteLine("Monto de la venta más alta: " +ventaMasAlta);
        }
    }
}
