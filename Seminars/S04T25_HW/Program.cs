// Домашнее задание
// 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например:
// 3,5 -> 243 (3⁵)
// 2,4 -> 16

Console.Clear();
Console.WriteLine("25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

double Exp(int num1, int num2)
{
    double result = 1.0;
    for (int i = 1; i <= Math.Abs(num2); i++)
    {
        if (num2 > 0) result = result * num1;
        else result = result / num1;
    }
    return result;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (A == 0 && B < 0) Console.WriteLine("Неверный ввод!");
else if (B > 0) Console.WriteLine($"Число {A} в натуральной степени {B} равно {Exp(A, B)}.");
else if (B < 0) Console.WriteLine($"Число {A} в отрицательной степени {B} равно {Exp(A, B)}.");
else Console.WriteLine($"Число {A} в {B}-й степени равно {Exp(A, B)}.");
