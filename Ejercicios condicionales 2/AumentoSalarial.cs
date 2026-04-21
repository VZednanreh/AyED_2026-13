using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Double antiguedad;
            Double sueldo;
            Console.Write("Ingrese su sueldo actual: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese su antiguedad en la empresa: ");
            antiguedad = Convert.ToDouble(Console.ReadLine());
            Double Incremento;
            if (antiguedad > 10)
            {
                Incremento = sueldo * 0.20;
                Double SueldoNuevo = sueldo + Incremento;
                Console.WriteLine("Su sueldo nuevo es de " + SueldoNuevo + ".");
            }
            else
            {
                Incremento = sueldo * 0.05;
                Double SueldoNuevo = sueldo + Incremento;
                Console.WriteLine("Su sueldo nuevo es de " + SueldoNuevo + ".");
            }
        }
    }
}
