// 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Например:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
Console.WriteLine("26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.");

int NumbCount(int num)
{
    int i;
    for (i = 0; num > 0; i++) num = num / 10;
    return i;
}

Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine($"Количество цифр в числе {N} равно {NumbCount(N)}.");
