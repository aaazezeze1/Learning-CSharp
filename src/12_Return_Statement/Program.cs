using System;

namespace _12_Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // To see the output returned to the computer
            Console.WriteLine(cube(5));

            // does the same thing but you can modify the value using the variable cubedNumber
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);

            Console.ReadLine();
        }
        static int cube(int num)
        {
            int result = num * num * num;
            // returns value to computer not user
            return result;
        }
    }
}
