using System;

namespace ConsoleApp2._14
{
    internal class Program
    {

               // 6 dene 6 reqemli eded verilib.Evvel hamisini topla.Sonra I ve III ededi bir birine yapishdir ve bir eded al.
               //  I neticeden II neticeni cix. Alinan cavabin 10% tap.Neticenin uzerine V ve VI ededleri gel.Yekunda alinan cavabin 11% tap.


        static void Main(string[] args)
        {
            int a = 456723;
            int b = 789425;
            int c = 124794;
            int d = 652378;
            int e = 945782;
            int f = 745826;
            int qaliq;


            int g = a + b + c + d + e + f;//3714928


            while (g>0)
            {
                qaliq = g % 10000;
               int y  = (g - qaliq) / 10000;//371
               
                int qaliq1;
                qaliq1 = y % 100;//71
               y = (y - qaliq1) / 100;//1ci eded (3)
                int g1 = y % 10;// 3 cu eded (1)

                int x = y * 10 + 1;

                double x1 = (g - x)*0.1+e+f;
                double x2 = x1 * 0.11;

                Console.WriteLine(x2);//226940.747
                return;
            }

            
        }
    }
}
