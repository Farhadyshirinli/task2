using System;

namespace ConsoleApp2._8
{
//
//2 dene eded verilib.I eded 4 reqemli II eded 7 reqemlidir.
//I ededin 4%-ni tap.
//Sonra II ededin 9% ni tap.
//Sonra Cavalari toplayib 10 %ni tap.
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5612;
            double b = 4863248;

            if (a >= 1000&&a<10000)
            {
                a = a * 0.04;

                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("4reqemli deyil");
            }
            if (b>=1000000&& b<10000000)
            {
                b = b * 0.09;

                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("7reqemli deyil");
            }

            double c = (a + b) * 0.1;
                Console.WriteLine(c); 


        }

    }
}
