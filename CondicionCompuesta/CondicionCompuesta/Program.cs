using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionCompuesta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Bienvenidos al programa de verifición de números ***");
            string line;
            Console.WriteLine("Ingrese el primer número de la serie");
            line = Console.ReadLine();
            int numberOne = int.Parse(line);
            Console.WriteLine("Ingrese el segundo número de la serie");
            line = Console.ReadLine();
            int numberTwo = int.Parse(line);
            Console.WriteLine("Ingrese el tercer número de la serie");
            line = Console.ReadLine();
            int numberThree= int.Parse(line);
            if (numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine(numberOne);
            }
            else
            {
                if (numberTwo > numberThree)
                {
                    Console.WriteLine(numberTwo);
                }
                else
                {
                    Console.WriteLine(numberThree);
                }

            }
            Console.ReadKey();
        }
    }
}
