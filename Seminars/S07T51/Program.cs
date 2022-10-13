// 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12

Console.Clear();
Console.WriteLine($"51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали с индексами (0,0); (1;1) и т.д.");

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

void DiagSum(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j) 
            {
                sum += array[i, j];
                Console.Write($"{array[i, j]} + ");
            }
    }
    Console.Write("\b\b= " +  sum);
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
int m = 4;
int n = 4;
int min = 1;
int max = 9;

int[,] Array = Fill2DArray(m, n, min, max);
Show2DArray(Array);

Console.Write($"Сумма элементов главной диагонали: ");
DiagSum(Array);
