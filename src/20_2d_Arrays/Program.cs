// 2d array
int[,] numberGrid =
{
    // element at index 0
    {1, 2},
    // element at index 1
    {3, 4},
    // element at index 2
    {5, 6}
};

// the array will have 2 rows and 3 columns
int[,] myArray = new int[2, 3];

// access row 0 column 0
Console.WriteLine(numberGrid[0, 0]);

Console.WriteLine(numberGrid[1, 1]);
Console.ReadLine();