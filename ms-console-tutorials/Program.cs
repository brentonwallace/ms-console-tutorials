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














        }
    }
}
