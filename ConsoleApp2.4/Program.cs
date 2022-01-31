using System;

namespace ConsoleApp2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 725;
            double b;

            if (a>=100&&a<1000)
            {
                a = a * 10 + 7;

                b = a * 0.07;

                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                
                Console.WriteLine("3reqemli deyil");
            }
            
        }
    }
}
