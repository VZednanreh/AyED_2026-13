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
            int saldo = 10000;
            int opcion = 0;

            while (opcion != 4)
            {
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Ver saldo actual");
                Console.WriteLine("4. Salir");
                Console.Write("Ingrese su opcion ideal: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad a depositar: ");
                        int deposito = int.Parse(Console.ReadLine());

                        if (deposito > 0)
                        {
                            saldo += deposito;
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida. Debe ser mayor a 0.");
                        }
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad a retirar: ");
                        int retiro = int.Parse(Console.ReadLine());

                        if (retiro > 0)
                        {
                            if (retiro <= saldo)
                            {
                                saldo -= retiro;
                            }
                            else
                            {
                                Console.WriteLine("Fondos insuficientes.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cantidad inválida. Debe ser mayor a 0.");
                        }
                        break;
                    case 3: Console.WriteLine("Su saldo es de " + saldo); break;
                    case 4: Console.WriteLine("Cerrando..."); break;
                    default: Console.WriteLine("Su opcion no existe."); break;
                }
            }
        }
    }
}
