using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace archivoPrueba
{
    internal class buclewhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The bucles for");
            Console.WriteLine();

            for (int row = 0; row < 11;  row++) 
            {
                Console.WriteLine($"the row is {row}");
            }
            

            for (char column = 'a'; column < 'k' ; column++)
            {
                Console.WriteLine($"the column is {column}");
            }
          
             

            for (int row = 1; row < 11; row++) 
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row},{column})") ;
                    Console.WriteLine();// this is a jumpline
                }
            }

            Console.WriteLine("The bucles while");
            Console.WriteLine();

            
            //the bucle  while 
            int counter = 10;
               while (counter < 10)
             {
                 Console.WriteLine($"Hello world, the counter {counter}");
                 counter++;
             }

            Console.WriteLine("The bucles do");
            Console.WriteLine();

            //the bucle do while 

            do
             {
                 Console.WriteLine($"Hello world, the counter {counter}");
                 counter++;
             } while (counter < 10);


            Console.WriteLine("The bucles for with decrement"); 
            Console.WriteLine();


            // loop for doing decrement

            for (int i = 10; i > 0; i--)
            {
               Console.WriteLine($"Hello world, the counter {i}  ");
             }

            Console.WriteLine("The bucles for with increment");
            Console.WriteLine();

            //  bucle for doing increment

            for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine($"Hello world, the counter {i}  ");
             }

             

            Console.ReadKey();

        }
    }
}
