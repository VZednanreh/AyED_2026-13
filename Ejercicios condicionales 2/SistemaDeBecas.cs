using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Distancia;
            Double promedio;
            Console.Write("Ingrese su promedio de notas: ");
            promedio = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese su distancia de su casa a la escuela: ");
            Distancia = Convert.ToDouble(Console.ReadLine());
            if (promedio > 8 | Distancia > 50)
            {
                Console.WriteLine("Beca consedida.");
            }
            else
            {
                Console.WriteLine("Beca rechazada.");
            }
        }
    }
}
