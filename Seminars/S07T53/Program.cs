// 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Изначальный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Итоговый массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

Console.Clear();
Console.WriteLine($"53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.");

int[,] Fill2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            array[i, j] = new Random().Next(min, max + 1);
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write("{0, 3}", array[i, j], 2);
        Console.WriteLine();
    }
}

void ChangeRows(int[,] array, int row1, int row2)
{   
    int X;
    if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            X = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = X;
        }
}

// Ручной ввод
// Console.Write("Введите количество рядов (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 5;
int n = 4;

int[,] Array = Fill2DArray(m, n, 1, 10);
Console.WriteLine("Изначальный массив:");
Show2DArray(Array);

ChangeRows(Array, 0, m - 1);
Console.WriteLine("\nИтоговый массив:");
Show2DArray(Array);
