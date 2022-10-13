// 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 49 2
// 5 9 2 4
// 64 4 4 4

Console.Clear();
Console.WriteLine($"49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.");

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

int[,] ChangeSqrNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];

    }
    return array;
}

// Ручной ввод
// Console.Write("Введите количество рядов (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение элементов: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение элементов: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 3;
int n = 4;
int min = 1;
int max = 9;

int[,] Array = Fill2DArray(m, n, min, max);
Console.WriteLine("Изначальный массив:");
Show2DArray(Array);

int[,] sqrArray = ChangeSqrNum(Array);
Console.WriteLine("\nИтоговый массив:");
Show2DArray(sqrArray);
