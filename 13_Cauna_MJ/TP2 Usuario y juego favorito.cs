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
            String consola;
            String juegoFav;
            String nombre;
            Console.WriteLine("Hola usuario");
            Console.Write("Como te llamas: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Que onda " + nombre);
            Console.Write("¿Cual es tu juego favorito? : ");
            juegoFav = Console.ReadLine();
            Console.Write("¿En que consola se juega ese juego? : ");
            consola = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " tu juego favorito es " + juegoFav + " y se juega en " + consola);
        }
    }
}
