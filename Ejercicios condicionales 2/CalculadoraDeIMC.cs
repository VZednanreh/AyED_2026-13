using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Double peso;
            Double altura;
            Console.Write("Ingrese su altura en centimetros: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese su peso en kilogramos: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Double IMC = peso / (altura * altura);
            if (IMC > 25)
            {
                Console.WriteLine("Sobrepeso.");
            }
            else
            {
                Console.WriteLine("Rango normal.");
            }
        }
    }
}
