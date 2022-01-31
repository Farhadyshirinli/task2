using System;

namespace ConsoleApp_task2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 456;

            bool isSucces = (a >= 100 && a < 1000);

            if (isSucces)
            {
                a = a * 1000;

                a = a + 456;


                Console.WriteLine(a);

            }
            else
            {
                Console.WriteLine("4reqemli deyil");
            }
        }
    }
}
