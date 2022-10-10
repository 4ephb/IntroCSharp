// Домашнее задание
// 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine($"43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

// Ручной ввод
Console.Write("Введите b1 для первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1 для первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b2 для второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2 для второй прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());

// // Пример 1 - ( -0,5 ; -0,5 )
// double b1 = 2;
// double k1 = 5;
// double b2 = 4;
// double k2 = 9;

// // Пример 2 - Прямые параллельны
// double b1 = 2;
// double k1 = 5;
// double b2 = 4;
// double k2 = 5;

// // Пример 3 - Прямые совпадают
// double b1 = 2;
// double k1 = 5;
// double b2 = 2;
// double k2 = 5;

void Cross(double k1, double b1, double k2, double b2)
{
    if (b1 == b2 && k1 == k2) Console.WriteLine($"\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> Прямые совпадают"); // if (k1 == k2) Console.WriteLine($"\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> Прямые не пересекаются");
    else if (b1 != b2 && k1 == k2) Console.Write($"\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> Прямые параллельны");
    else
    {
        double x = ((b2 - b1) / (k1 - k2));
        double y = b1 + k1 * x; // double y = (b2 * k1 - b1 * k2) / (k1 - k2);
        Console.WriteLine($"\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({Math.Round((decimal)x, 2)}; {Math.Round((decimal)y, 2)})");
    }
}

Cross(k1, b1, k2, b2);