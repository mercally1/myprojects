using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkWithStrings();
            void WorkWithStrings()
            {
                List<string> names = ["<name>", "Ana", "felipe"];
                foreach (var name in names)
                {
                    Console.WriteLine($"hello{name.ToUpper()}!");


                    names.Add("Maria");
                    names.Add("Bill");
                    names.Remove("Ana");
                    foreach (var name in names)
                    {
                        Console.WriteLine($"Hello {name.ToUpper()}");
                    }
                }
            }
        }
    }
}
