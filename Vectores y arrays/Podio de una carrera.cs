using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tiempos = new double[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese el tiempo del corredor N°" + (i+1) + ": ");
                tiempos[i] = Convert.ToDouble(Console.ReadLine());
            }
            double mejorTiempo = tiempos[0];
            int mejorPos = 1;

            double peorTiempo = tiempos[0];
            int peorPos = 1;
            for(int i = 0; i < 6; i++)
            {
                if(tiempos[i] < mejorTiempo)
                {
                    mejorTiempo = tiempos[i];
                    mejorPos = i + 1;
                }
                else if(tiempos[i] > peorTiempo)
                {
                    peorTiempo = tiempos[i];
                    peorPos = i + 1;
                }
            }

            Console.WriteLine("Mejor tiempo (Ganador): " + mejorTiempo + " segundos (Corredor N°" + mejorPos + ")");
            Console.WriteLine("Peor tiempo: " + peorTiempo + " segundos (Corredor N°" + peorPos + ")");
        }
    }
}
