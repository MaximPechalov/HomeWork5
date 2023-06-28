Console.Clear();

int[] randomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int count (int[] array)
{
    int j = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0) j++;
    }
    return j;
}

int [] arr = randomArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(count(arr));