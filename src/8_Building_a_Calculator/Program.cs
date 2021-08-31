using System;

namespace _8_Building_a_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // To convert string number to integer number
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 6);

            // Adding integers together
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            // Adding decimals together
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
