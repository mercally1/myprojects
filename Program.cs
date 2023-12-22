using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioconvectores
{
     class Prueba16
    {
        private string[] name;
        private int[] notes;

        public void Load()
        {
            name = new string[5];
            notes = new int[5];
            Console.WriteLine("Load of name and nota");
            for (int f = 0; f < name.Length; f++)
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                name[f] = Console.ReadLine();
                Console.WriteLine("Ingrese la nota del alumno");
                notes[f] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

        public void Save()
        {
            for (int k = 0; k < name.Length; k++)   
            {
                for(int f = 0;f < notes.Length - 1 - k; f++)
                {
                    if (notes[f] < notes[f +1])
                    {
                        int auxnota = notes[f];
                        notes[f] = notes[f +1];
                        notes[f +1] = auxnota;

                        string auxname = name[f];
                        name[f]= name[f +1];
                        name[f+1] = auxname;
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Nombre de Alumnos y notas de mayor a menor");
            for (int k = 0;k < name.Length; k++)
            {
                Console.WriteLine(name[k] + " - " + notes[k]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Prueba16 prueba16 = new Prueba16();
            prueba16.Load();
            prueba16.Save();
            prueba16.Print();

        }
    }
}
