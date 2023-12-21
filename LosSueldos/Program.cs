using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LosSueldos
{
     class LosSueldos
    {
        private int[] sueldo;
    

        public void Cargar ()
        {
            Console.WriteLine("¿ Cuántos sueldos cargara");
            float count = int.Parse(Console.ReadLine());

            for (int f = 0; f < sueldo.Length; f++)
            {
                Console.Write("Ingrese el sueldo");
                sueldo[f] =  int.Parse(Console.ReadLine());
            }
        }

        public void Print()
        { 
            
        }
        static void Main(string[] args)
        {
            LosSueldos pv = new LosSueldos();
            pv.Cargar();
        }
    }
}
