using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaymultiplica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Bienvenido a tu programa suma y multiplica");
            string line;
            Console.WriteLine("Introduca el primer valor:");
            line = Console.ReadLine();
            int numberOne = int.Parse(line);
            Console.WriteLine("Introduca el valor dos:");
            line = Console.ReadLine();
            int numberTwo = int.Parse(line);
            Console.WriteLine("Introduca el valor tres");
            line = Console.ReadLine();  
            int numberThree = int.Parse(line);
            if (numberOne == numberTwo && numberOne == numberThree)
                 {
                int suma = numberOne + numberTwo;
                Console.WriteLine("La suma de los primeros dos números es:");
                Console.WriteLine(suma);
                int producto = suma * numberThree;
                Console.WriteLine("El producto de la suma anterior mas el tercer numero es:");
                Console.WriteLine(producto);
                 }
            else
            {
                Console.WriteLine("Estos numeros son desiguales");
            }

            Console.ReadKey();
        }
    }
}
