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
            Double num1;
            Double num2;
            Double num3;
            Console.Write("Ingrese un numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese otro numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese un ultimo numero: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            if (num1 > num2 & num1 > num3)
            {
                Double mayor = num1;
                Console.WriteLine("El numero mayor es " + mayor + ".");
            }
            else if (num2 > num1 & num2 > num3)
            {
                Double mayor = num2;
                Console.WriteLine("El numero mayor es " + mayor + ".");
            }
            else if (num3 > num1 & num3 > num2)
            {
                Double mayor = num3;
                Console.WriteLine("El numero mayor es " + mayor + ".");
            }
        }
    }
}
