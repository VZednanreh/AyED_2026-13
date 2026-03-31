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
            Double a, b;
            Console.Write("Ingrese un valor entero: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese otro valor entero: ");
            b = Convert.ToDouble(Console.ReadLine());
            Double resulSuma = a + b;
            Double resulResta = a - b;
            Double resulMulti = a * b;
            Double resulDiv = a / b;

            Console.WriteLine("la suma de " + a + " y " + b + " da como resultado " + resulSuma + ".");
            Console.WriteLine("la resta de " + a + " y " + b + " da como resultado " + resulResta + ".");
            Console.WriteLine("la multiplicación de " + a + " y " + b + " da como resultado " + resulMulti + ".");
            Console.WriteLine("la división de " + a + " y " + b + " da como resultado " + resulDiv + ".");
        }
    }
}
