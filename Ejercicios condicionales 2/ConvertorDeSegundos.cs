using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            int tiempo;
            int segundos;
            int Minutos;
            Console.Write("Ingrese una cantidad de segundos");
            tiempo = Convert.ToInt32(Console.ReadLine());
            if (tiempo > 60)
            {
                Minutos = tiempo / 60;
                segundos = tiempo % 60;
                Console.WriteLine(Minutos + "." + segundos + " minutos.");
            }
            else
            {
                Console.WriteLine(tiempo + " segundos.");
            }
        }
    }
}
