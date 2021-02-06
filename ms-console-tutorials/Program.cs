using System;

namespace ms_console_tutorials
{
    class Program
    {




        static void ExploreIf()
        {
            //Make decisions using the if statement

            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

            b = 3;

            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
            else
                Console.WriteLine("The answer is not greater than 10.");

            Console.WriteLine();

            Console.WriteLine("Because indentation isn't significant, you need " +
                "to use { and } to indicate when you want more than one statement " +
                "to be part of the block that executes conditionally.");
            Console.WriteLine();


            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10.");
            }


            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            Console.WriteLine();


            // Use loops to repeat operations



            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }



            counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
            Console.WriteLine();





            //Work with the for loop

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
            Console.WriteLine();


            
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
            Console.WriteLine();





        }
















        public static void Main(string[] args)
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


            Console.WriteLine("If a calculation produces a value that exceeds " +
                "those limits, you have an underflow or overflow condition. " +
                "The answer appears to wrap from one limit to the other.");
            Console.WriteLine();

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
            Console.WriteLine();

            double f = 5;
            double g = 4;
            double h = 2;
            double j = (f + g) / h;
            Console.WriteLine(j);
            Console.WriteLine();

            f = 19;
            g = 23;
            h = 8;
            j = (f + g) / h;
            Console.WriteLine(j);
            Console.WriteLine();


            double maxd = double.MaxValue;
            double mind = double.MinValue;
            Console.WriteLine($"The range of double is {mind} to {maxd}");

            Console.WriteLine();

            Console.WriteLine("You've seen the basic numeric types in C#: intege" +
                "rs and doubles. There's one other type to learn: the decimal ty" +
                "pe. The decimal type has a smaller range but greater precision than double.");
            Console.WriteLine();


            //Work with decimal types


            decimal mindc = decimal.MinValue;
            decimal maxdc = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {mindc} to {maxdc}");

            Console.WriteLine("Notice that the range is smaller than the double " +
                "type. You can see the greater precision with the decimal type by " +
                "trying the following code:");
            Console.WriteLine();

            Console.WriteLine("double ab = 1.0;");
            Console.WriteLine("double bb = 3.0;");

            double ab = 1.0;
            double bb = 3.0;

            Console.WriteLine("ab / bb = " + (ab / bb));
            Console.WriteLine();


            Console.WriteLine("decimal cb = 1.0M;");
            Console.WriteLine("decimal db = 3.0M;");

            decimal cb = 1.0M;
            decimal db = 3.0M;

            Console.WriteLine("cb / db = " + (cb / db));
            Console.WriteLine();

            Console.WriteLine("The M suffix on the numbers is how you indicate " +
                "that a constant should use the decimal type.");

            Console.WriteLine();

            Console.WriteLine("Challange:");
            Console.WriteLine("Now that you've seen the different numeric types," +
                " write code that calculates the area of a circle whose radius is 2.50 centimeters.");
            Console.WriteLine();
            Console.WriteLine("Solution #1:");
            Console.WriteLine("double areaOfCircle = (2.50 * 2.50) * Math.PI;");


            double areaOfCircle = (2.50 * 2.50) * Math.PI;
            Console.WriteLine("The area of a circle with a radius of 2.50cm is " + areaOfCircle);
            Console.WriteLine();

            // OR without using variables ->

            Console.WriteLine("Solution #2:");
            Console.WriteLine("Console.WriteLine(The area of a circle with a radius of 2.50cm is  + (2.50 * 2.50) * Math.PI);");
            Console.WriteLine("The area of a circle with a radius of 2.50cm is " + (2.50 * 2.50) * Math.PI);
            Console.WriteLine();
            Console.WriteLine();










            //LEARN CONDITIONAL LOGIC WITH BRANCH AND LOOP STATEMENTS

            ExploreIf();














        }
    }
}
