/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


void FindPointIntersectionTwoLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Прямые пересекаются в точке: [{x:f}; {y:f}]");
    }
    
}


Console.Write("Введите угловой коэффициент k уравнения первой прямой: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите свободный член b уравнения первой прямой: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите угловой коэффициент k уравнения второй прямой: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите свободный член b уравнения второй прямой: ");
double b2 = double.Parse(Console.ReadLine()!);

FindPointIntersectionTwoLines(k1, b1, k2, b2);