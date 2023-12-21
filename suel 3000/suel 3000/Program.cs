using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suel_3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salary;
            string line;
            Console.Write("Ingrese el salario");
            line = Console.ReadLine();
            salary = float.Parse(line);
            if (salary > 3000)
            {
                Console.Write("esta persona debe abonar a los impuestos");
            }
            else {
                Console.Write(" Esta persona no paga impuesto ");
            }
            Console.ReadKey();
        }
    }
}
