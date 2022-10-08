// Домашнее задание
// 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например:
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Clear();
Console.WriteLine($"42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.");

string Binary(int num)
{
    string bin = string.Empty;
    while (num > 0)
    {
       bin = num % 2 + bin;
       num /= 2;
    }
    return bin;
}

Console.Write("Ведите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{n} -> ");

int variant = new Random().Next(0, 2);
if (variant == 1) Console.Write(Binary(n));
else Console.Write(Convert.ToString(n, toBase: 2));
//Console.Write($" {variant}");
