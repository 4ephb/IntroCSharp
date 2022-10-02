// Домашнее задание
// 27. Программа принимает на вход число и выдаёт сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("27. Программа принимает на вход число и выдаёт сумму цифр в числе.");

int SumNumb(int num)
{
    int result = 0;
    num = Math.Abs(num); // int count = Convert.ToString(num).Length;
    for (int i = 0; num > 0; i++) // for (int i = 0; i < count; i++)
    {
        result = result + (num - (num - num % 10));
        num = num / 10;
    }
    return result;
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {N} равна {SumNumb(N)}.");