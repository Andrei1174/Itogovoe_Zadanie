
string[] GreateArrayStringConsole (string ConsolStr)
{
    string[] arrayStr;
    string[] _ = new string[ConsolStr.Length];
    arrayStr = ConsolStr.Split(",");
    return arrayStr;
}