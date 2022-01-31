using System;

namespace ConsoleApp2._5
{

                                                //  4 reqemli eded verilib.Bu ededin evvelin 4 reqemi ,
                                                //  axirina ise 44 ededini artir.Alinan cavabin 44 % tap.

    internal class Program
    {
        
        static void Main(string[] args)
        {

            int a = 3386;
            int qaliq;
            double b;

            while (a>0)
            {
                qaliq = a % 1000;

                a = (a - qaliq)/1000;
                a = ((a + 40)*1000)+qaliq;
                a = a * 100 + 44;
                b = a * 0.44;
                Console.WriteLine(a);
                Console.WriteLine(b);

                

                return;

            }

            
        }
    }
}
