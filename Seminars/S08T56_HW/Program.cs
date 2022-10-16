// Домашнее задание
// 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

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

void ArrayRowSum(int[,] array)
{
    int[] RowSum = new int[array.GetLength(0)];
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) 
            RowSum[i] += array[i, j];
        if (RowSum[i] < RowSum[minRow]) minRow = i;
    }
    // Console.Write("[" + String.Join(", ", RowSum) + "]");
    Console.Write($"Строка с наименьшей суммой элементов: {minRow + 1} сторка. ");
}

// Ручной ввод
// Console.Write("Введите количество рядов (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 4;
int n = 4;

int[,] Array = Fill2DArray(m, n, 1, 9);
Console.WriteLine("Исходный массив:");
Show2DArray(Array);

ArrayRowSum(Array);
