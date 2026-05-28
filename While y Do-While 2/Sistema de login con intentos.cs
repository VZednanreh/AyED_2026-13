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
            string UsCorrecto = "valen";
            string ContraCorrecta = "123";
            int intentos = 0;
            while (intentos < 3)
            {
                Console.Write("Ingrese su nombre de usuario: ");
                string UsIngresado = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                string ContraIngresada = Console.ReadLine();
                intentos++;
                if (UsIngresado == UsCorrecto && ContraIngresada == ContraCorrecta)
                {
                    Console.WriteLine("Bienvenido al sistema"); break;
                }
                else
                {
                    int restantes = 3 - intentos;
                    if (restantes > 0)
                    {
                        Console.WriteLine("Datos incorrectos, te quedan " + restantes + " intentos.");
                    }
                }
            }
            if (intentos == 3)
            {
                Console.WriteLine("Cuenta bloqueada por seguridad");
            }
        }
    }
}
