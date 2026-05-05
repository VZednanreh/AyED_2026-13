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
            double acumuladorTemp;
            double temperatura;
            double contador = 0;
            for (int x= 1; x <= 7; x++)
            {
                Console.Write("Ingrese la temperatura del dia " + x + ".");
                temperatura = double.Parse(Console.ReadLine());
                acumuladorTemp = 0;
                acumuladorTemp = acumuladorTemp + temperatura;
                if (temperatura < 0)
                {
                    contador++;
                }
            }
            Console.WriteLine("la suma de todas las temperaturas de cada dia es de " + acumuladorTemp + " y hubo " + contador +);
            //Console.Write("Ingrese la temperatura del dia " + x + ".");
            //temperatura = double.Parse(Console.ReadLine());
            //double acumuladorTemp = 0;
            //acumuladorTemp = acumuladorTemp + temperatura;
            //if (temperatura < 0)
            //{
            //    contador++;
            //}
        }
    }
}
