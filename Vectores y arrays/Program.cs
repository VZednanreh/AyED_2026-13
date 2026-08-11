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
            int cont_aprob = 0;
            int cont_desaprob = 0;
            double[] notas = new double[10];
            double[] alumnos = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese la nota del alumno n°" + alumnos[i] + ": ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            foreach(double nota in alumnos)
            {
                if (nota >= 6)
                {
                    cont_aprob++;
                    suma = suma + nota;
                }
                else if (nota < 6)
                {
                    cont_desaprob++;
                    suma= suma + nota;
                }
            }
            double promedio = suma / 7;
            Console.WriteLine("Aprobaron: " + cont_aprob + ".");
            Console.WriteLine("Desaprobaron: " + cont_desaprob + ".");
            Console.WriteLine("Promedio de las notas: " + promedio + ".");
        }
    }
}
