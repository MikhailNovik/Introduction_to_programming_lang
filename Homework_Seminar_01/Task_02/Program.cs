/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

int numberA;
int numberB;
Console.Write("Введите первое число: ");
numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
numberB = int.Parse(Console.ReadLine()!);

int max = numberA;

if (numberA >= numberB)
{
    Console.WriteLine("Максимальное число: " + max);
}
else
{
    max = numberB;
    Console.WriteLine("Максимальное число: " + max);
}
