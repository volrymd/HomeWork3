﻿// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear ();
Console.WriteLine("Введите положительное число: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1)
    {
       Console.WriteLine("Вы ошиблись!\nВведите положительное число: ");
       n = int.Parse(Console.ReadLine()!); 
    }
for (int i = 1; i <=n; i++)
    Console.Write ($"{Math.Pow(i,3)} ");