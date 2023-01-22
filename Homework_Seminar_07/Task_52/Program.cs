/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateTwoDimArray(int rows, int columns)
{
    return new int[rows, columns];
}

double[] CreateOneDimArray(int count)
{
    return new double[count];
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

double[] ArithmeticMeanColumnsArray(int[,] oldArray)
{
    double[] newArray = CreateOneDimArray(oldArray.GetLength(1));

    for(int column = 0; column < oldArray.GetLength(1); column++)
    {
        double sum = 0;

        for(int row = 0; row < oldArray.GetLength(0); row++)
        {
            sum += oldArray[row, column];            
        }

        double arithmeticMean = sum / oldArray.GetLength(1);
        newArray[column] = arithmeticMean;        
    }

    return newArray;
    
}

void PrintTwoDimArray(int[,] array)
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

string PrintOneDimArray(double[] array)
{
    string outputSrt = String.Empty;
    outputSrt = string.Join("; ", array);

    return outputSrt; 
}

int[,] arr = CreateTwoDimArray(4, 4);
FillArray(arr, 0, 99);
PrintTwoDimArray(arr);
double[] newArr = ArithmeticMeanColumnsArray(arr);
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца массива: {PrintOneDimArray(newArr)}");