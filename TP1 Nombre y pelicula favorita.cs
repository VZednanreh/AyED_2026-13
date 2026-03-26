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
            String PelFav;
            String nombre;
            Console.WriteLine("Hola usuario");
            Console.Write("Como te llamas: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Que onda " + nombre);
            Console.Write("¿Cual es tu pelicula favorita? : ");
            PelFav = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " tu pelicula preferida " + PelFav + " Es una porqueria.");
        }
    }
}
