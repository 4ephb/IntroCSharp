// 24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36


Console.Clear();
Console.WriteLine("24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.");

int SumOfNumb(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++) sum += i;
    return sum; 
}

Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {A} равна {SumOfNumb(A)}.");