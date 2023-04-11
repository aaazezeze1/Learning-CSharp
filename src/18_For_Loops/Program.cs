// while loop version
int i = 1;

while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}


// for loop 
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.ReadLine();

// for loop with array
int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

for  (int i = 0; i < luckyNumbers.Length; i++)
{
    Console.WriteLine(luckyNumbers[i]);
}

Console.ReadLine();