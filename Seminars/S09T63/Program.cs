// 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии
// Например:
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Clear();
Console.WriteLine("63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N с помощью рекурсии");

// Ручной ввод
// Console.Write("Задайте значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int n = 5,
    m = n;

int ShowNumbers(int n)
{
    Console.Write(m - (n - 1) + " ");
    if (n == 1) return 0;
    else return ShowNumbers(n - 1);
}

Console.Write($"N = {n} -> ");
ShowNumbers(n);