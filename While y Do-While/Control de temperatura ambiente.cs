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
            Console.Write("Ingrese la temperatura actual: ");
            int temperatura = int.Parse(Console.ReadLine());
            int ContTemperatura = temperatura;
            while (ContTemperatura > 24)
            {
                Console.WriteLine("Enfriando....");
                if (ContTemperatura == 25)
                {
                    ContTemperatura--;
                    Console.WriteLine("Temperatura actual: " + ContTemperatura);
                }
                else
                {
                    ContTemperatura--;
                    ContTemperatura--;

                    Console.WriteLine("Temperatura actual: " + ContTemperatura);
                }
            }
            Console.WriteLine("Temperatura ideal alcanzada.");
        }
    }
}
