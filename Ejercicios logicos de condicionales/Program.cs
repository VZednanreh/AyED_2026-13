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
            Console.WriteLine("A. Lo devuelves al templo. B.Lo vendes por créditos. C.Lo usas para construir un arma roja.");
            Console.Write("Encuentras un cristal Kyber perdido. ¿Qué haces ?: ");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            if (eleccion == 1)
            {
                Console.WriteLine("El camino del Jedi sigue.");
            }
            else if (eleccion == 2)
            {
                Console.WriteLine("Un cazarrecompensas eres.");
            }
            else if (eleccion == 3)
            {
                Console.WriteLine("El Lado Oscuro se apodera de ti.");
            }
        }
    }
}
