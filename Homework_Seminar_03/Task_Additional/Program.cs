/*
Дополнительно
Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
11 -> 2, 3, 5 , 7, 11
*/
bool IsPrime(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Простые числа от 1 до {N}:");

for (int i = 2; i <= N; i++)
{
    if (IsPrime(i))
    {
        Console.Write($"{i}, ");
    }
}