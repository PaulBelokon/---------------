string[] array = { "Tome", "Broad", "xD", "15" };

int id = GetArray(array);

GetScore(array, id);

int GetArray(string[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 3)
        {
            index++;
        }
    }
    return index;
}

void GetScore(string[] array, int id)
{
    string[] result = new string[id];
    int n = 0;

    for (int k = 0; k < array.Length; k++)
    {
        if (array[k].Length < 3)
        {
            result[n] = array[k];
            n++;
        }
    }
    Console.WriteLine(string.Join(",", result));
}
