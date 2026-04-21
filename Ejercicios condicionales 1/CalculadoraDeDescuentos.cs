using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Double monto;
            Console.Write("Ingrese el monto de tu compra: ");
            monto = Convert.ToDouble(Console.ReadLine());
            Double Descuento = monto * 0.15;
            Double MontoConDescuento = monto - Descuento;
            if (monto > 5000)
            {
                Console.WriteLine("El total a pagar es de " + MontoConDescuento + ".");
            }
            else
            {
                Console.WriteLine("El total a pagar es de " + monto + ".");
            }
        }
    }
}
