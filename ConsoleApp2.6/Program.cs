using System;

namespace ConsoleApp4._6
{
    //4 reqemli eded verilib. Bu ededin evvel 20%-ni ,
    //sonra ise cavabin 10% tap. Alinan cavabin kvadratini tap
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 4600;
            

            if (a>=1000&&a<10000)
            {
                a = a * 0.2;
               double b= a * 0.1;
                double c = a + b;
                c = c * c;

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);


            }
            else
            {
                Console.WriteLine("4 reqemli deyil");
            }
        }
    }
}
