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
            Console.Write("Ingrese la cantidad de facturas producidas hoy: ");
            int ProduccionHoy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese las facturas vendidas: ");
            Double FacturasVendidas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el precio de la docena de facturas: ");
            Double PrecioDeDocena = Convert.ToDouble(Console.ReadLine());
            int Docenas = ProduccionHoy / 12;
            Double FacturasSobrantes = ProduccionHoy - FacturasVendidas;
            Double RecaudacionHoy = Docenas * PrecioDeDocena;
            Console.WriteLine("El dinero total recaudado es de " + RecaudacionHoy + ".");
            Console.WriteLine("Las facturas que sobraron fueron " + FacturasSobrantes + ".");
            if (FacturasSobrantes <= 6)
            {
                Console.WriteLine("Produccion eficiente.");
            }
            else if (FacturasSobrantes >= 6)
            {
                Console.WriteLine("Alerta: Exceso de produccion.");
            }
        }
    }
}
