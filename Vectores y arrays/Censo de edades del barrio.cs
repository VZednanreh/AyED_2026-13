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
            int[] edades = new int[12];
            int menores = 0;
            int adultosMayores = 0;
            int intermedios = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Ingrese la edad del vecino N°" + (i + 1) + ": ");
                edades[i] = int.Parse(Console.ReadLine());
            }

            foreach (int edad in edades)
            {
                if (edad < 18)
                {
                    menores++;
                }
                else if (edad >= 65)
                {
                    adultosMayores++;
                }
                else
                {
                    intermedios++;
                }
            }
            Console.WriteLine("Menores de edad: " + menores);
            Console.WriteLine("Rango intermedio: " + intermedios);
            Console.WriteLine("Adultos mayores: " + adultosMayores);
        }
    }
}
