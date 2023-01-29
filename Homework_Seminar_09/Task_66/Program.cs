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
        int sum = startNum + RecSumNumbersFromMToN(startNum + 1, endNum);
        return sum;
    }
}
int startNumber = 1;
int endNumber = 15;
int sumNum = RecSumNumbersFromMToN(startNumber, endNumber);
Console.WriteLine($"Cумма натуральных чисел от {startNumber} до {endNumber}: {sumNum}");
