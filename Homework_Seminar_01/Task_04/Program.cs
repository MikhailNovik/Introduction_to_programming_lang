/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int numberA;
int numberB;
int numberC;
Console.Write("Введите первое число: ");
numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
numberB = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
numberC = int.Parse(Console.ReadLine()!);

int max = numberA;

if (numberA >= numberB)
{
    if (numberA >= numberC)
    {
        Console.WriteLine("Максимальное число: " + max);
    }
    else
    {
        max = numberC;
        Console.WriteLine("Максимальное число: " + max);
    }
}
else
{
    max = numberB;
    if (numberB >= numberC)
    {
        Console.WriteLine("Максимальное число: " + max);
    }
    else
    {
        max = numberC;
        Console.WriteLine("Максимальное число: " + max);
    }

}
