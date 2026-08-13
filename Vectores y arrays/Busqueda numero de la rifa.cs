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
            int[] numerosVendidos = new int[15];
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Ingrese el número vendido " + (i + 1) +": ");
                numerosVendidos[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Ingrese el número que desea consultar: ");
            int consulta = int.Parse(Console.ReadLine());
            int contador = 0;

            for (int i = 0; i < numerosVendidos.Length; i++)
            {
                if (numerosVendidos[i] == consulta)
                {
                    contador++;
                }
            }
            if (contador > 0)
            {
                Console.WriteLine("El número " + consulta + " ya fue VENDIDO.");
            }
            else
            {
                Console.WriteLine("El número " + consulta + " todavía está DISPONIBLE.");
            }
        }
    }
}
