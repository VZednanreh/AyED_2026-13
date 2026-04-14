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
            double NivelJedi;
            Console.Write("Ingrese su nivel de midiclorianos : ");
            NivelJedi = Convert.ToDouble(Console.ReadLine());
            if (NivelJedi > 15000)
            {
                Console.WriteLine("Potencial de maestro jedi detectado. Avisar al consejo.");
            }
            else if(NivelJedi < 15000 & NivelJedi > 5000)
            {
                Console.WriteLine("Aceptable para entrenamiento Padawan.");
            }
            else
            {
                Console.WriteLine("No posee sensibilidad a la Fuerza.");
            }
        }
    }
}
