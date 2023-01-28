/*
Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
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

bool IsPossibleMatrixMultiplication(int[,] firstMat, int[,] secondMat)
{
    if(firstMat.GetLength(1) == secondMat.GetLength(0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] MatrixMultiplication(int[,] firstMat, int[,] secondMat)
{
    int[,] resultMatrix = CreateArray(firstMat.GetLength(0), secondMat.GetLength(1));

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sumProductsElem = 0;

            for (int k = 0; k < firstMat.GetLength(1); k++)
            {
                sumProductsElem += firstMat[i, k] * secondMat[k, j];
            }
            resultMatrix[i, j] = sumProductsElem; 
        }
    }

    return resultMatrix;
}

void PrintArray(int[,] array)
{
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row,column], -7} ");
        }
        Console.WriteLine();
    }
}

int[,] firstMatrix = CreateArray(2, 3);
FillArray(firstMatrix, 0, 99);
Console.WriteLine("Задана первая матрица:");
PrintArray(firstMatrix);
Console.WriteLine();

int[,] secondMatrix = CreateArray(3, 4);
FillArray(secondMatrix, 0, 99);
Console.WriteLine("Задана вторая матрица:");
PrintArray(secondMatrix);
Console.WriteLine();

if (IsPossibleMatrixMultiplication(firstMatrix, secondMatrix))
{
    int[,] multiplicationOfTwoMat = MatrixMultiplication(firstMatrix, secondMatrix);
    Console.WriteLine("Произведение двух матриц:");
    PrintArray(multiplicationOfTwoMat);
}
else
{
    Console.WriteLine("Невозможно получить произведение двух матриц");
}