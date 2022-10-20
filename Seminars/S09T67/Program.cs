// 67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.
// Например:
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр с помощью рекурсии.");

// Ручной ввод
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int n = 453;

int DigitsSumRec(int n)
{
    if (n < 10) return n;
    else return n % 10 + DigitsSumRec(n / 10);
}

int Sum = DigitsSumRec(n);
Console.Write($"{n} -> {Sum}");