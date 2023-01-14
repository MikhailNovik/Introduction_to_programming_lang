/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
int[] CreateArray(int count)
{
    return new int[count];
}

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;

    while (index < length)
    {
        Random rnd = new Random();
        int currentValue = rnd.Next(0, 100);
        array[index] = currentValue;
        index += 1;
    }
}

string PrintArray(int[] array)
{
    string outputSrt = String.Empty;
    outputSrt = "[" + string.Join(", ", array) + "]";

    return outputSrt;
}

int count = 8;
int[] arr = CreateArray(count);
FillArray(arr);
Console.WriteLine(PrintArray(arr));
