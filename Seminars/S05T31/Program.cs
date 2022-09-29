// 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

Console.Clear();
Console.WriteLine($"31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray(int[] array)
{
    Console.WriteLine("[" + String.Join(",", array)+ "]"); // for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
    // Console.WriteLine();
}

int FindPosSum(int[] array)
{
    int sum = 0;
    foreach (int element in array) sum += element > 0 ? element : 0; // for (int i = 0; i < array.Length; i++) if (array[i] > 0) sum += array[i];
    return sum;
}

int FindNegSum(int[] array)
{
    int sum = 0;
    foreach (int element in array) sum += element < 0 ? element : 0; // for (int i = 0; i < array.Length; i++) if (array[i] < 0) sum += array[i];
    return sum;
}

// Ручной ввод
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение гененрируемого диапазона: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение гененрируемого диапазона: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreatRandomArray(size, minValue, maxValue);

// Генеративный ввод
int[] Array = FillArray(12, -9, 9);

ShowArray(Array);

int PosSum = FindPosSum(Array);
int NegSum = FindNegSum(Array);

Console.WriteLine($"Сумма положитеельных чисел равна {PosSum}, сумма отрицательных равна {NegSum}.");
