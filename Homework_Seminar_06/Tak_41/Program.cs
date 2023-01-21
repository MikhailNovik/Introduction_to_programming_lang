/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] CreateArray(int count)
{
    return new int[count];
}

void FillArray(int[] array)
{
    int length = array.Length;
    
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

int GetCountPositiveNumbers(int[] array)
{
    int length = array.Length;
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }        
    }
    return count;
}

string PrintArray(int[] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join(" ", array);

    return outputSrt;
}

Console.Write("Введите количество элементов в массиве: ");
int count = int.Parse(Console.ReadLine()!);
int[] arr = CreateArray(count);
FillArray(arr);
Console.WriteLine(PrintArray(arr));
int result = GetCountPositiveNumbers(arr);
Console.WriteLine($"Количество положительных чисел в массиве: {result}");