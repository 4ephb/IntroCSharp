// 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных:
// { 1, 9, 9, 0, 2, 8, 0, 9 }

// Частотный массив:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// Набор данных:
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// Частотный массив:
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();
Console.WriteLine("57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.");

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

int[] Flat2DArray(int[,] array)
{
    int[] result = new int[array.GetLength(0) * array.GetLength(1)];
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            index = j + (array.GetLength(1) * i); // Индекс элемента одномерного массива
            result[index] = array[i, j];
        }
    }

    // int temp;
    // for (int i = 0; i < result.Length - 1; i++)
    // {
    //     for (int j = 0; j < result.Length - 1; j++)
    //         if (result[j] > result[j + 1])
    //         {
    //             temp = result[j];
    //             result[j] = result[j + 1];
    //             result[j + 1] = temp;
    //         }
    // }

    Array.Sort(result);
    return result;
}

void PrintData(int[] array)
{
    int el = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] != el)
        {
            Console.Write($"{el} встречается {count} ");
            if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4) Console.WriteLine("раза");
            else Console.WriteLine("раз");
            el = array[i];
            count = 1;
        }
        else count++;
    }
    Console.Write($"{el} встречается {count} ");
    if (count % 10 == 2 || count % 10 == 3 || count % 10 == 4) Console.WriteLine("раза");
    else Console.WriteLine("раз");
}

// Ручной ввод
// Console.Write("Введите количество строк (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 3;
int n = 3;

int[,] ArrayA = Fill2DArray(m, n, 1, 9);
Console.WriteLine("Набор данных:");
Show2DArray(ArrayA);

Flat2DArray(ArrayA);

Console.WriteLine($"{String.Join(", ", Flat2DArray(ArrayA))}");

Console.WriteLine("\nЧастотный массив:");
PrintData(Flat2DArray(ArrayA));
