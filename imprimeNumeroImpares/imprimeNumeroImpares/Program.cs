using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imprimeNumeroImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/* Bienvenido a tu programa ' muestra todos los números impares'");
            //int number; esta variable esta  inicializo en la linea 18
            string linea;
            Console.WriteLine("Introduce un numero cualquiera ");
            int number = int.Parse(Console.ReadLine());

            number = number + 1 / number;
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
