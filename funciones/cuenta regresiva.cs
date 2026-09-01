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
            int numero;
            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine(numero);
            ContRegre(numero);
        }
        static void ContRegre(int num)
        {
            while (num != 1)
            {
                Console.WriteLine(num - 1);
                num--;
            }
        }
    }
}
