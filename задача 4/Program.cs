﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int maximum = a;

if (maximum < b)
{
    maximum = b;
}
else
{
    maximum = a;
}
if (maximum < c)
{
    maximum = c;
}


Console.Write(maximum);

