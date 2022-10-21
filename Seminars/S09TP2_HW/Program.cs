// Домашнее задание
// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): 
// Напишите программу, которая выводит монотонную последовательность из N элементов в виде равностороннего треугольника с помощью рекурсии
// Пример:
// N = 5 -> https://ibb.co/9nZgLtY

Console.Clear();
Console.WriteLine("Напишите программу, которая выводит монотонную последовательность из N элементов в виде равностороннего треугольника с помощью рекурсии");

// Ручной ввод
// Console.Write("Введите положительное значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int f = 1,
    n = 5,
    m = n;

Console.WriteLine($"N = {n}");

void ShowTriangle(int f, int n)
{
    if (f > m) 
        return;
    for (int i = 0; i < n - 1; i++) 
        Console.Write("  ");
    for (int j = 1; j <= f; j++) 
        Console.Write("{0, 4}", $"{f}  ");

    Console.WriteLine();
    ShowTriangle(f + 1, n - 1);
}

ShowTriangle(f, n);