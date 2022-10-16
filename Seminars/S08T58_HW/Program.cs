// Домашнее задание
// 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

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
            Console.Write("{0, 5}", array[i, j], 2);
        Console.WriteLine();
    }
}

int[,] MultiplyArray(int[,] arrayA, int[,] arrayB)
{
    int[,] result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

    int sum;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {     
            sum = 0;
            for (int k = 0; k < arrayA.GetLength(1); k++)
                sum += arrayA[i, k] * arrayB[k, j];
            result[i, j] = sum;
        }
    }
    return result;
}

// Ручной ввод
// Console.Write("Введите количество строк первой матрицы (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первой матрицы и строк второй матрицы (n): ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второй матрицы (m): ");
// int r = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 2;
int n = 2;
int r = 2;

int[,] M1 = Fill2DArray(m, n, 1, 9);
Console.WriteLine("Первая матрица:");
Show2DArray(M1);

int[,] M2 = Fill2DArray(n, r, 1, 9);
Console.WriteLine("Вторая матрица:");
Show2DArray(M2);

Console.WriteLine("\nРезультирующая матрица:");
int[,] M3 = MultiplyArray(M1, M2);
Show2DArray(M3);
