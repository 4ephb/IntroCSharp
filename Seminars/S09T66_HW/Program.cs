// Домашнее задание
// 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// Например:
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();
Console.WriteLine("66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.");

// Ручной ввод
// Console.Write("Задайте значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 4,
    n = 8;

int ShowNumbersSumRec(int m, int n)
{
    if (m == n) return m;
    else if (m < n) return m + ShowNumbersSumRec(m + 1, n);
    else return m + ShowNumbersSumRec(m - 1, n);
}

int Sum = ShowNumbersSumRec(m, n);
Console.Write($"M = {m}; N = {n} -> {Sum}");
