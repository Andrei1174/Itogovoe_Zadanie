
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