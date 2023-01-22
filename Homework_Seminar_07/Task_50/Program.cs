/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет
*/

int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];
}

void FillArray(int[,] array, int minValue, int maxValue)
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int column = 0; column < array.GetLength(1); column++)
        {
            Random rnd = new Random();
            array[row, column] = rnd.Next(minValue, maxValue + 1);            
        }
    }
}

void FindValueArrayElement(int row, int column, int[,] array)
{
    if(row < 0 || row >= array.GetLength(0) || column < 0 || column >= array.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента массива на позиции [{row + 1}, {column + 1}]: {array[row, column]}");
    }
}

void PrintArray(int[,] array)
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row,column], -4} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите позицию искомого элемента в строке массива: ");
int row = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите позицию искомого элемента в столбце массива: ");
int column = int.Parse(Console.ReadLine()!) - 1;

int[,] arr = CreateArray(4, 4);
FillArray(arr, 0, 99);
PrintArray(arr);
Console.WriteLine();
FindValueArrayElement(row, column, arr);