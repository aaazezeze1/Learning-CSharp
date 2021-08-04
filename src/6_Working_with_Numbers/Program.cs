using System;

namespace _6_Working_with_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integer
            Console.WriteLine(40);
            Console.WriteLine(20);
            Console.WriteLine(50);

            // Decimal
            Console.WriteLine(-5.783);

            // Addition
            Console.WriteLine(5 + 8);

            // Subtraction
            Console.WriteLine(5 - 8);

            // Division
            Console.WriteLine(5 / 8);

            // Multiplication
            Console.WriteLine(5 * 8);

            // Modulus Operator
            // gives the remainder of 5 / 2 and can also be used to check
            // whether a number is divisible or not 
            Console.WriteLine(5 % 2);

            // Order of Operations
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine((4 + 2) * 3);

            // Decimals and Integers
            // gives decimal numbers back 
            Console.WriteLine(5.0 + 8.1);
            Console.WriteLine(5 + 8.1);

            // gives an integer number back 
            Console.WriteLine(5 / 2);

            // gives a decimal number back 
            Console.WriteLine(5 / 2.0);

            // Variables
            int num = 6;
            Console.WriteLine(num);

            // Increment
            // add 1 
            num++;
            Console.WriteLine(num);

            // minus 1 
            num = 6;
            num--;
            Console.WriteLine(num);

            // Methods
            // Absolute Value
            Console.WriteLine(Math.Abs(-40));

            // Power
            // 3 raised to the 2nd power 
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Pow(3.8, 2));

            // Square Root
            Console.WriteLine(Math.Sqrt(36));

            // Max
            // tells you which one is bigger 
            Console.WriteLine(Math.Max(4, 90));

            // Min
            // tells you which one is smaller 
            Console.WriteLine(Math.Min(4, 90));

            // Round 
            // round off decimal numbers
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.6));

            Console.ReadLine();
        }
    }
}
