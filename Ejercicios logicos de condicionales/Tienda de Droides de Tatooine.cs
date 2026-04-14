using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de droides queridos: ");
            Double CantDroides = Convert.ToDouble(Console.ReadLine());
            Double precio = CantDroides * 2000;
            if (CantDroides >= 3)
            {
                Double precioDescuento = precio * 0.2;
                Double ahorro = precioDescuento;
                Double PrecioFinal = precio - precioDescuento;
                Console.WriteLine("El precio original era " + precio + " Pero usted obtiene un descuento por comprar 3 Droides, su ahorro fue de " + ahorro + " el precio final es de " + PrecioFinal + ".");
            }
            else
            {
                Console.WriteLine("El precio final es de " + precio + ".");
            }
        }
    }
}
