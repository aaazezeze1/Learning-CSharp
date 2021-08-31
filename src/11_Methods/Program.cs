using System;

namespace _11_Methods
{
    class Program
    {
        /* This is called the Main method
        any code that's inside the main 
        method gets executed when the 
        program runs */
        static void Main(string[] args)
        {
            // To call / execute the method
            SayHi();

            SayHi("Mike");
            SayHi("John");
            SayHi("Tom");

            SayHi("Mike", 33);
            SayHi("John", 56);
            SayHi("Tom", 12);
        }

        // Method format
        static return_type method_name() { }
        static void SayHi()
        {
            Console.WriteLine("Hello User");
        }

        // Adding parameters in the method
        // adding a name parameter
        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        // adding an age parameter
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}
