using System;

namespace FizzBuzz
{
    class Program
    {
        // test values
        static int test1 = 0;
        static int test2 = 6;
        static int test3 = 10;
        static int test4 = 30;
        static int test5 = -2;

        static void Main() // main
        {
            Console.WriteLine(FizzBuzz(test3));

            Console.ReadLine();
        }

        static string FizzBuzz(int num)
        {
            /* Returns FizzBuzz if num is divisible by 3 and 5, Fizz if only by 3, 
             Buzz if only by 5, else it returns the original number num*/
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return $"{num}";
            }
        }
    }
}
