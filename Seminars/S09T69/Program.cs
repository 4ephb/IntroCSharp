// 69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// Например:
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.");

// Ручной ввод
// Console.Write("Введите число A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Пример
int a = 3,
    b = 5;

int ABPowRec(int a, int b)
{
    if (b == 0) return 1;
    return a * ABPowRec(a, b - 1);
}

int res = ABPowRec(a, b);
Console.Write($"A = {a}; B = {b} -> {res}");