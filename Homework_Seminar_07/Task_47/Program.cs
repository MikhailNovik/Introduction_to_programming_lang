/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreateArray(int rows, int columns)
{
    return new double[rows, columns];
}

void FillArray(double[,] array, double minValue, double maxValue)
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int column = 0; column < array.GetLength(1); column++)
        {
            Random rnd = new Random();
            array[row, column] = rnd.NextDouble() * (maxValue - minValue) + minValue;            
        }
    }
}

void PrintArray(double[,] array)
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row,column]:f}\t");
        }
        Console.WriteLine();
    }
}

double[,] arr = CreateArray(rows:3,columns:4);
FillArray(arr, 0, 99);
PrintArray(arr);
