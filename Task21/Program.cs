// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
Console.Write("Введите координату X(1): ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y(1): ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z(1): ");
double z1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату X(2): ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y(2): ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z(2): ");
double z2 = double.Parse(Console.ReadLine()!);
double S = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние равно {Math.Round(S, 2)}");
