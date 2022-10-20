// 65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии.
// Например:
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();
Console.WriteLine("65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N с помощью рекурсии.");

// Ручной ввод
// Console.Write("Задайте значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Задайте значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 4,
    n = 8;

void ShowNumbersRec(int m, int n)
{
    if (m != n) Console.Write(m + ", ");

    if (m > n)
    {
        if (m == n) Console.Write(n);
        else ShowNumbersRec(m - 1, n);
    }
    else
    {
        if (m == n) Console.Write(n);
        else ShowNumbersRec(m + 1, n);
    }
}

Console.Write($"M = {m}; N = {n} -> ");
ShowNumbersRec(m, n);