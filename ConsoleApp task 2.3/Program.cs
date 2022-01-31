using System;

namespace ConsoleApp_task_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 750;

            double a1;


            if (a>=100&&a<1000)

            {
                a1 = a * 0.18;

                 a=a * 0.3;


                Console.WriteLine(a1);
                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("3reqemli deyil");
            }
        }
    }
}
