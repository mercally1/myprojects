using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVector1
    
{
     class PruebaVector1
    {
        private int[] sueldos;
        public void Cargar()
        {
            sueldos = new int[5];
            for (int f = 0; f < 5; f++) 
            {
                Console.WriteLine("Ingrese valor del componentes");
                sueldos[f] = int.Parse(Console.ReadLine());
            }
        }
        public void Imprimir()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            PruebaVector1 pv = new PruebaVector1();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
    