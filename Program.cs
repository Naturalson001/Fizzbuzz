
using System;
using System.Diagnostics.Metrics;

namespace Task_Range;
class Program
{
    public static void Main()
    {

        Console.WriteLine("Enter a number:");
        var N = int.Parse (Console.ReadLine());
        Console.WriteLine(Inputs(N));

        static object Inputs(int N)
        {
            for (int i = 1; i <= N; i++)
            {

                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");


                }

                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);

                }


                
              
            }
            Console.Read();
            return true ;
           
        }

        


    }
}


