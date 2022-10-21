// Домашнее задание
// 68. Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// Например:
// M = 28; N = 7 -> 7

Console.Clear();
Console.WriteLine("68. Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.");

// Ручной ввод
// Console.Write("Задайте значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 28,
    n = 7;

int NOD(int m, int n)
{
    if (m % n == 0) return n;
    return NOD(n, m % n);
}

int res = NOD(m, n);
Console.Write($"M = {m}; N = {n} -> {res}");