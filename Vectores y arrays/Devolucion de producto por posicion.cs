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
            int[] productos = new int[10];
            double dinero = 0;
            for(int i = 0; i<10; i++)
            {
                Console.Write("Ingrese el precio del producto N°" + (i+1) + ": ");
                productos[i] = int.Parse(Console.ReadLine());
                
            }
            foreach(int plata in productos)
            {
                dinero += plata;
            }
            
            Console.WriteLine("Ingrese el numero de la lista del producto que quiere devolver: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("El precio a devolver es de " + productos[numero-1] + ".");
            double resultado = dinero - productos[numero-1];
            Console.WriteLine("El nuevo total es de: " + resultado);
            
        }
    }
}
