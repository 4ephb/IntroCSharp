﻿// 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// Например:
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
Console.WriteLine("12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.");

// int Num1 = new Random().Next(1, 11);
// Console.WriteLine($"Первое число: {Num1}");
// int Num2 = new Random().Next(1, 11);
// Console.WriteLine($"Второе число: {Num2}");

Console.Write($"Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num2 % Num1 == 0) Console.WriteLine($"Второе число ({Num2}) кратно первому числу ({Num1}).");
else Console.WriteLine($"Остаток от деления: {Num2 % Num1}");