Console.Clear();

double[] Randomarray(int size, double minValue, double maxValue)
{
    double[] result = new double [size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue + 1) + minValue;
    }
    return result;
}

void Minmax (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]<min) min=array[i];
        if(array[i]>max) max=array[i];
    }
    Console.WriteLine($"minimal value: {min:f2}");
    Console.WriteLine($"maximal value: {max:f2}");
    Console.WriteLine($"difference: {max - min:f2}");
}

double[] arr = Randomarray(5, -10, 10);
Console.WriteLine(String.Join(" " , arr));
Minmax(arr);

