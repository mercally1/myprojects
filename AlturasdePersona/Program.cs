using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlturadePersona
{
     class AlturadePersona
    {
        private float[] altura;
        private float promedio;

        public void Cargar()
        {
            altura = new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona:");
                altura[f] = float.Parse(Console.ReadLine());
            }
        }

        public void CalcularPromedio()
        {
            float suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + altura[f];
            }
            promedio = suma / 5;
            Console.WriteLine("Promedio de altura es :" + promedio);
        }

        public void MayoreMemores ()
        {
            int may, men;
            may = 0;
            men = 0;
            for (int f = 0;f < 5; f++)
            {
                if (altura[f] > promedio) 
                {
                    may++;
                }
                else
                {
                    if (altura[f] < promedio)
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("La cantidad de personas mayores al promedio es:" + may);
            Console.WriteLine("La cantidad de personas mayores al promedio es:" + men);
            Console.ReadKey();
        }

        static void Main(String[] args)
        {
            AlturadePersona pv = new AlturadePersona();
            pv.Cargar();
            pv.CalcularPromedio();
            pv.MayoreMemores();
        }
     }
}
