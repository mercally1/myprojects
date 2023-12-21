using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumaYmulti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**// Bienvenido a tu programa //**");
            string line;
            int number =0;

            while (number >=3)
            {
                number++;
                Console.WriteLine("ingrese el numero");
                line = Console.ReadLine();
                number = int.Parse(line);
                
            }
       /*     { 
                Console.WriteLine("ingrese el numero");
                line = Console.ReadLine();
                number = int.Parse(line);
                number++; 
            } 
            while (number >=3);*/
            if (number == number && number == number) 
            {
                int suma = number + number;
                Console.WriteLine("El resultado de la suma es:");
                Console.WriteLine(suma);
                int producto  = suma * number;
                Console.WriteLine("El resultado del producto es:");
                Console.WriteLine(producto);
            }
            else
            {
                Console.WriteLine("Los números son desinguales");
            }
            Console.ReadKey();
        }
    }
}
