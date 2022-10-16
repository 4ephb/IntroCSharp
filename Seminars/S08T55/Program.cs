// 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например:
// Исходный массив:
// 9 2 3
// 4 2 4
// 2 6 7

// Результат замены:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();
Console.WriteLine("55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.");

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

void ReverseArray(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) Console.WriteLine($"Невозможно заменить строки на столбцы в двумерном массиве ({array.GetLength(0)} x {array.GetLength(1)}).");
    else
    {   
        int temp;
        for (int i = 0; i < array.GetLength(0) - 1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        Console.WriteLine("\nРезультат замены:");
        Show2DArray(array);
    }
}

// Ручной ввод
// Console.Write("Введите количество рядов (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 3;
int n = 3;

int[,] Array = Fill2DArray(m, n, 1, 9);
Console.WriteLine("Исходный массив:");
Show2DArray(Array);

ReverseArray(Array);
