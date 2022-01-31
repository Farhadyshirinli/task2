using System;

namespace ConsoleApp2._11
{
    internal class Program
    {
//         4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.
//Sonra cavablari vur birbirine.Alinan neticeden III ededin 3%-ni cix.

        static void Main(string[] args)
        {
            int a = 46850;
            
            double qaliq;


            while (a >0) 
            {
                qaliq = a % 10;//6850

                double a1 = (a - qaliq) / 100;//4

                Console.WriteLine(a1);
                return;
            }
            int b;

            


        }
    }
}
