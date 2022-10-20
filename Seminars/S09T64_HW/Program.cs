// Домашнее задание
// 64. Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// Например:
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8

Console.Clear();
Console.WriteLine("64. Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.");

// Ручной ввод
// Console.Write($"Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 4,
    n = 8,
    k = n;

int ShowEvenNumbers(int n, int m)
{
    if (n % 2 == 0) Console.Write(k - n + " ");
    if (n != m) return ShowEvenNumbers(n - 1, m);
    else return 0;

    // if (n == m) ShowEvenNumbers(n, m - 1);
    // Console.Write(m + " ");
}

Console.Write($"M = {m}; N = {n} -> ");
ShowEvenNumbers(n, m);