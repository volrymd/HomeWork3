// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine()!;
while (number.Length != 5)
    {
        Console.WriteLine("Вы ошиблись!\nВведите пятизначное число: ");
        number = Console.ReadLine()!;
    }
int n1 = Convert.ToInt32(number[0].ToString());
int n2 = Convert.ToInt32(number[1].ToString());
int n4 = Convert.ToInt32(number[3].ToString());
int n5 = Convert.ToInt32(number[4].ToString());
if (n1 == n5 && n2 == n4)
    Console.WriteLine("Это палиндром!");
else
    Console.WriteLine("Это не палиндром!");