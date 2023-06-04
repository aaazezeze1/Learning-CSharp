static int GetPow(int baseNum, int powNum)
{
    int result = 1;

    for (int i = 0; i < powNum; i++)
    {
        result = result * baseNum;
    }

    return result;
}

Console.WriteLine(GetPow(3, 2));
Console.WriteLine(GetPow(4, 3));

Console.ReadLine();