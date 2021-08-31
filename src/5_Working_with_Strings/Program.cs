using System;

namespace _5_Working_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Girrafe Academy");

            // New Line Character
            Console.WriteLine("Girrafe \nAcademy");

            // Printing a Quotation Mark
            Console.WriteLine("Giraffe \"Academy");

            // Variable
            string phrase = "Girrafe Academy";
            Console.WriteLine(phrase);

            // Concatenation
            phrase = "Girrafe Academy " + "is cool";
            Console.WriteLine(phrase);

            // Find out information about the string
            phrase = "Girrafe Academy";

            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.Contains("Academies"));

            // Methods
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());

            // Access individual characters in a string
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase[8]);

            // Check if it contains something and show the first value's index position
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf('f'));

            // This will print out -1 which means that the value is not inside the string phrase
            Console.WriteLine(phrase.IndexOf('z'));

            // Substring
            // Grabs one part of the string and prints it
            Console.WriteLine(phrase.Substring(8));

            // This will start grabbing the characters at index 8 up until the 3rd character
            Console.WriteLine(phrase.Substring(8, 3));
            
            Console.ReadLine();
        }
    }
}
