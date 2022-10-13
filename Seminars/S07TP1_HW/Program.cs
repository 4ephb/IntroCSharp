// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): 
// Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.
// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

// 2 4 7 2
// 4 3 5 3
// 2 1 6 2 -> да

Console.Clear();
Console.WriteLine("Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех \"углах\" двумерного массива.");

int[,] Fill2DArray(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

double[] ColAverage(int[,] array)
{
    double sum;
    int[] result = new int[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j]= Math.Round(sum / array.GetLength(0), 2);
    }
    return result;
}



// Ручной ввод
// Console.Write("Введите количество рядов (m): ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов (n): ");
// int n = Convert.ToInt32(Console.ReadLine());

// Пример
int m = 3;
int n = 4;
// Console.WriteLine($"\nm = {m}, n = {n}.\n");

int[,] array = Fill2DArray(m, n, 1, 10);




// Генеративный ввод
// Random rnd = new Random();
// int[,] array = Fill2DArray(rnd.Next(2, 6), rnd.Next(2, 6), 1, 10);

Show2DArray(array);
Console.Write(" -> ");

Console.Write("Среднее арифметическое каждого столбца: ");
int[] ColAverageArray = ColAverage(array);
Show2DArray(ColAverageArray);