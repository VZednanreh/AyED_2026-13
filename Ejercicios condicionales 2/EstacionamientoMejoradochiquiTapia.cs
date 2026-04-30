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
            Double DineroParaPagar;
            Double HorasEstacionadas;
            Console.Write("Ingrese las horas estacionadas: ");
            HorasEstacionadas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el monto para pagar: ");
            DineroParaPagar = Convert.ToDouble(Console.ReadLine());
            if (HorasEstacionadas < 1)
            {
                Double PrecioDeEstacionamiento = HorasEstacionadas * 4000;
                Double Faltante = PrecioDeEstacionamiento - DineroParaPagar;
                if (DineroParaPagar < PrecioDeEstacionamiento)
                {
                    Faltante = PrecioDeEstacionamiento - DineroParaPagar;
                    Console.WriteLine("El monto a pagar es de " + PrecioDeEstacionamiento + " tu faltante es de " + Faltante + ".");
                }
                else
                {
                    Double Vuelto = DineroParaPagar - PrecioDeEstacionamiento;
                    Console.WriteLine("El monto a pagar es de " + PrecioDeEstacionamiento + " tu vuelto es de " + Vuelto + ".");
                }
            }
            else if (HorasEstacionadas >= 1)
            {
                Double PrecioDeEstacionamiento = 4000 + (HorasEstacionadas - 1) * 1600;
                Double Faltante = PrecioDeEstacionamiento - DineroParaPagar;
                if (DineroParaPagar < PrecioDeEstacionamiento)
                {
                    Faltante = PrecioDeEstacionamiento - DineroParaPagar;
                    Console.WriteLine("El monto a pagar es de " + PrecioDeEstacionamiento + " tu faltante es de " + Faltante + ".");
                }
                else
                {
                    Double Vuelto = DineroParaPagar - PrecioDeEstacionamiento;
                    Console.WriteLine("El monto a pagar es de " + PrecioDeEstacionamiento + " tu vuelto es de " + Vuelto + ".");
                }
            }

        }
    }
}
