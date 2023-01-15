/*

*/
int[] CreateArray(int count)
{
    return new int[count];
}

void FillArray(int[] array, int minValue, int maxValue)
{
    int length = array.Length;
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
}

void ReplaceElemWithAppropriate(int[] array)
{
    int length = array.Length;
    
    for (int i = 0; i < length; i++)
    {
        array[i] *= -1;
    }
}

string PrintArray(int[] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join(" ", array);

    return outputSrt; 
}

Console.Write("Введите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(count);
FillArray(arr, -9, 9);
Console.WriteLine(PrintArray(arr));
ReplaceElemWithAppropriate(arr);
Console.WriteLine(PrintArray(arr));
