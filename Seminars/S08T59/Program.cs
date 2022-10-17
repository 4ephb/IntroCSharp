// 59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.Clear();
Console.WriteLine("59. Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.");

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

int[,] RemoveRowCol(int[,] array)
{
    int rowMin = 0;
    int colMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < array[rowMin, colMin])
            {
                rowMin = i;
                colMin = j;
            }
    }

    if (array.GetLength(0) < 2 || array.GetLength(1) < 2)
        return new int[0, 0];

    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            if (i < rowMin && j < colMin) result[i, j] = array[i, j];
            else if (i < rowMin && j >= colMin) result[i, j] = array[i, j + 1];
            else if (i >= rowMin && j < colMin) result[i, j] = array[i + 1, j];
            else result[i, j] = array[i + 1, j + 1];
        }
    }
    return result;
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

int[,] ArrayRM = RemoveRowCol(Array);
Console.WriteLine("\nИтоговый массив:");
Show2DArray(ArrayRM);
