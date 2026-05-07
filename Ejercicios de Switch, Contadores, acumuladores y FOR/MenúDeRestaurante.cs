using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese uno de los siguientes pedidos:");
            Console.WriteLine("1 = Pizza  $11000");
            Console.WriteLine("2 = Sandwich  $4500");
            Console.WriteLine("3 = Hamburguesa  $6500");
            Console.Write("Ingrese el pedido deseado: ");
            string opcion = Console.ReadLine(); 
            switch (opcion)
            {
                case "1": Console.WriteLine("Su pedido fue la pizza y te sale $11000."); break;
                case "2": Console.WriteLine("Su pedido fue el sandwich y te sale $4500.");  break;
                case "3": Console.WriteLine("Su pedido fue la hamburguesa y te sale $6500.");  break;
                default: Console.WriteLine("Su pedido no existe."); break;
            }
        }
    }
}
