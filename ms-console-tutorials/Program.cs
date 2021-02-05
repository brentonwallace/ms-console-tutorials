using System;

namespace ms_console_tutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("Hello World!");

            //Exploring integer math

            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("Variable a + b = " + c);
            Console.WriteLine("Variable a - b = " + (a - b));
            Console.WriteLine("Variable a * b = " + (a * b));
            Console.WriteLine("Variable a / b = " + (a / b));
            Console.WriteLine("Variable a % b = " + (a % b));
            Console.WriteLine();

            //Exploring order of operations

            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            Console.WriteLine("a + b * c = " + d);
            Console.WriteLine("(a + b) * c = " + (a + b) * c);
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine("(a + b) - 6 * c + (12 * 4) / 3 + 12 = " + d);
            Console.WriteLine();

            //Integer precision AND LIMITS

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
            Console.WriteLine();

            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"The range of integers is {min} to {max}");
            Console.WriteLine();

            // OR - Removes need for variables min and max =

            Console.WriteLine("The range of integers is " + int.MinValue + " to " + int.MaxValue);
            Console.WriteLine();


            Console.WriteLine("If a calculation produces a value that exceeds those limits, you have an underflow or overflow condition. The answer appears to wrap from one limit to the other.");
            Console.WriteLine();

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");








        }
    }
}
