using System;

namespace ConsoleApp2._15
{

//     7 dene eded verilib.Bunlardan 2 denesi 3 reqemlidir. 2 denesi 4 reqemlidir. 2 denesi 5 reqemlidir.1 denesi ise 6 reqemlidir.
       //3 reqemli ededleri topla , sonra bunlarin ustune gel 4 reqemli ededlerin bir birine vurulmasindan alinan cavabi.
       //Sonra neticenin axirina 7 reqemini artir.Sonra cavabin ustune gel 5 reqemli ededlerin cemini.
       //Sonra neticeden cix 3 reqemli ededlerin bir birine vurulmasindan alinan cavabin axirina 1 artirilmish variantini.
       //Sonra alinan cavabin ustune gel 6 reqemli ededi.
       //Sonra alinan cavabdan cix 3 reqemli ve 4 reqemli ededlerin cemini.
       //Sonra alinan cavabin 18% -ni sonra 3%-ni sonra 1% tap.
       //Sonra alinan cavabin ustune 5 reqemli ededlerin cemini gel.
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 450;
            int b = 782;

            int c = 4580;
            int d = 6958;

            int e = 98560;
            int f = 14576;

            int g = 461379;

            int a1 = a + b + (c * d); 

             a1 = a1 * 10 + 7; //318688727
            a1 = a1 + e + f; //318801863

            int a2 = (a * b) * 10 + 1;
            a1 = a1 - a2;
            a1 = a1 + g;

            a1=a1-(a+b+c+d);

            double a5 = a1 * 0.18;

            double a3 = a1 * 0.03;
            double a4 = a3 * 0.01;
            a4 = a4 + e + f;




            Console.WriteLine(a4);
        }
    }
}
