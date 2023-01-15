/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
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

int GetCountEvenNumbers(int[] array)
{
    int length = array.Length;
    int countEvenNumbers = 0;
    
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countEvenNumbers += 1;
        }
    }
    return countEvenNumbers;
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
FillArray(arr, 100, 999);
Console.WriteLine(PrintArray(arr));
int countEvenNum = GetCountEvenNumbers(arr);
Console.WriteLine($"Количество чётных чисел в массиве: {countEvenNum}");
