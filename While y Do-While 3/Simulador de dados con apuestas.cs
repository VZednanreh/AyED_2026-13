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
            int creditos = 100;
            int apuesta;
            Console.WriteLine("Comienzas con " + creditos + " créditos.");
            do
            {
                Console.WriteLine("Saldo actual: " + creditos + " créditos.");
                Console.Write("¿Cuánto deseas apostar? Introduce 0 para retirarte: ");

                apuesta = int.Parse(Console.ReadLine());

                if (apuesta == 0)
                {
                    Console.WriteLine("Te has retirado del juego."); break;
                }

                if (apuesta < 0 || apuesta > creditos)
                {
                    Console.WriteLine("Apuesta inválida.");
                }
                else
                {
                    Console.Write("Introduce el resultado del dado 1 (1 al 6): ");
                    int dado1 = int.Parse(Console.ReadLine());

                    Console.Write("Introduce el resultado del dado 2 (1 al 6): ");
                    int dado2 = int.Parse(Console.ReadLine());

                    if (dado1 < 1 || dado1 > 6 || dado2 < 1 || dado2 > 6)
                    {
                        Console.WriteLine("Dados inválidos.");
                    }
                    else
                    {
                        int suma = dado1 + dado2;
                        Console.WriteLine("La suma de los dados es: " + suma);

                        if (suma == 7 || suma == 11)
                        {
                            int ganancia = apuesta * 2;
                            creditos += ganancia;
                            Console.WriteLine("Ganaste Recibes +" + ganancia + " créditos.");
                        }
                        else
                        {
                            creditos -= apuesta;
                            Console.WriteLine("Perdiste " + apuesta + " créditos.");
                        }

                        if (creditos <= 0)
                        {
                            Console.WriteLine("Sin fondos.");
                        }
                    }
                }

            } while (creditos > 0 && apuesta != 0);
            Console.WriteLine("Juego terminado. Saldo final: " + creditos + " créditos.");
        }
    }
}
