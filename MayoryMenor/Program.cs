using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoryMenor
{
    class Prueba11
    {
        private string[] names;
        private float[] salary;

        public void ValuesLoad()
        {
            names = new string[5];
            salary = new float[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Introduce the employer name please: ");
                Console.Write("Introduce the salary please: ");
                salary[i] = float.Parse(Console.ReadLine());
            }
        }

        public void SalaryMayor()
        {
            float plus;
            plus = salary[0];
            int pos = 0;
            for (int i = 1; i < names.Length; i++)
            {
                if (salary[i] > plus)
                {
                    plus = salary[i];
                    pos = i;
                }
            }
                Console.Write("The employer :" + names[pos]);
                Console.Write("have the salary:" + salary);
                Console.ReadKey();
        }
    }

        static void Main (string[] args)
        {
            Prueba11 pv = new Prueba11();
            pv.ValuesLoad();
            pv.SalaryMayor();
        }
}