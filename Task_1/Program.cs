
string[] GreateArrayStringConsole (string ConsolStr)
{
    string[] arrayStr;
    string[] _ = new string[ConsolStr.Length];
    arrayStr = ConsolStr.Split(",");
    return arrayStr;
}

Console.Write("Введите набор символов через знак (,) - ");
string StringStr = Console.ReadLine()!;
string[] ArrayStr = GreateArrayStringConsole(StringStr);

Console.Write("Введённый массив строк -> ");
Print(ArrayStr);
Console.WriteLine();

Console.Write($"Введённые символы длинной меньше либо равны 3 -> ");
Print(GreateArrGivenSize(ArrayStr));