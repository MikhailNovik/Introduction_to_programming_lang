/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int GetSumDigits(int number)
{
    int sum = 0;
    string str = number.ToString();
    int length = str.Length;
    
    for(int i = 0; i < length; i++)
    {
        sum += Convert.ToInt32(str[i].ToString());
    }
    
    return sum;
}


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num}: {GetSumDigits(num)}");
