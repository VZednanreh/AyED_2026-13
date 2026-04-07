using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PesoNave;
            Double Diferencia;
            Console.Write("Ingrese el peso de la nave capitan: ");
            PesoNave = Convert.ToDouble(Console.ReadLine());
            if (PesoNave <= 5000)
            {
                Console.WriteLine("Listo para el despegue mi capitan.");
            }
            else
            {
                Diferencia = PesoNave - 5000;
                Console.WriteLine("Alerta: Se debe descargar " + Diferencia + "kg para poder despegar.");
            }

        }
    }
}
