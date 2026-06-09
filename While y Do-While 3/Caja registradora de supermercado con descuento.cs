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
            double subtotal = 0;
            double precio = -1;
            Console.WriteLine("Ingrese los precios de los productos. Ingrese 0 para finalizar.");

            while (precio != 0)
            {
                Console.Write("Precio del producto: ");
                precio = Convert.ToDouble(Console.ReadLine());

                if (precio < 0)
                {
                    Console.WriteLine("Por favor, ingrese un precio mayor o igual a 0.");
                }
                else if (precio > 0)
                {
                    subtotal += precio;
                }
            }
            double descuento = 0;
            if (subtotal > 15000)
            {
                descuento = subtotal * 0.10;
            }
            double totalFinal = subtotal - descuento;
            Console.WriteLine("Subtotal: " + subtotal);

            if (descuento > 0)
            {
                Console.WriteLine("Descuento (10%): " + descuento);
            }
            else
            {
                Console.WriteLine("No tienes el descuento 10% porque no superaste los 15000");
            }
            Console.WriteLine("Total a pagar: " + totalFinal);
        }
    }
}
