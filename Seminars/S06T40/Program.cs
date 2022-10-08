// 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//     Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Clear();
Console.WriteLine($"40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.");

void TriangleCorrect(int a, int b, int c)
{
    if( a < b + c && b < a + c && c < a + b) Console.Write("может существовать.");
    else Console.Write("не может существовать.");
}

// Ручной ввод
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

Console.Write($"Треугольник с длинами сторон ({A}, {B}, {C}) ");
TriangleCorrect(A, B, C);