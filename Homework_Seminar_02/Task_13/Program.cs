/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = int.Parse(Console.ReadLine()!);
if (threeDigitNumber < 100)
{
    Console.WriteLine($"У числа {threeDigitNumber} нет третьей цифры");
}
else
{
    while (threeDigitNumber > 999)
    {
        threeDigitNumber /= 10;        
    }
    int firstDecimalPlace = threeDigitNumber % 10;
    Console.WriteLine($"Третья цифра заданного числа: {firstDecimalPlace}");
}
