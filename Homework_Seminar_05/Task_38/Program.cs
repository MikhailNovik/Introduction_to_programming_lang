/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] CreateArray(int count)
{
    return new double[count];
}

void FillArray(double[] array, double minValue, double maxValue)
{
    int length = array.Length;
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
    }
}

double GetMaximumElementArray(double[] array)
{
    int length = array.Length;
    double maximumElement = array[0];

    for (int i = 1; i < length; i++)
    {
        if (array[i] > maximumElement)
        {
            maximumElement = array[i];
        }
    }

    return maximumElement;
}

double GetMinimumElementArray(double[] array)
{
    int length = array.Length;
    double minimumElement = array[0];

    for (int i = 1; i < length; i++)
    {
        if (array[i] < minimumElement)
        {
            minimumElement = array[i];
        }
    }

    return minimumElement;
}

string PrintArray(double[] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join(" ", array);

    return outputSrt; 
}

Console.Write("Введите число элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
double[] arr = CreateArray(count);
FillArray(arr, -99, 99);
Console.WriteLine(PrintArray(arr));
double maxElem = GetMaximumElementArray(arr);
double minElem = GetMinimumElementArray(arr);
double difference = maxElem - minElem;
Console.WriteLine($"Разность между максимальным и минимальным элементов массива: {difference:f}");
