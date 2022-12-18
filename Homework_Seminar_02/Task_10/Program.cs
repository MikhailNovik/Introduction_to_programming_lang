/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = int.Parse(Console.ReadLine()!);
int thirdDecimalPlace = threeDigitNumber / 100;
int secondDecimalPlace = threeDigitNumber / 10 - (thirdDecimalPlace * 10);

Console.WriteLine($"Вторая цифра числа {threeDigitNumber}: {secondDecimalPlace}");
