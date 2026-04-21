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
            String nombre;
            String contraseña;
            Console.Write("Ingrese su nombre de usuario: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su contraseña: ");
            contraseña = Console.ReadLine();
            if (nombre == "admin" & contraseña == "1234")
            {
                Console.WriteLine("Acceso consedido.");
            }
            else
            {
                Console.WriteLine("Error de credenciales.");
            }
        }
    }
}
