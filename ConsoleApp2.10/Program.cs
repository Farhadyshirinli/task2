using System;

namespace ConsoleApp2._10
{
    internal class Program
    {
//        3 dene 4 reqemli eded verilib.I ededin 1%-ni, II ededin 2% , III ededin 3 % tap.
//Neticeleri bir birinden cix.Alinan cavabin ustune III ededin 7% faizini gel
        static void Main(string[] args)
        {
            double a = 4560;
            double b = 9670;
            double c = 2870;

            if (a >= 1000 && a < 10000 && b >= 1000 && b < 10000 && c >= 1000 && c < 10000) 
            {
                a = a * 0.01;
                b = b * 0.2;
                c = c * 0.3;

                double d = (c - b - a) + (c*0.07);

                Console.WriteLine(d);
            }

            else
            {
                Console.WriteLine("ededler 4 reqemli deyildir!");
            }
        }
    }
}
