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
            int cont_aprob = 0;
            int cont_desaprob = 0;
            double[] notas = new double[10];
            
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingrese la nota del alumno n°" + (i + 1) + ": ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            double suma = 0;
            foreach (double nota in notas)
            {
                suma += nota;

                if (nota >= 6)
                {
                    cont_aprob++;
                }
                else
                {
                    cont_desaprob++;
                }
            }
            double promedio = suma / notas.Length;
            Console.WriteLine("Aprobaron: " + cont_aprob + ".");
            Console.WriteLine("Desaprobaron: " + cont_desaprob + ".");
            Console.WriteLine("Promedio de las notas: " + promedio + ".");
            
        }
    }
}
