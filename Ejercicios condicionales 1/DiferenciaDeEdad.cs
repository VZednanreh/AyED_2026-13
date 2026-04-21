using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int EdadPrimerHermano;
            int EdadSegundoHermano;
            Console.Write("Ingrese la edad del primer hermano: ");
            EdadPrimerHermano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la edad del segundo hermano: ");
            EdadSegundoHermano = Convert.ToInt32(Console.ReadLine());
            int hermanoMayor = EdadPrimerHermano - EdadSegundoHermano;
            if (hermanoMayor < 0)
            {
                Console.WriteLine("El hermano mayor es el segundo hermano.");
            }
            else if (hermanoMayor > 0)
            {
                Console.WriteLine("El hermano mayor es el primer hermano.");
            }
            if (hermanoMayor == 0)
            {
                Console.WriteLine("Los hermanos tienen la misma edad.");
            }
        }
    }
}
