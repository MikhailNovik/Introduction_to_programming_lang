/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int RecAckermannFunc(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else
    {
        if(M != 0 && N == 0)
        {
            return RecAckermannFunc(M - 1, 1);
        }
        else
        {
            return RecAckermannFunc(M - 1, RecAckermannFunc(M, N - 1));
        }
    }
}

Console.Write("Введите неотрицательное число m: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите неотрицательное число n: ");
int N = int.Parse(Console.ReadLine()!);

int result = RecAckermannFunc(M, N);
Console.WriteLine($"Результат вычисления функции Аккермана для m={N}, n={M}: {result}");
