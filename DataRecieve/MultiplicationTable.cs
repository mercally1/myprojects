using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DataRecieve
{
    internal class MultiplicationTable
    {
        public void CargarValor()
        {
            int valor;
            do
            {
                Console.Write("Ingrese un valor para mostrar en la tabla de multiplicar ");
                valor = int .Parse(Console.ReadLine());
                if ( valor != -1)
                {
                    Calcular(valor);
                }
            } while (valor != -1);
        }
        public void Calcular(int v)
        {
            for (int f = v; f <= v * 10; f = f+v )
            {
                Console.Write(f + " - ");
            }
            Console.WriteLine();
         //Console.ReadKey();
        }
        static void Main(string[] args)
        {
            MultiplicationTable tm = new MultiplicationTable();
            tm.CargarValor ();
        }
    }
}
