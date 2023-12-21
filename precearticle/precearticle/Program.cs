using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace precearticle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float price, import;
            int amount;
            string line;
            Console.Write("Ingrese el precio por favor:");
            line = Console.ReadLine();
            price = float.Parse(line);
            Console.Write("Ingrese la cantidad de producto");
            line = Console.ReadLine();
            amount= int.Parse(line);
            import = price + amount;
            Console.Write("El importe es:");
            Console.WriteLine(import);
            Console.ReadKey();

        }
    }
}
