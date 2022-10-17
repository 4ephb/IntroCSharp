// Домашнее задание
// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой):
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");

// Ручной ввод
// Console.Write("Введите количество строк (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 4;
int n = 4;

int[,] array = FillArraySpiral(m, n);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write("{0, 4}", "0" + $"{array[i, j]} ", 2);
            else Console.Write("{0, 4}", $"{array[i, j]} ", 2);
        }
        Console.WriteLine();
    }
}

int[,] FillArraySpiral(int m, int n)
{
    int[,] array = new int[m, n];
    int pathRight = 0,
        pathLeft = 1,
        pathUp = 3,
        pathDown = 4,
        path = pathRight,
        minRow = 1,
        maxRow = array.GetLength(0) - 1,
        minCol = 0,
        maxCol = array.GetLength(1) - 1,
        row = 0,
        col = 0,
        stepRow = 0,
        stepCol = 1;

    for (int step = 1; step <= array.Length; step++)
    {
        array[row, col] = step;
        if (path == pathRight && col == maxCol)
        {
            maxCol--;
            path = pathDown;
            stepRow = 1;
            stepCol = 0;
        }
        else if (path == pathDown && row == maxRow)
        {
            maxRow--;
            path = pathLeft;
            stepRow = 0;
            stepCol = -1;
        }
        else if (path == pathLeft && col == minCol)
        {
            minCol++;
            path = pathUp;
            stepRow = -1;
            stepCol = 0;
        }
        else if (path == pathUp && row == minRow)
        {
            minRow++;
            path = pathRight;
            stepRow = 0;
            stepCol = 1;
        }
        row += stepRow;
        col += stepCol;
    }
    return array;
}

PrintArray(array);