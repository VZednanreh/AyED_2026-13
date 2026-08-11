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
            double[] temperaturas = new double[7];
            string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Ingrese la temperatura máxima del " + dias[i] + ": ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
                
            }
            double max = temperaturas[0];
            double min = temperaturas[0];
            double suma = 0;
            foreach (double temp in temperaturas)
            {
                if (temp > max) max = temp;
                if (temp < min) min = temp;
                suma += temp;
            }

            double promedio = suma / 7;
            Console.WriteLine("Temperatura más alta: " + max + ".");
            Console.WriteLine("Temperatura más baja: " + min + ".");
            Console.WriteLine("Promedio semanal: " + promedio + "."); 
        }
    }
}
