// while loop
//checks the condition first before executing the code inside the loop
int index = 1;

// continuous loop until index is 5
while (index <= 5)
{
    Console.WriteLine(index);
    index++;
}

Console.ReadLine();

// do while loop
// do while loop will execute the code inside of the loop before it checks the condition needed
int index = 6;

do
{
    Console.WriteLine(index);
    index++;
} while (index <= 5);

Console.ReadLine();