/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру, обозначающую день недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine()!);

if (numberDayOfWeek >= 1 && numberDayOfWeek <= 5)
{
    Console.WriteLine("Нет, этот день не является выходным");
}
else
{
    Console.WriteLine("Да, этот день является выходным");
}
