using System;

namespace ConsoleApp2._7
{
    internal class Program
    {
        //2 dene 5 reqemli eded verilib. Bu ededleri toplayib.
        //Alinan cavabin evveline ve axirina 5 artir. Neticenin 5 % tap

        static void Main(string[] args)
        {

            int a = 5220;
            int b = 8848;
            int c = a + b;
            int x;
            double y;
            int qaliq;

            while (c>0)
            {
                c = c * 10 + 5;//140685
                x= (c % 100000); //40685
                qaliq = (c - x) / 100000+50; //51
                qaliq = qaliq * 100000+x;
                y = qaliq * 0.05;

                //qaliq = qaliq / 100000;

              
                    Console.WriteLine(qaliq);
                Console.WriteLine(y);


                return;
            }
            
        }
    }
}
