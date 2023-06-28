Console.Clear();

int[] randomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue +1);
    }
    return result;
}

int count(int[] arary)
{
    int j = 0;
    for (int i = 0; i < arary.Length; i+=2)
    {
        j+=arary[i];
    }
    return j;
}

int[] arr = randomArray(10, -10, 10);
Console.WriteLine(String.Join(" ", arr));
Console.WriteLine(count(arr));