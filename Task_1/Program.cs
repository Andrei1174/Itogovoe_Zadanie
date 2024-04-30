
string[] GreateArrayStringConsole (string ConsolStr)
{
    string[] arrayStr;
    string[] _ = new string[ConsolStr.Length];
    arrayStr = ConsolStr.Split(",");
    return arrayStr;
}

void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
