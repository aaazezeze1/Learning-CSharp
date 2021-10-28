using System;

namespace _13_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;

            // no need to add == isMale because the program
            // automatically assumes that the condition is true
            if (isMale)
            {
                Console.WriteLine("You are male");
            }
            else 
            {
                Console.WriteLine("You are not male");
            }

            bool isTall = true;
            // && is and
            // || is or

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            }
            // male but not tall
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are a short male");
            }
            // tall but not male
            else if (isTall && !isMale)
            {
                Console.WriteLine("You are not a male but you are tall");
            }
            else
            {
                Console.WriteLine("You are either not male and not tall");
            }

            // * More If Statements

            // two numbers
            Console.WriteLine(GetMax(2, 10));
            Console.WriteLine(GetMax(20, 10));

            // three numbers
            Console.WriteLine(GetMax(20, 10, 4));
            Console.WriteLine(GetMax(20, 10, 40));

            Console.ReadLine();
        }
        static int GetMax(int num1, int num2)
        {
            int result;

            // two numbers
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }

            return result;
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}
