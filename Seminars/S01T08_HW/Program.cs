﻿// Домашнее задание
// 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());

int i = 1;

while (i <= A)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}");
        
        if (i < A - 1) Console.Write(", ");
        else Console.Write(".");
    }
    i++;
}