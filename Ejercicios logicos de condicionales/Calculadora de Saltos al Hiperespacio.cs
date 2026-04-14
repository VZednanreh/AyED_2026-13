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
            double CombusNecesario;
            double faltante;
            double resto;
            double Distancia;
            double Combustible;
            Console.Write("Ingrese la distancia a recorer: ");
            Distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese la cantidad de combustible disponible: ");
            Combustible = Convert.ToDouble(Console.ReadLine());
            if (Combustible < 0)
            {
                Console.Write("No seas tarado, escribime una cantidad no negativa: ");
                Combustible = Convert.ToDouble(Console.ReadLine());
                CombusNecesario = Distancia * 12;
                faltante = CombusNecesario - Combustible;
                resto = Combustible % CombusNecesario;
                if (resto <= 0)
                {
                    Console.WriteLine("Calculos precisos. Saltando al hiperespacio.");
                }
                else
                {
                    Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + faltante + " Litros.");
                }
            }
            else
            {
                CombusNecesario = Distancia * 12;
                faltante = CombusNecesario - Combustible;
                resto = Combustible % CombusNecesario;
                if (resto <= 0)
                {
                    Console.WriteLine("Calculos precisos. Saltando al hiperespacio.");
                }
                else
                {
                    Console.WriteLine("Peligro: Combustible insuficiente. Faltan " + faltante + " Litros.");
                }
            }
            
        }
    }
}
