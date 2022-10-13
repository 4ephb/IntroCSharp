// Домашнее задание
// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
Console.WriteLine($"52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

int[,] Fill2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void ColAverage(int[,] array)
{
    double sum;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{Math.Round(sum / array.GetLength(0), 2)} ");
    }
}

// Ручной ввод
// Console.Write("Введите количество рядов (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 3;
int n = 4;
// Console.WriteLine($"\nm = {m}, n = {n}.\n");

int[,] array = Fill2DArray(m, n, 1, 10);

// Генеративный ввод
// Random rnd = new Random();
// int[,] array = Fill2DArray(rnd.Next(2, 6), rnd.Next(2, 6), 1, 10);

Show2DArray(array);
ColAverage(array);
