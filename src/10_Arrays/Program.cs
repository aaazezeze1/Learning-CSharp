using System;

namespace _10_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array of integers
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //    array index = { 0, 1, 2,  3,  4,  5  }

            // Accessing individual elements in an array
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[2]);

            // Changing an element in an array
            luckyNumbers[1] = 900;
            Console.WriteLine(luckyNumbers[1]);

            // An array of strings
            // an array that doesn't have elements inside it, just yet
            // this array can store 5 elements 
            string[] friends = new string[5];

            // Giving values to an array
            friends[0] = "Jim";
            friends[1] = "Kelly";

            Console.ReadLine();
        }
    }
}
