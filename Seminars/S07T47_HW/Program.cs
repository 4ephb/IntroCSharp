// Домашнее задание
// 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Например:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine($"47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.");

double[,] Fill2DArray(int row, int col, int min, int max)
{
    double[,] array = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            array[i, j] = new Random().Next(min, max) + new Random().NextDouble();
    }
    return array;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + "  ");
        Console.WriteLine();
    }
}

Console.Write("Введите количество рядов (m): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов (n): ");
int n = Convert.ToInt32(Console.ReadLine());

// int m = 20;
// int n = 4;

double[,] Array = Fill2DArray(m, n, 1, 10);
Show2DArray(Array);
