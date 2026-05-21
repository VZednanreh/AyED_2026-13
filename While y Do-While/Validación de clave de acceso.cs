using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la contraseña: ");
            string codigo = Console.ReadLine();
            string contraseña;
            do
            {
            Console.Write("ingrese la contraseña: ");
            contraseña = Console.ReadLine();
               if (contraseña != codigo)
               {
                   Console.WriteLine("Esta mal");
               }
            }while (contraseña != codigo);
            Console.WriteLine("Constraseña valida.");
        }
    }
}
