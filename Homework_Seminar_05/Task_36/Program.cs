/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на чётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
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

int GetSumElementsEvenPositions(int[] array)
{
    int length = array.Length;
    int sumElementsEvenPos = 0;
    
    for (int i = 0; i < length; i++)
    {
        if ((i + 1) % 2 == 0)
        {
            sumElementsEvenPos += array[i];
        }
    }

    return sumElementsEvenPos;
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
FillArray(arr, -99, 99);
Console.WriteLine(PrintArray(arr));
int sumElem = GetSumElementsEvenPositions(arr);
Console.WriteLine($"Сумма элементов, стоящих на чётных позициях в массиве: {sumElem}");
