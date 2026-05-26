using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroSecreto = 73;
            int maxIntentos = 5;
            int intentosUsados = 0;
            int numero = 0;
            Console.WriteLine("Tenes " + maxIntentos+ " intentos para adivinar el número secreto.");
            while (intentosUsados < maxIntentos)
            {
                intentosUsados++;
                Console.Write("Ingresa tu número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == numeroSecreto)
                {
                    break;
                }

                if (numero < numeroSecreto)
                {
                    Console.WriteLine("El número es mayor.");
                }
                else
                {
                    Console.WriteLine("El número es menor.");
                }
            }
            if (numero == numeroSecreto)
            {
                Console.WriteLine("Felicidades. Ganaste el juego.");
                Console.WriteLine("Adivinaste el número secreto " + numeroSecreto + " en " + intentosUsados + " intentos.");
            }
            else
            {
                Console.WriteLine("Perdiste. Te quedaste sin intentos.");
                Console.WriteLine("El número secreto era: " + numeroSecreto);
            }
        }
    }
}
