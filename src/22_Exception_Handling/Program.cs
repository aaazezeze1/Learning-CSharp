// Exception Handling - try and catch block
try
{
    Console.Write("Enter a Number: ");

    // Convert String to Integer
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(num1 / num2);
}

// catch any exception and print the reason 
catch (Exception e)
{
    //Console.WriteLine("Error");
    Console.WriteLine(e.Message);
}

// catches the divide by zero problem
catch (DivideByZeroException e)
{
    //Console.WriteLine("Error");
    Console.WriteLine(e.Message);
}

// catches the string problem
catch (FormatException  e)
{
    Console.WriteLine(e.Message);
}

// any code inside finally will be executed no matter what
finally
{

}

Console.ReadLine();