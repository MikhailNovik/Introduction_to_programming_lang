/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool IsPalindrome(int num)
{
    string input = num.ToString();

    if (input[0] == input[4] && input[1] == input[3])
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (IsPalindrome(num))
{
    Console.WriteLine("Введенное пятизначное число является палиндромом");
}
else
{
    Console.WriteLine("Введенное пятизначное число не является палиндромом");
}
