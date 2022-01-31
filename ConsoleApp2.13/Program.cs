using System;

namespace ConsoleApp2._13
{
//    5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5% tap ,neticeleri vur bir birine.
//Sonra 3 reqemli ededlerin 3% tap , neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10%-ni tapib topla.
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 14569;
            double b = 47850;
            double c = 34628;
            double d = 780;
            double e = 458;

            a = a * 0.05;
            b = b * 0.05;
            c = c * 0.05;
            d = d * 0.03;
            e = e * 0.03;

            double a1 = (a + b + c)*0.1;
            double a2 = (d + e)*0.1;

            double a3 = a1 + a2;

            Console.WriteLine(a3);







        }
    }
}
