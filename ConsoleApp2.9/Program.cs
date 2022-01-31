using System;

namespace ConsoleApp2._9
{
    internal class Program
    {

        //3 dene 6 reqemli eded verilib.Her birinin 10 faizini tapib neticeleri topla.Alinan cavabin 10% tap.

        static void Main(string[] args)
        {

            double a = 463821;
            double b = 715643;
            double c = 864259;

            if (a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000)
            {
                a = a * 0.1;
                b = b * 0.1;
                c = c * 0.1;

                double d = (a + b + c)*0.1;

                Console.WriteLine(d);   
            }
            else
            {
                Console.WriteLine("ededler 6 reqemli deyil!");
            }

        }
    }
}
