using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Double presupuesto;
            Double CostoDeObra;
            Console.Write("Ingrese el presupuesto disponible para la obra: ");
            presupuesto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el costo de los materiales: ");
            CostoDeObra = Convert.ToDouble(Console.ReadLine());
            Double faltante = CostoDeObra - presupuesto;
            if (presupuesto < CostoDeObra)
            {
                Console.WriteLine("Dinero faltante: " + faltante + ".");
            }
            else
            {
                Console.WriteLine("Dinero suficiente");
            }
        }
    }
}
