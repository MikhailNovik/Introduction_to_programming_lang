/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int FindRowWiitnSmallestSumElem(int[,] array)
{
    int indexSearchRow = 0;
    int smallestSum = 2147483647;

    for (int row = 0; row < array.GetLength(0); row++)
    {
        int sumElemRow = 0;        
                
        for(int column = 0; column < array.GetLength(1); column++)
        {
           sumElemRow += array[row, column];
        }

        if (sumElemRow < smallestSum)
        {
            smallestSum = sumElemRow;
            indexSearchRow = row;
        }
    }

    return indexSearchRow;
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

int[,] arr = CreateArray(3, 4);
FillArray(arr, 0, 99);
Console.WriteLine("Задан массив:");
PrintArray(arr);
Console.WriteLine();
int rowNumber = FindRowWiitnSmallestSumElem(arr) + 1;
Console.WriteLine($"Порядковый номер строки масива с наименьшей суммой элементов: {rowNumber}");
