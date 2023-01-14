/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
int GetExponentiation(int basePower, int exponentPower)
{
    int result = 1;
    for (int i = 0; i < exponentPower; i++)
    {
        result *= basePower;
    }

    return result;
}


Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат возведения числа {A} в степень {B}: {GetExponentiation(A, B)}");
