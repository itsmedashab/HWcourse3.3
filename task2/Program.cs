// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int xa, xb, ya, yb, za, zb;
Console.Write($"Введите координату Х точки А: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.Write($"Введите координату Y точки А: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.Write($"Введите координату Z точки А: ");
int.TryParse(Console.ReadLine()!, out za);
Console.Write($"Введите координату Х точки B: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.Write($"Введите координату Y точки B: ");
int.TryParse(Console.ReadLine()!, out yb);
Console.Write($"Введите координату Z точки B: ");
int.TryParse(Console.ReadLine()!, out zb);

double ans = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));

Console.Write($"Расстояние между точками А и B в 3D пространстве = {Math.Round(ans, 2)}\n");