// Домашнее задание
// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет

Console.Clear();
Console.WriteLine($"50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

double[,] Fill2DArray(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            array[i, j] = new Random().Next(min, max + 1);//+ new Random().NextDouble();
    }
    return array;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 1) + "  ");
        Console.WriteLine();
    }
}

void ResultMsg(double[,] array, int i, int j)
{
    if (i <= array.GetLength(0) && j <= array.GetLength(1) && i >= 0 && j >= 0)
        Console.Write($"{i},{j} -> {array[i - 1, j - 1]}");
    else Console.Write($"{i},{j} -> элемента с данными индексами в массиве нет");
}

// Ручной ввод
// Console.Write("Введите количество рядов (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 6;
int n = 4;

Console.WriteLine($"\nm = {m}, n = {n}.\n");

double[,] array = Fill2DArray(m, n, 1, 10);
Show2DArray(array);

Console.Write("\nВведите позицию элемента в двумерном массиве (ряд): ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позиции элемента в двумерном массиве (столбец): ");
int y = Convert.ToInt32(Console.ReadLine());

ResultMsg(array, x, y);
