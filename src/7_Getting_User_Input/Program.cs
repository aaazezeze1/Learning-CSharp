using System;

namespace _7_Getting_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write prints it out on the same line
            // Gets name input
            Console.Write("Enter your name: ");

            // ReadLine also takes user input
            // stores the string input in the variable called name 
            string name = Console.ReadLine();

            // Gets age input
            Console.Write("Enter your age: ");

            // stores the string input in the variable called age 
            string age = Console.ReadLine();

            // Prints name input
            Console.WriteLine("Hello " + name);

            // Prints name and age input
            Console.WriteLine("Hello " + name + " you are " + age);

            // Stops the program from closing as soon as executed (just like ReadLine)
            // Press any key on the keyboard to close the program 
            Console.ReadKey();
        }
    }
}
