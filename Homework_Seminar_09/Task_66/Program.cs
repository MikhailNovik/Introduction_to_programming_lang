/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int RecSumNumbersFromMToN(int startNum, int endNum)
{
    if (startNum > endNum)
    {
        return 0;
    }
    else
    {
        return startNum + RecSumNumbersFromMToN(startNum + 1, endNum);
    }
}

Console.Write("Введите натуральное число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N (число N должно быть больше числа M): ");
int N = int.Parse(Console.ReadLine()!);

int sumNum = RecSumNumbersFromMToN(M, N);
Console.WriteLine($"Cумма натуральных чисел от {M} до {N}: {sumNum}");
