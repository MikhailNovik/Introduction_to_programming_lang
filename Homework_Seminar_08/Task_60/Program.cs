/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

int[] CreateOneDimArray(int count = 90)
{
    return new int[count];
}

int[,,] CreateThreeDimArray(int dimension1, int dimension2, int dimension3)
{
    return new int[dimension1, dimension2, dimension3];
}


void FillArrayNumFrom10To99(int[] array)
{
    int initialTwoDigitNumber = 10;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = initialTwoDigitNumber;
        initialTwoDigitNumber++;
    }
}

void Shuffle(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(i, array.Length);

        int temp = array[i];          
        array[i] = array[randomIndex];
        array[randomIndex] = temp;
    }
}

bool IsPossibleFillArrayNonRepeatTwoDigNum(int[,,] array)
{
    if(array.GetLength(0) * array.GetLength(1) * array.GetLength(2) <= 90)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void FillThreeDimArray(int[] oneDimArray, int[,,] threeDimArray)
{
    int count = 0;

    for(int i = 0; i < threeDimArray.GetLength(0); i++)
    {
        for(int j = 0; j < threeDimArray.GetLength(1); j++)
        {
            for(int k = 0; k < threeDimArray.GetLength(2); k++)
            {
                threeDimArray[i, j, k] = oneDimArray[count];
                count++;
            }
        }
    }
}

void PrintThreeDimArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k], -2}({i}, {j}, {k})| ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[] arrTwoDigNum = CreateOneDimArray();
FillArrayNumFrom10To99(arrTwoDigNum);
Shuffle(arrTwoDigNum);

Console.WriteLine("Задайте трехмерный массив");
Console.Write("Введите длину массива в первом измерении: ");
int dim1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину массива во втором измерении: ");
int dim2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину массива в третьем измерении: ");
int dim3 = int.Parse(Console.ReadLine()!);

int[,,] threeDimArr = CreateThreeDimArray(dim1, dim2, dim3);

if (IsPossibleFillArrayNonRepeatTwoDigNum(threeDimArr))
{
    FillThreeDimArray(arrTwoDigNum, threeDimArr);
    Console.WriteLine($"Массив размером {dim1} X {dim2} X {dim3}");
    PrintThreeDimArray(threeDimArr);
}
else
{
    Console.WriteLine("Заданный Вами массив невозможно заполнить неповторяющимися двузначными числами");
}
