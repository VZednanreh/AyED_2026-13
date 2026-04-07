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
            int TiempoEstacionado;

            int MinutosEstacionados;

            int HorasEstacionadas;

            Double CostoTotal;

            Double IVA = 0.21;

            Double CostoConIVA;

            Double CostoFinal;

            Console.Write("Ingrese los minutos que estuvo estacionado: ");

            TiempoEstacionado = Convert.ToInt32(Console.ReadLine());

            HorasEstacionadas = TiempoEstacionado / 60;

            MinutosEstacionados = TiempoEstacionado % 60;

            CostoTotal = HorasEstacionadas * 6000 + MinutosEstacionados * 150;

            CostoConIVA = CostoTotal * IVA;

            CostoFinal = CostoConIVA + CostoTotal;

            Console.WriteLine("El monto final a pagar es " + CostoFinal + ".");

        }
    }
}
