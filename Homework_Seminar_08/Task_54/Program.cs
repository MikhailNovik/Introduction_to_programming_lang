/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortDescendingRowsArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            int maxPosition = i;

            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[row, j] > array[row, maxPosition])
                {
                    maxPosition = j;
                }
            }
            int temp = array[row, i];
            array[row, i] = array[row, maxPosition];
            array[row, maxPosition] = temp;
        }
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

int[,] arr = CreateArray(3, 3);
FillArray(arr, 0, 99);
Console.WriteLine("Задан массив:");
PrintArray(arr);
Console.WriteLine();
Console.WriteLine("Массив после сортировки:");
SortDescendingRowsArray(arr);
PrintArray(arr);
