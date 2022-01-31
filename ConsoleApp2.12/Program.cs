using System;

namespace ConsoleApp2._12
{
    internal class Program
    {

                          //        4 dene 6 reqemli eded verilib.Ededlerin hamisinin 10 faizini tap ve topla.Sonra hamisinin 15 faizini tap ve topla.
                          //Sonra yekunda alinanlar iki cavabi vur biri birine. Alinan neticenin evvel 10% tap sonra ise hemin cavabin 11% tap.
        static void Main(string[] args)
        {
            int a = 427940;
            int b = 452068;
            int c = 351279;
            int d = 742563;

            double e = (a + b + c + d) * 0.1;
            double f = e * 0.15;

            double g = e * f*0.1;
            double h = g * 0.11;
            Console.WriteLine(g);
            Console.WriteLine(h);

        }
    }
}
