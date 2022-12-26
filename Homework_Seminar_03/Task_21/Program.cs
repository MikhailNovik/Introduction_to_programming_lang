/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double GetDistanceBetweenPoints(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distanceBetweenPoints = Math.Sqrt(
        (xB - xA) * (xB - xA)
         + (yB - yA) * (yB - yA)
          + (zB - zA) * (zB - zA)
        );
    return Math.Round(distanceBetweenPoints, 2);
}

double xA = 7;
double yA = -5;
double zA = 0;
double xB = 1;
double yB = -1;
double zB = 9;

double distance = GetDistanceBetweenPoints(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между двумя точками A и B в 3D пространстве равно {distance}");