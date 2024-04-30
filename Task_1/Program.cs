
string[] GreateArrayStringConsole (string ConsolStr)
{
    string[] arrayStr;
    string[] _ = new string[ConsolStr.Length];
    arrayStr = ConsolStr.Split(",");
    return arrayStr;
}

string[] GreateArrGivenSize (string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;  
        }
    }
    return newArray;
}
void Print (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
Console.Write("Введите набор символов через знак (,) - ");
string StringStr = Console.ReadLine()!;
string[] ArrayStr = GreateArrayStringConsole(StringStr);

Console.Write("Введённый массив строк -> ");
Print(ArrayStr);
Console.WriteLine();

Console.Write($"Введённые символы длинной меньше либо равны 3 -> ");
Print(GreateArrGivenSize(ArrayStr));
