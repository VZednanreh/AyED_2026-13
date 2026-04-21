using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double lado1;
            Double lado2;
            Double lado3;
            Console.Write("Ingrese el primer lado del triangulo: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el segundo lado del triangulo: ");
            lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el tercero lado del triangulo: ");
            lado3 = Convert.ToDouble(Console.ReadLine());
            if (lado1 == lado2 & lado1 == lado3)
            {
                Console.WriteLine("El triangulo es equilatero");
            }
            else if (lado1 == lado2 | lado1 == lado3)
            {
                Console.WriteLine("El triangulo es isoceles");
            }
            else
            {
                Console.WriteLine("El triangulo es escaleno");
            }
        }
    }
}
